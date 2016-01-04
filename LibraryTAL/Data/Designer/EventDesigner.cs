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
    // Events
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Event
    {
        public Guid EventId { get; set; } // EventID (Primary key)
        public Guid? RaceId { get; set; } // RaceID
        public Guid? CategoryId { get; set; } // CategoryID
        public Guid? ChampionshipId { get; set; } // ChampionshipID

        // Reverse navigation
        public virtual ICollection<Player> Players { get; set; } // Players.FK__Players__EventID__1881A0DE

        // Foreign keys
        public virtual Category Category { get; set; } // FK__Events__Category__2116E6DF
        public virtual Championship Championship { get; set; } // FK__Events__Champion__220B0B18
        public virtual Race Race { get; set; } // FK__Events__RaceID__2022C2A6
        
        public Event()
        {
            Players = new List<Player>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>