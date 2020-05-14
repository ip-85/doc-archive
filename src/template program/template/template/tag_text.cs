namespace template
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.tag_text")]
    public partial class tag_text
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tag_text()
        {
            document = new HashSet<document>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Text { get; set; }

        public int Tag_ID { get; set; }

        public virtual tag tag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<document> document { get; set; }
    }
}
