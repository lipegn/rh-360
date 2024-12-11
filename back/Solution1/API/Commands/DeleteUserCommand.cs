using API.Database;

namespace API.Commands
{
    public class DeleteUserCommand
    {
        public Guid Id { get; set; }

        public void Execute()
        {
            var user = FakeDatabase.Users.FirstOrDefault(u => u.Id == this.Id);
            if (user == null) throw new Exception("User not found");

            FakeDatabase.Users.Remove(user);
        }
    }
}
