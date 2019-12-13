namespace sangbong_financial_management.SFM.Common.Database.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class SFM_USER_INFO
    {
        [Key]
        [StringLength(15)]
        public string USER_ID { get; set; }

        [Required]
        [StringLength(15)]
        public string USER_PW { get; set; }

        [StringLength(30)]
        public string USER_EMAIL { get; set; }

        [StringLength(15)]
        public string USER_TEL { get; set; }

        public DateTime? INSERT_DATE { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(3)]
        public string POSITION_NO { get; set; }

        public virtual SFM_POSITION SFM_POSITION { get; set; }
    }
}
