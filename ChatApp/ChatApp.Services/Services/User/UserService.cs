using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp.Data.Models;
using ChatApp.Data.Repositories.UserRepository;

namespace ChatApp.Services.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Data.Entities.User> AddAsync(Data.Entities.User entity)
        {
            return await _userRepository.AddAsync(entity);
        }

        public async Task<int> CountAsync()
        {
           return await _userRepository.CountAsync();
        }

        public async Task<Data.Entities.User> DeleteAsync(Data.Entities.User entity)
        {
            return await _userRepository.DeleteAsync(entity);
        }

        public async Task<Data.Entities.User> GetByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<Data.Entities.User>> ListAllAsync(PaginationModel paginationModel)
        {
            return await _userRepository.ListAllAsync(paginationModel);
        }

        public async Task<Data.Entities.User> UpdateAsync(Data.Entities.User entity)
        {
            return await _userRepository.UpdateAsync(entity);   
        }

        public async Task<Data.Entities.User> GetByUsernameAndPasswordAsync(string username, string password)
        {
            return await _userRepository.GetByUsernameAndPasswordAsync(username, password);
        }
    }
}
