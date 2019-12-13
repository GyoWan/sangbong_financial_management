namespace sangbong_financial_management.SFM.Common.Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SFM_POSITION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SFM_POSITION()
        {
            SFM_USER_INFO = new HashSet<SFM_USER_INFO>();
        }

        [Key]
        [StringLength(3)]
        public string POSITION_NO { get; set; }

        [Required]
        [StringLength(15)]
        public string POSITION_EN_NAME { get; set; }

        [Required]
        [StringLength(15)]
        public string POSITION_NAME { get; set; }

        public DateTime? INSERT_DATE { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public virtual SFM_POSITION SFM_POSITION1 { get; set; }

        public virtual SFM_POSITION SFM_POSITION2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SFM_USER_INFO> SFM_USER_INFO { get; set; }
    }
}
