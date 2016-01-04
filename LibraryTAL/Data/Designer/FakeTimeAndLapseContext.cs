// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.52
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace LibraryTAL.Data.Designer
{
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class FakeTimeAndLapseContext : ITimeAndLapseContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Championship> Championships { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Manch> Manches { get; set; }
        public DbSet<Partecipant> Partecipants { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Run> Runs { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Sysdiagram> Sysdiagrams { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Timing> Timings { get; set; }
        public DbSet<TimingType> TimingTypes { get; set; }

        public FakeTimeAndLapseContext()
        {
            Categories = new FakeDbSet<Category>("CategoryId");
            Championships = new FakeDbSet<Championship>("ChampionshipId");
            Events = new FakeDbSet<Event>("EventId");
            Manches = new FakeDbSet<Manch>("MancheId");
            Partecipants = new FakeDbSet<Partecipant>("PartecipantId");
            Players = new FakeDbSet<Player>("PlayerId");
            Points = new FakeDbSet<Point>("PointId");
            Races = new FakeDbSet<Race>("RaceId");
            Registrations = new FakeDbSet<Registration>("RegistrationId");
            Rounds = new FakeDbSet<Round>("RoundId");
            Runs = new FakeDbSet<Run>("RunId");
            Scores = new FakeDbSet<Score>("ScoreId");
            Seasons = new FakeDbSet<Season>("SeasonId");
            Sysdiagrams = new FakeDbSet<Sysdiagram>("DiagramId");
            Teams = new FakeDbSet<Team>("TeamId");
            Timings = new FakeDbSet<Timing>("TimingId");
            TimingTypes = new FakeDbSet<TimingType>("TimingTypeId");

            InitializePartial();
        }
        
        public int SaveChangesCount { get; private set; } 
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        partial void InitializePartial();

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
    }
}
// </auto-generated>