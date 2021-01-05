using AutoMapper;
using BlazorData.Models;
using BlazorData.Repositories;
using BlazorShare.DTOs;
using System;
using System.Security.Cryptography;

namespace BlazorServices
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<User> _userRepository;

        public UserService(IMapper mapper, IRepository<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public UserDTO Register(UserRegisterDTO user)
        {
            try
            {
                var newUser = _mapper.Map<User>(user);
                newUser.Password = HashPassword(newUser.Password);
                _userRepository.Insert(newUser);
                _userRepository.Commit();

                var userDto = _mapper.Map<UserDTO>(newUser);

                return userDto;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private string HashPassword(string password)
        {
            var iterations = 1000;
            //generate a random salt for hashing
            var salt = new byte[24];
            new RNGCryptoServiceProvider().GetBytes(salt);

            //hash password given salt and iterations (default to 1000)
            //iterations provide difficulty when cracking
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(24);

            //return delimited string with salt | #iterations | hash
            return Convert.ToBase64String(salt) + "|" + iterations + "|" +
                Convert.ToBase64String(hash);
        }
        public bool IsValid(string testPassword, string origDelimHash)
        {
            //extract original values from delimited hash text
            var origHashedParts = origDelimHash.Split('|');
            var origSalt = Convert.FromBase64String(origHashedParts[0]);
            var origIterations = Int32.Parse(origHashedParts[1]);
            var origHash = origHashedParts[2];

            //generate hash from test password and original salt and iterations
            var pbkdf2 = new Rfc2898DeriveBytes(testPassword, origSalt, origIterations);
            byte[] testHash = pbkdf2.GetBytes(24);

            //if hash values match then return success
            if (Convert.ToBase64String(testHash) == origHash)
                return true;

            //no match return false
            return false;

        }

        public UserDTO ValidateUser(UserRegisterDTO user)
        {
            var user2Check = _userRepository.GetSingle(u => u.Name == user.Name);
            if (IsValid(user.Password, user2Check.Password))
            {
                return _mapper.Map<UserDTO>(user2Check);
            }
            else
            {
                return null;
            }
        }
    }
}
