﻿using DevChatter.Bot.Core.Commands;
using DevChatter.Bot.Core.Messaging;
using DevChatter.Bot.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace DevChatter.Bot.Infra.Ef
{
    public class AppDataContext : DbContext
    {
        public DbSet<IntervalMessage> IntervalMessages { get; set; }
        public DbSet<SimpleCommand> SimpleResponseMessages { get; set; }
        public DbSet<FollowsCommand> FollowerCommands { get; set; }
        public DbSet<QuoteEntity> QuoteEntities { get; set; }

        public AppDataContext()
        { }

        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options)
        { }

    }
}