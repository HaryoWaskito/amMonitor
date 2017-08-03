namespace FlexerApp.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string LocationType { get; set; }
        public string IPAddress { get; set; }
        public string City { get; set; }
        public float Lat { get; set; }
        public float Long { get; set; }
    }
}
