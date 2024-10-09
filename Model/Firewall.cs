using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarterCode.Models
{
    [Table("tbl_m_firewall")]
    public class Firewall
    {
        [Key]
        public long id { get; set; }
        public string? fw_name { get; set; }
        public string? fw_location { get; set; }
        public string? fw_site { get; set; }
    }
}
