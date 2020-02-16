namespace DigitalDispatcher
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History")]
    public partial class History
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? Msg_Id { get; set; }

        public int? User_Id { get; set; }

        public int? Status_Id { get; set; }

        public DateTime? Status_Time { get; set; }

        public virtual MSG MSG { get; set; }

        public virtual Status Status { get; set; }

        public virtual User User { get; set; }
    }
}
