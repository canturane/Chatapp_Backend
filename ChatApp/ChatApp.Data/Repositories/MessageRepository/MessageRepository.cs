using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp.Data.Entities;
using ChatApp.Data.Models;

namespace ChatApp.Data.Repositories.MessageRepository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IGenericRepository<Message> _genericRepository;

        public MessageRepository(IGenericRepository<Message> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Message> AddAsync(Message entity)
        {
            return await _genericRepository.AddAsync(entity);
        }

        public async Task<int> CountAsync()
        {
            return await _genericRepository.CountAsync();
        }

        public async Task<Message> DeleteAsync(Message entity)
        {
            return await _genericRepository.DeleteAsync(entity);
        }

        public async Task<Message> GetByIdAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<Message>> ListAllAsync(PaginationModel paginationModel)
        {
            return await _genericRepository.ListAllAsync(paginationModel);
        }

        public Task<Message> UpdateAsync(Message entity)
        {
            return _genericRepository.UpdateAsync(entity);
        }

    }
}
