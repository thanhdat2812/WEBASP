namespace ASP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourseTrainer")]
    public partial class CourseTrainer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseTrainer_id { get; set; }

        public int Trainerid { get; set; }

        public int Courseid { get; set; }
    }
}
