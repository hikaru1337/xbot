﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XBOT.DataBase;

#nullable disable

namespace XBOT.Migrations
{
    [DbContext(typeof(db))]
    [Migration("20230803093653_emojigift")]
    partial class emojigift
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.2.23128.3");

            modelBuilder.Entity("XBOT.DataBase.Guild_Logs", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("TextChannelId")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TextChannelId");

                    b.ToTable("Guild_Logs");
                });

            modelBuilder.Entity("XBOT.DataBase.Guild_Warn", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("CountWarn")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("ReportTypes")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Guild_Warn");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.EmojiGift", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("EmojiId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("PriceTrade")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmojiId");

                    b.HasIndex("UserId");

                    b.ToTable("EmojiGift");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.EmojiGift_emojiadded", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Factor")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EmojiGift_emojiadded");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.GiveAways", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surpice")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("TextChannelId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimesEnd")
                        .HasColumnType("TEXT");

                    b.Property<uint>("WinnerCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TextChannelId");

                    b.ToTable("GiveAways");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Invites.DiscordInvite", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DiscordUsesCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InviteKey")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("DiscordInvite");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Invites.DiscordInvite_ConnectionAudit", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ConnectionTime")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("InviteId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InviteId");

                    b.HasIndex("UserId");

                    b.ToTable("ConnectionAudits");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Invites.DiscordInvite_ReferralLink", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("InviteId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InviteId");

                    b.HasIndex("UserId");

                    b.ToTable("ReferralLinks");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Invites.DiscordInvite_ReferralRole", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("RolesId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("UserJoinedValue")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("UserUp5LevelValue")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("UserWriteInWeekValue")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RolesId");

                    b.ToTable("ReferralRole");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.PrivateChannel", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PrivateChannel");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles_Buy", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Roles_Buy");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles_Gived", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("MessageId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Roles_Gived");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles_Level", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Roles_Level");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles_Reputation", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Reputation")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Roles_Reputation");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles_User", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Roles_User");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Settings", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("AdminRoleId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("IventerRoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LeaveMessage")
                        .HasColumnType("TEXT");

                    b.Property<ulong?>("LeaveTextChannelId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("ModeratorRoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Prefix")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("PrivateMessageId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("PrivateTextChannelId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("PrivateVoiceChannelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("WelcomeDMmessage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("WelcomeDMuser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WelcomeMessage")
                        .HasColumnType("TEXT");

                    b.Property<ulong?>("WelcomeRoleId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("WelcomeTextChannelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdminRoleId");

                    b.HasIndex("IventerRoleId");

                    b.HasIndex("LeaveTextChannelId");

                    b.HasIndex("ModeratorRoleId");

                    b.HasIndex("PrivateTextChannelId");

                    b.HasIndex("WelcomeRoleId");

                    b.HasIndex("WelcomeTextChannelId");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1ul,
                            Prefix = "x.",
                            PrivateMessageId = 0ul,
                            PrivateVoiceChannelId = 0ul,
                            Status = "Prefix: `x.`",
                            WelcomeDMuser = false
                        });
                });

            modelBuilder.Entity("XBOT.DataBase.Models.TransactionUsers_Logs", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("RecipientId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("SenderId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeTransaction")
                        .HasColumnType("TEXT");

                    b.Property<byte>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId")
                        .IsUnique();

                    b.HasIndex("SenderId")
                        .IsUnique();

                    b.ToTable("TransactionUsers_Logs");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.User", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("BirthDateComplete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlockReason")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("CountSex")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastMessageTime")
                        .HasColumnType("TEXT");

                    b.Property<ulong?>("MarriageId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("MarriageTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReferalActivate")
                        .HasColumnType("TEXT");

                    b.Property<ulong?>("RefferalInviteId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("RefferalInviteId1")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("User_Permission_Id")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("XP")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("daily_Time")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("lastReputationUserId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("messageCounterForDaily")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("money")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("reputation")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("reputation_Time")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("streak")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("voiceActive_private")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("voiceActive_public")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MarriageId");

                    b.HasIndex("RefferalInviteId1");

                    b.ToTable("User");
                });

            modelBuilder.Entity("XBOT.DataBase.TextChannel", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("SettingsId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("delUrl")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("delUrlImage")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("giveXp")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("inviteLink")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("useAdminCommand")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("useCommand")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("useRPcommand")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SettingsId");

                    b.ToTable("TextChannel");
                });

            modelBuilder.Entity("XBOT.DataBase.User_Permission", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("CountWarn")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Unlimited")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("User_Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("User_Id")
                        .IsUnique();

                    b.ToTable("User_Permission");
                });

            modelBuilder.Entity("XBOT.DataBase.User_UnWarn", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("AdminId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("Admin_Id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndStatusSet")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReviewAdd")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("Warn_Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("User_UnWarn");
                });

            modelBuilder.Entity("XBOT.DataBase.User_Warn", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("AdminId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("Admin_Id")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("Guild_WarnsId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("Guild_Warns_Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeSetWarn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ToTimeWarn")
                        .HasColumnType("TEXT");

                    b.Property<ulong?>("UnWarn_Id")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WarnSkippedAfterUnban")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WarnSkippedBecauseNewTimeWarn")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("Guild_WarnsId");

                    b.HasIndex("UnWarn_Id")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("User_Warn");
                });

            modelBuilder.Entity("XBOT.DataBase.Guild_Logs", b =>
                {
                    b.HasOne("XBOT.DataBase.TextChannel", "TextChannel")
                        .WithMany("Guild_Logs")
                        .HasForeignKey("TextChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TextChannel");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.EmojiGift", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.EmojiGift_emojiadded", "Emoji")
                        .WithMany("emojiGifts")
                        .HasForeignKey("EmojiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XBOT.DataBase.Models.User", "User")
                        .WithMany("EmojiGift")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emoji");

                    b.Navigation("User");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.GiveAways", b =>
                {
                    b.HasOne("XBOT.DataBase.TextChannel", "TextChannel")
                        .WithMany("GiveAways")
                        .HasForeignKey("TextChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TextChannel");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Invites.DiscordInvite", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.User", "Author")
                        .WithMany("MyInvites")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Invites.DiscordInvite_ConnectionAudit", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.Invites.DiscordInvite", "Invite")
                        .WithMany("ConnectionAudits")
                        .HasForeignKey("InviteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XBOT.DataBase.Models.User", "User")
                        .WithMany("MyConnectionAudits")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invite");

                    b.Navigation("User");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Invites.DiscordInvite_ReferralLink", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.Invites.DiscordInvite", "Invite")
                        .WithMany("ReferralLinks")
                        .HasForeignKey("InviteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XBOT.DataBase.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invite");

                    b.Navigation("User");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Invites.DiscordInvite_ReferralRole", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.Roles_data.Roles", "Roles")
                        .WithMany("DiscordInvite_ReferralRole")
                        .HasForeignKey("RolesId");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.PrivateChannel", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles_Buy", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.Roles_data.Roles", "Role")
                        .WithMany("Roles_Buy")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles_Gived", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.Roles_data.Roles", "Role")
                        .WithMany("Roles_Gived")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles_Level", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.Roles_data.Roles", "Role")
                        .WithMany("Roles_Level")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles_Reputation", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.Roles_data.Roles", "Role")
                        .WithMany("Roles_Reputation")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles_User", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.Roles_data.Roles", "Role")
                        .WithMany("Roles_User")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XBOT.DataBase.Models.User", "User")
                        .WithMany("Roles_User")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Settings", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.Roles_data.Roles", "AdminRole")
                        .WithMany()
                        .HasForeignKey("AdminRoleId");

                    b.HasOne("XBOT.DataBase.Models.Roles_data.Roles", "IventerRole")
                        .WithMany()
                        .HasForeignKey("IventerRoleId");

                    b.HasOne("XBOT.DataBase.TextChannel", "LeaveTextChannel")
                        .WithMany()
                        .HasForeignKey("LeaveTextChannelId");

                    b.HasOne("XBOT.DataBase.Models.Roles_data.Roles", "ModeratorRole")
                        .WithMany()
                        .HasForeignKey("ModeratorRoleId");

                    b.HasOne("XBOT.DataBase.TextChannel", "PrivateTextChannel")
                        .WithMany()
                        .HasForeignKey("PrivateTextChannelId");

                    b.HasOne("XBOT.DataBase.Models.Roles_data.Roles", "WelcomeRole")
                        .WithMany()
                        .HasForeignKey("WelcomeRoleId");

                    b.HasOne("XBOT.DataBase.TextChannel", "WelcomeTextChannel")
                        .WithMany()
                        .HasForeignKey("WelcomeTextChannelId");

                    b.Navigation("AdminRole");

                    b.Navigation("IventerRole");

                    b.Navigation("LeaveTextChannel");

                    b.Navigation("ModeratorRole");

                    b.Navigation("PrivateTextChannel");

                    b.Navigation("WelcomeRole");

                    b.Navigation("WelcomeTextChannel");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.TransactionUsers_Logs", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.User", "Recipient")
                        .WithOne()
                        .HasForeignKey("XBOT.DataBase.Models.TransactionUsers_Logs", "RecipientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XBOT.DataBase.Models.User", "Sender")
                        .WithOne()
                        .HasForeignKey("XBOT.DataBase.Models.TransactionUsers_Logs", "SenderId");

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.User", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.User", "Marriage")
                        .WithMany()
                        .HasForeignKey("MarriageId");

                    b.HasOne("XBOT.DataBase.Models.Invites.DiscordInvite_ReferralLink", "RefferalInvite")
                        .WithMany()
                        .HasForeignKey("RefferalInviteId1");

                    b.Navigation("Marriage");

                    b.Navigation("RefferalInvite");
                });

            modelBuilder.Entity("XBOT.DataBase.TextChannel", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.Settings", "Settings")
                        .WithMany()
                        .HasForeignKey("SettingsId");

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("XBOT.DataBase.User_Permission", b =>
                {
                    b.HasOne("XBOT.DataBase.Models.User", "User")
                        .WithOne("User_Permission")
                        .HasForeignKey("XBOT.DataBase.User_Permission", "User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("XBOT.DataBase.User_UnWarn", b =>
                {
                    b.HasOne("XBOT.DataBase.User_Permission", "Admin")
                        .WithMany("unwarnlist")
                        .HasForeignKey("AdminId");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("XBOT.DataBase.User_Warn", b =>
                {
                    b.HasOne("XBOT.DataBase.User_Permission", "Admin")
                        .WithMany("warnlist")
                        .HasForeignKey("AdminId");

                    b.HasOne("XBOT.DataBase.Guild_Warn", "Guild_Warns")
                        .WithMany("User_Warns")
                        .HasForeignKey("Guild_WarnsId");

                    b.HasOne("XBOT.DataBase.User_UnWarn", "UnWarn")
                        .WithOne("Warn")
                        .HasForeignKey("XBOT.DataBase.User_Warn", "UnWarn_Id");

                    b.HasOne("XBOT.DataBase.Models.User", "User")
                        .WithMany("User_Warn")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Guild_Warns");

                    b.Navigation("UnWarn");

                    b.Navigation("User");
                });

            modelBuilder.Entity("XBOT.DataBase.Guild_Warn", b =>
                {
                    b.Navigation("User_Warns");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.EmojiGift_emojiadded", b =>
                {
                    b.Navigation("emojiGifts");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Invites.DiscordInvite", b =>
                {
                    b.Navigation("ConnectionAudits");

                    b.Navigation("ReferralLinks");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.Roles_data.Roles", b =>
                {
                    b.Navigation("DiscordInvite_ReferralRole");

                    b.Navigation("Roles_Buy");

                    b.Navigation("Roles_Gived");

                    b.Navigation("Roles_Level");

                    b.Navigation("Roles_Reputation");

                    b.Navigation("Roles_User");
                });

            modelBuilder.Entity("XBOT.DataBase.Models.User", b =>
                {
                    b.Navigation("EmojiGift");

                    b.Navigation("MyConnectionAudits");

                    b.Navigation("MyInvites");

                    b.Navigation("Roles_User");

                    b.Navigation("User_Permission");

                    b.Navigation("User_Warn");
                });

            modelBuilder.Entity("XBOT.DataBase.TextChannel", b =>
                {
                    b.Navigation("GiveAways");

                    b.Navigation("Guild_Logs");
                });

            modelBuilder.Entity("XBOT.DataBase.User_Permission", b =>
                {
                    b.Navigation("unwarnlist");

                    b.Navigation("warnlist");
                });

            modelBuilder.Entity("XBOT.DataBase.User_UnWarn", b =>
                {
                    b.Navigation("Warn");
                });
#pragma warning restore 612, 618
        }
    }
}
