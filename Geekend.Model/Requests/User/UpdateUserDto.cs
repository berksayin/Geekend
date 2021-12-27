namespace Geekend.Model.Requests.User
{
    public class UpdateUserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public int UserType { get; set; }
        public bool IsActive { get; set; }
    }
}
