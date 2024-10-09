namespace StarterCode.Models
{
    public class Login
    {
        public long id { get; set; }
        public long fk_m_firewall { get; set; }
        public string? fw_ip_address { get; set; }
        public string? fw_username { get; set; }
        public string? fw_password { get; set; }
        public string? fw_expert_password { get; set; }
    }
}
