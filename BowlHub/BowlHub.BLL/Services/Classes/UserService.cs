using System.Data.Entity.Core;
using AutoMapper;
using BowlHub.BLL.Models;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DAL.Entities;
using BowlHub.DAL.Repositories.Interfaces;

namespace BowlHub.BLL.Services.Classes;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    
    public UserService(IMapper mapper, IUserRepository repository)
    {
        _mapper = mapper;
        _userRepository = repository;
    }

    public async Task<UserModel?> GetUserByEmail(string email)
    {
        return _mapper.Map<UserModel>(await _userRepository.GetUserByEmail(email));
    }
    
    public async Task<UserModel> AddNewUser(UserModel user)
    {
        var result = await GetUserByEmail(user.Email);
        if (result == null)
        {
            return _mapper.Map<UserModel>(await _userRepository.AddAsync(_mapper.Map<UserEntity>(user)));
        }

        throw new InvalidOperationException("This email is already occupied by another user.");
    }
}