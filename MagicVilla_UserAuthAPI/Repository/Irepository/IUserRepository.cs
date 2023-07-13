using MagicVilla_UserAuthAPI.Models;
using MagicVilla_UserAuthAPI.Models.DTO;

namespace MagicVilla_UserAuthAPI.Repository.Irepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register (RegisterationRequestDTO registerationRequestDTO);
    }
}
