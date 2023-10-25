using BlogApp.Data.Model.ReturnModel;
using BlogApp.Data.Model;
using BlogApp.Data.Entities;

namespace BlogApp.Service.Interfaces
{
    public interface ILoginService
    {
        Task<UserTokenResponseModel> Authenticate(UserLoginModel model);

        Task<ResponseModel> LogOut();

        Task<UserTokenResponseModel> TokenRefresh(string refreshToken);

        Task<UserTokenResponseModel> AdminLogin(UserLoginModel model);
        Task<ResponseModel> CreateRoleAsync(User user);


    }
}
