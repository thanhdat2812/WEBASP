namespace ASP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Courseid { get; set; }

        [Required]
        [StringLength(50)]
        public string Coursename { get; set; }

        [Required]
        [StringLength(50)]
        public string Coursetoeic { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int Accountid { get; set; }

        public int? Catid { get; set; }
    }
}
