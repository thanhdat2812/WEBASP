namespace ASP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coursedetail")]
    public partial class Coursedetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Coursedetail_id { get; set; }

        public int Courseid { get; set; }

        [Required]
        [StringLength(20)]
        public string Trainee { get; set; }
    }
}
