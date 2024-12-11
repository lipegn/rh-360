using API.Database;
using API.Model;

namespace API.Commands
{
    public class CreateUserCommand
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public UserModel Execute()
        {
            var user = new UserModel
            {
                Name = this.Name,
                Email = this.Email
            };

            FakeDatabase.Users.Add(user);
            return user;
        }
    }
}
