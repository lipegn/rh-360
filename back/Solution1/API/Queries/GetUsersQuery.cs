using API.Database;
using API.Model;

namespace API.Queries
{
    public class GetUsersQuery
    {
        public IEnumerable<UserModel> Execute()
        {
            return FakeDatabase.Users;
        }
    }
}
