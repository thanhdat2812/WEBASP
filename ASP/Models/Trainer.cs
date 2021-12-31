namespace ASP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trainer")]
    public partial class Trainer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Trainerid { get; set; }

        [Required]
        [StringLength(50)]
        public string Trainername { get; set; }

        public int Topicid { get; set; }

        [Required]
        [StringLength(10)]
        public string education { get; set; }

        public int phone { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string local_address { get; set; }

        public int Accountid { get; set; }
    }
}
