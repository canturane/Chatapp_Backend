using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp.Data.Models;
using ChatApp.Data.Repositories.MessageRepository;

namespace ChatApp.Services.Services.Message
{
    public class MessageService:IMessageService
    {
        private readonly IMessageRepository _MessageRepository;

        public MessageService(IMessageRepository MessageRepository)
        {
            _MessageRepository = MessageRepository;
        }

        public async Task<Data.Entities.Message> AddAsync(Data.Entities.Message entity)
        {
            return await _MessageRepository.AddAsync(entity);
        }

        public async Task<int> CountAsync()
        {
            return await _MessageRepository.CountAsync();
        }

        public async Task<Data.Entities.Message> DeleteAsync(Data.Entities.Message entity)
        {
            return await _MessageRepository.DeleteAsync(entity);
        }

        public async Task<Data.Entities.Message> GetByIdAsync(int id)
        {
            return await _MessageRepository.GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<Data.Entities.Message>> ListAllAsync(PaginationModel paginationModel)
        {
            return await _MessageRepository.ListAllAsync(paginationModel);
        }

        public async Task<Data.Entities.Message> UpdateAsync(Data.Entities.Message entity)
        {
            return await _MessageRepository.UpdateAsync(entity);
        }
    }
}
