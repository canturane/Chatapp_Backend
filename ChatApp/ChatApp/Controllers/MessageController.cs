using AutoMapper;
using ChatApp.Data.Entities;
using ChatApp.Data.Models;
using ChatApp.Models;
using ChatApp.Services.Models.Message;
using ChatApp.Services.Services.Message;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]  //[Authorize(Roles="Admin,User")]  şeklinde rol bazlı da yapılabilir
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;

        public MessageController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ReturnModel> Get([FromQuery] PaginationModel paginationModel)
        {
            var messages = await _messageService.ListAllAsync(paginationModel);
            return new ReturnModel
            {
                Success = true,
                Message = "success",
                Data = _mapper.Map<List<MessageModel>>(messages),
                StatusCode = 200,
                TotalCount = await _messageService.CountAsync()

            };

        }

        [HttpGet("{id}")]
        public async Task<ReturnModel> Get(int id)
        {
            var message = await _messageService.GetByIdAsync(id);
            return new ReturnModel
            {
                Success = true,
                Message = "Success",
                Data = _mapper.Map<MessageModel>(message),
                StatusCode = 200,

            };
        }

        [HttpPost]
        public async Task<ReturnModel> Post([FromBody] MessageCreateModel messageCreateModel)
        {
            var message = _mapper.Map<Message>(messageCreateModel);
            var MessageResult = await _messageService.AddAsync(message);
            return new ReturnModel
            {

                Success = true,
                Message = "Success",
                Data = _mapper.Map<MessageCreateModel>(MessageResult),
                StatusCode = 200
            };
        }


        [HttpPut]
        public async Task<ReturnModel> Put([FromBody] MessageUpdateModel messageModel) {

            var message = _mapper.Map<Message>(messageModel);
            var messageResult = await _messageService.UpdateAsync(message);
            return new ReturnModel {

                Success = true,
                Message = "Success",
                Data = _mapper.Map<MessageModel>(messageResult),
                StatusCode = 200

            };

        }

        [HttpDelete("{id}")]
        public async Task<ReturnModel> Delete(int id) { 

            var message = await _messageService.GetByIdAsync(id);
            await _messageService.DeleteAsync(message);
                return new ReturnModel { 

                    Success = true,
                    Message = "Success",
                    StatusCode = 200

                };

        }
    }
}