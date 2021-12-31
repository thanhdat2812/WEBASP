namespace ASP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingStaff")]
    public partial class TrainingStaff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TrainingStaffid { get; set; }

        [Required]
        [StringLength(50)]
        public string Trainingname { get; set; }

        [Required]
        [StringLength(50)]
        public string phonenumber { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string local_address { get; set; }

        public int Accountid { get; set; }
    }
}
