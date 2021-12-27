namespace Geekend.Model.Requests.User
{
    public class InsertUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        //Servis katmanında password check işlemi için kullanıldı.
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
