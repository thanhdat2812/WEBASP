namespace ASP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trainee")]
    public partial class Trainee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Traineeid { get; set; }

        [Required]
        [StringLength(50)]
        public string Traineename { get; set; }

        public int Phone { get; set; }

        [Required]
        [StringLength(100)]
        public string local_address { get; set; }

        public int Courseid { get; set; }

        [Required]
        [StringLength(70)]
        public string Coursetoeic { get; set; }

        public int Accountid { get; set; }
    }
}
