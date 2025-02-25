﻿using Microsoft.EntityFrameworkCore;
using EventManagementTrialCFA.Models;
//change

namespace EventManagementTrialCFA
{
    public class EventManagementDbContext : DbContext
    {
        public EventManagementDbContext(DbContextOptions<EventManagementDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasOne(e => e.User)
                .WithMany(u => u.Events)
                .HasForeignKey(e => e.OrganizerId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Tickets)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.NoAction); ; // Add this configuration

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Event)
                .WithMany(e => e.Tickets)
                .HasForeignKey(t => t.EventId)
                .OnDelete(DeleteBehavior.NoAction); ; // Add this configuration
        }
    }
}
