using System.Threading.Tasks;
using WPFUserInterface.Library.Models;

namespace WPFUserInterface.Library.Api
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}