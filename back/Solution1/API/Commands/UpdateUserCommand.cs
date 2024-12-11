using API.Database;
using API.Model;

namespace API.Commands
{
    public class UpdateUserCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public UserModel Execute()
        {
            var user = FakeDatabase.Users.FirstOrDefault(u => u.Id == this.Id);
            if (user == null) throw new Exception("User not found");

            user.Name = this.Name;
            user.Email = this.Email;
            return user;
        }
    }
}
