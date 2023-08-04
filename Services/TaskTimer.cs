﻿using Microsoft.EntityFrameworkCore;
using XBOT.DataBase;
using XBOT.Services.Configuration;

namespace XBOT.Services
{
    public class TaskTimer
    {
        private readonly DiscordSocketClient _client;
        private readonly Guild_Logs_Service _guildlogs;
        public TaskTimer(DiscordSocketClient client, Guild_Logs_Service guildlogs)
        {
            _client = client;
            _guildlogs = guildlogs;
        }

        internal Task StartEveryHoursScan()
        {
            EveryHoursScan();

            System.Timers.Timer TaskTime = new(new TimeSpan(0, 60, 0));
            TaskTime.Elapsed += (s, e) => EveryHoursScan();
            TaskTime.Start();
            return Task.CompletedTask;
        }
        private async void EveryHoursScan()
        {
            var Users = _client.Guilds.First().Users;
            await Refferal_Service.ReferalRoleScaningUser(Users);
        }

        
        

        

        private static readonly TimeSpan TimeAddExp = new TimeSpan(0, 0, 10);

        internal static Task StartVoiceActivity(SocketGuildUser User)
        {
            System.Timers.Timer TaskTime = new(TimeAddExp);
            TaskTime.Elapsed += (s, e) => VoiceActivity(s);
            TaskTime.Start();
            return Task.CompletedTask;
            //Timer TaskTime = new Timer(VoiceActivity, User, time, time);
            //await Task.CompletedTask;
        }
        private static async void VoiceActivity(object obj)
        {
            using (db db = new())
            {
                SocketGuildUser User = obj as SocketGuildUser;
                if (User.VoiceChannel != null && User.VoiceChannel.Id != User.Guild.AFKChannel?.Id)
                {
                    if (User.VoiceChannel.Users.Count > 1)
                    {
                        uint CountSpeak = 0;
                        bool ThisUserActive = false;
                        foreach (var UserChannel in User.VoiceChannel.Users)
                        {
                            var UserStatus = UserChannel.VoiceState.Value;

                            if (!UserStatus.IsMuted && !UserStatus.IsDeafened &&
                                !UserStatus.IsSelfMuted && !UserStatus.IsSelfDeafened &&
                                !UserChannel.IsBot)
                            {
                                CountSpeak++;

                                if (UserChannel.Id == User.Id)
                                    ThisUserActive = true;
                            }
                        }

                        if (ThisUserActive && CountSpeak > 1)
                        {
                            var isPrivateChannel = await db.PrivateChannel.AnyAsync(x => x.Id == User.VoiceChannel.Id);
                            var user = await db.GetUser(User.Id);
                            if (isPrivateChannel)
                                user.voiceActive_private += TimeAddExp;
                            else
                                user.voiceActive_public += TimeAddExp;

                            user.XP += 10;
                            db.User.Update(user);
                            await db.SaveChangesAsync();
                        }
                    }
                }
                else
                {
                    var Timer = obj as System.Timers.Timer;
                    Timer?.Dispose();
                }
            }
        }


        internal Task StartWarnTimer(User_Warn Warn)
        {
            System.Timers.Timer TaskTime = new((Warn.ToTimeWarn - DateTime.Now).TotalMilliseconds);
            TaskTime.AutoReset = false;
            if (Warn.Guild_Warns.ReportTypes == Guild_Warn.ReportTypeEnum.TimeBan)
                TaskTime.Elapsed += (s, e) => BanTimer(Warn);
            else
                TaskTime.Elapsed += (s, e) => MuteTimer(Warn);
            TaskTime.Start();
            return Task.CompletedTask;
        }
        private async void BanTimer(User_Warn Warn)
        {
            var Guild = _client.Guilds.FirstOrDefault();
            var ThisBan = await Guild.GetBanAsync(Warn.UserId);
            if (ThisBan != null)
                await Guild.RemoveBanAsync(ThisBan.User);
        }

        private async void MuteTimer(User_Warn Warn) // Обновление бесконечного мута
        {
            using (var Db = new db())
            {
                Warn = Db.User_Warn.Include(x=>x.UnWarn).FirstOrDefault(x => x.Id == Warn.Id);
                if (Warn.UnWarn_Id == null || 
                   (Warn.UnWarn != null && Warn.UnWarn.Status != User_UnWarn.WarnStatus.review && Warn.UnWarn.Status != User_UnWarn.WarnStatus.Rejected))
                {
                    var Guild = _client.Guilds.FirstOrDefault();
                    var User = Guild.GetUser(Warn.UserId);
                    if (User != null)
                    {
                        var TimeSpan = new TimeSpan(28, 0, 0, 0);
                        await User.SetTimeOutAsync(TimeSpan);
                        Warn.ToTimeWarn.Add(TimeSpan);
                        Db.User_Warn.Update(Warn);
                        await Db.SaveChangesAsync();
                    }
                }
            }
        }




        internal Task StartBirthdates()
        {
            using (db db = new())
            {
                var TimeNow = DateTime.Now;
                
                var UsersBirthdayInThisYear = db.User.Where(x => x.BirthDateComplete == TimeNow.Year).ToList();
                foreach (var User in UsersBirthdayInThisYear)
                {
                    DateTime UserDateTime = User.BirthDate.ToDateTime(new TimeOnly(10,0,0));
                    var Time = UserDateTime.AddYears(TimeNow.Year - User.BirthDate.Year) - TimeNow;

                    System.Timers.Timer TaskTime = new(Time.TotalHours <= 168 ? 1000 : Time.TotalMilliseconds);
                    TaskTime.AutoReset = false;
                    TaskTime.Elapsed += (s, e) => Birthdates(User);
                    TaskTime.Start();

                }
                return Task.CompletedTask;
            }
        }

        private async void Birthdates(User User)
        {
            using (db db = new())
            {
                User = db.User.FirstOrDefault(x => x.Id == User.Id);
                var UserDiscord = _client.GetUser(User.Id) as SocketGuildUser;
                if (UserDiscord == null)
                    return;

                var emb = new EmbedBuilder().WithColor(BotSettings.DiscordColor).WithAuthor("С днем рождения солнышко🎉");

                DateTime TimeNow = DateTime.Now;

                User.BirthDateComplete = (ushort)(TimeNow.Year + 1);
                db.User.Update(User);
                await db.SaveChangesAsync();

                await _guildlogs.Birthday(UserDiscord);


                if (TimeNow.Day <= User.BirthDate.Day)
                    emb.WithDescription("Солнышко, я слышал у тебя сегодня день рождения?\n\nЯ робот, и не очень хорошо умею говорить умные слова,\nно спасибо что ты есть, не опускай руки, я тебя люблю <3");
                else
                    emb.WithDescription("Солнышко, я слышал у тебя был день рождения?\nС днем рождения солнце!!!\n\nПрости не смог поздравить тебя сразу, надеюсь за меня это сделали твои друзья :)");
                try
                {
                    await UserDiscord.SendMessageAsync("", false, emb.Build());
                }
                catch { }
            }
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}