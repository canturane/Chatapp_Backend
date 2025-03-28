using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ChatApp.Data.Entities;

namespace ChatApp.Data.Repositories.GroupRepository
{
    public interface IGroupRepository: IGenericRepository<Entities.Group>
    {
    }
}
