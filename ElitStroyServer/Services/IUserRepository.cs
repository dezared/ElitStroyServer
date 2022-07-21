using ElitStroyServer.Model;

namespace ElitStroyServer.Services
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
        bool isEmailUniq(string email);
        bool IsUsernameUniq(string username);
    }
}
