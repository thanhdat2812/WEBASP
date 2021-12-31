namespace ASP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cat")]
    public partial class Cat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Catid { get; set; }

        [Required]
        [StringLength(10)]
        public string Catname { get; set; }

        [StringLength(150)]
        public string Description { get; set; }
    }
}
