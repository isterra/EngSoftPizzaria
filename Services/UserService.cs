using Microsoft.EntityFrameworkCore;
using Models.DataBaseModels;
using Services.DataBase;
using Services.Interface;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly PostgreSql _postgreSql;

        public UserService(PostgreSql postgreSql)
        {
            _postgreSql = postgreSql;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await _postgreSql.Users.AddAsync(user);
            await _postgreSql.SaveChangesAsync();
            await _postgreSql.Entry(user).GetDatabaseValuesAsync();
            user.Password = String.Empty;
            return user;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _postgreSql.Users.FirstOrDefaultAsync(u => u.Id.Equals(id));
            if (user != null)
            {
                user.Password = String.Empty;
            }
            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _postgreSql.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));
            return user;
        }

    }
}
