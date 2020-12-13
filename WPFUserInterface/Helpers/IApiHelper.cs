using System.Threading.Tasks;
using WPFUserInterface.Models;

namespace WPFUserInterface.Helpers
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}