namespace Furniking.BLL.DTOs.EmailDTOs
{
    public class SendEmailDTO
    {
        public string TargetEmail { get; set; }
        public string Subject { get; set; }
        public string Html { get; set; }
    }
}
