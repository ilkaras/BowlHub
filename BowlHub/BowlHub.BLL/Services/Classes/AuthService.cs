using System.Data.Entity.Core;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AutoMapper;
using BowlHub.BLL.Extentions;
using BowlHub.BLL.Models;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DAL.Repositories.Interfaces;
using Microsoft.IdentityModel.Tokens;

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
    
    public string GenerateToken(UserModel user)
    {
        var token = new JwtSecurityToken(
            issuer: AuthOptions.Issuer,
            audience: AuthOptions.Audience,
            claims: new List<Claim>
            {
                new Claim("adminId", user.Id.ToString()),
                new Claim("admin", user.Email),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
            },
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(120)),
            signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256)
        );
            
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
    
    public async Task<string?> Authorize(string email, string password)
    {
        var getUser = _mapper.Map<UserModel>(await _userRepository.GetUserByEmail(email));
        if (getUser == null)
        {
            throw new ObjectNotFoundException("Email address not found.");
        }

        if (await _userRepository.CheckUser(email, password))
        {
            return GenerateToken(getUser);
        }

        throw new ArgumentException("Password is wrong.");
    }
}