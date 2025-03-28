using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp.Data.Models;
using ChatApp.Data.Repositories.GroupRepository;

namespace ChatApp.Services.Services.Group
{
    public class GroupService:IGroupService
    {
        private readonly IGroupRepository _GroupRepository;

        public GroupService(IGroupRepository GroupRepository)
        {
            _GroupRepository = GroupRepository;
        }

        public async Task<Data.Entities.Group> AddAsync(Data.Entities.Group entity)
        {
            return await _GroupRepository.AddAsync(entity);
        }

        public async Task<int> CountAsync()
        {
            return await _GroupRepository.CountAsync();
        }

        public async Task<Data.Entities.Group> DeleteAsync(Data.Entities.Group entity)
        {
            return await _GroupRepository.DeleteAsync(entity);
        }

        public async Task<Data.Entities.Group> GetByIdAsync(int id)
        {
            return await _GroupRepository.GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<Data.Entities.Group>> ListAllAsync(PaginationModel paginationModel)
        {
            return await _GroupRepository.ListAllAsync(paginationModel);
        }

        public async Task<Data.Entities.Group> UpdateAsync(Data.Entities.Group entity)
        {
            return await _GroupRepository.UpdateAsync(entity);
        }
    }
}
