using System.Linq;
using T3ESOT.Models;

namespace T3ESOT.Repositorio
{
    public interface IAuthRepo
    {
        User GetUser(string username, string password);
        User GetUserUsername(string username);
        void SaveUser(User user);
    }
    public class AuthRepo: IAuthRepo
    {
        private readonly ContextE context;

        public AuthRepo(ContextE context)
        {
            this.context = context;
        }

        public User GetUser(string username, string password)
        {
            return context.Users
                .Where(o => o.Username == username && o.Password == password)
                .FirstOrDefault();
        }

        public User GetUserUsername(string username)
        {
            return context.Users
                .Where(o => o.Username == username)
                .FirstOrDefault();
        }

        public void SaveUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
