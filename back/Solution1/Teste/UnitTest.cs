using API.Commands;
using API.Database;
using API.Model;

namespace Teste
{
    public class UnitTest
    {
        public UnitTest()
        {
            FakeDatabase.Users.Clear();
        }
        [Fact]
        public void CreateUserCommand_Should_Add_User_To_Database()
        {
            var command = new CreateUserCommand
            {
                Name = "Felipe Goncalves",
                Email = "felipe@example.com"
            };
            var createdUser = command.Execute();
            Assert.Single(FakeDatabase.Users);
            var userInDb = FakeDatabase.Users[0];
            Assert.Equal(createdUser.Id, userInDb.Id);
            Assert.Equal("Felipe Goncalves", userInDb.Name);
            Assert.Equal("felipe@example.com", userInDb.Email);
        }

        [Fact]
        public void UpdateUserCommand_Should_Update_User_In_Database()
        {
            var existingUser = new UserModel { Name = "Felipe Goncalves", Email = "felipe@example.com" };
            FakeDatabase.Users.Add(existingUser);
            var command = new UpdateUserCommand
            {
                Id = existingUser.Id,
                Name = "John Smith",
                Email = "johnsmith@example.com"
            };
            var updatedUser = command.Execute();
            Assert.Single(FakeDatabase.Users);
            Assert.Equal(existingUser.Id, updatedUser.Id);
            Assert.Equal("John Smith", updatedUser.Name);
            Assert.Equal("johnsmith@example.com", updatedUser.Email);
        }

        [Fact]
        public void UpdateUserCommand_Should_Throw_Exception_If_User_Not_Found()
        {
            var command = new UpdateUserCommand
            {
                Id = Guid.NewGuid(),
                Name = "John Smith",
                Email = "johnsmith@example.com"
            };
            var exception = Assert.Throws<Exception>(() => command.Execute());
            Assert.Equal("User not found", exception.Message);
        }

        [Fact]
        public void DeleteUserCommand_Should_Remove_User_From_Database()
        {
            var existingUser = new UserModel { Name = "Felipe Goncalves", Email = "felipe@example.com" };
            FakeDatabase.Users.Add(existingUser);
            var command = new DeleteUserCommand
            {
                Id = existingUser.Id
            };
            command.Execute();
            Assert.Empty(FakeDatabase.Users);
        }

        [Fact]
        public void DeleteUserCommand_Should_Throw_Exception_If_User_Not_Found()
        {
            var command = new DeleteUserCommand
            {
                Id = Guid.NewGuid()
            };
            var exception = Assert.Throws<Exception>(() => command.Execute());
            Assert.Equal("User not found", exception.Message);
        }
    }
}