namespace CindaSoftAcedemyCore6.Models
{
    public class SendMessageViewModel
    {
        public int ContactID { get; set; }
        public string? NameSurname { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? MessageBody { get; set; }
        public DateTime Date { get; set; }
    }
}
