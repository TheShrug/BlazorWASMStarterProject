using BlazorWASMStarterProject.Shared.Auth;
using System.Threading.Tasks;

namespace BlazorWASMStarterProject.Client.Services
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
        Task<ResetPasswordRequestResult> ResetPasswordRequest(ResetPasswordRequestModel resetPasswordRequestModel);
        Task<ResetPasswordResult> ResetPassword(ResetPasswordModel resetPasswordModel);
    }
}
