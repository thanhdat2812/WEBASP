namespace ASP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topic")]
    public partial class Topic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Topicid { get; set; }

        [Required]
        [StringLength(50)]
        public string Topicname { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}
