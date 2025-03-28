namespace ChatApp.Services.Services.User
{
    public interface IUserService:IGenericService<Data.Entities.User>
    {
        public Task<Data.Entities.User> GetByUsernameAndPasswordAsync(string username, string password);
    }
}
