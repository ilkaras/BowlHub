using AutoMapper;
using BowlHub.BLL.Models;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DAL.Repositories.Interfaces;

namespace BowlHub.BLL.Services.Classes;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    
    public AuthService(IMapper mapper, IUserRepository repository)
    {
        _mapper = mapper;
        _userRepository = repository;
    }
    
    public async Task<string?> Authorize(string email, string password)
    {
        var getUser = _mapper.Map<UserModel>(await _userRepository.GetUserByEmail(email));
        if (getUser == null)
        {
            return string.Empty;
        }

        if (await _userRepository.CheckUser(email, password))
        {
            // TODO generate JWT here;
        }
        
        return string.Empty;
    }
}