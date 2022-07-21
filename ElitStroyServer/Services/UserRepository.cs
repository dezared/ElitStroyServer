using ElitStroyServer.Model;

namespace ElitStroyServer.Services
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context) { }

        public bool isEmailUniq(string email)
        {
            var user = this.GetSingle(u => u.Email == email);
            return user == null;
        }

        public bool IsUsernameUniq(string username)
        {
            var user = this.GetSingle(u => u.UserName == username);
            return user == null;
        }
    }
}
