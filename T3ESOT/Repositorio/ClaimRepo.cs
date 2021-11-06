
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;
using T3ESOT.Models;

namespace T3ESOT.Repositorio
{
    public interface IClaimRepo
    {
        User GetLoggedUser();
        void SetHttpContext(HttpContext httpContext);
        void Logout();
        void Login(ClaimsPrincipal principal);
    }
    public class ClaimRepo : IClaimRepo
    {
        private readonly ContextE context;
        private HttpContext httpContext;

        public ClaimRepo(ContextE context)
        {
            this.context = context;
        }

        public User GetLoggedUser()
        {
            var claim = httpContext.User.Claims.FirstOrDefault();
            return context.Users.Where(o => o.Username == claim.Value).FirstOrDefault();
        }

        public void Login(ClaimsPrincipal principal)
        {
            httpContext.SignInAsync(principal);
        }

        public void Logout()
        {
            httpContext.SignOutAsync();
        }

        public void SetHttpContext(HttpContext httpContext)
        {
            this.httpContext = httpContext;
        }
    }
}
