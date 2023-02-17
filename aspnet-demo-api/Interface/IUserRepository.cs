using aspnet_demo_api.Entity;

namespace aspnet_demo_api.Interface
{
    public interface IUserRepository
    {

        List<User> GetAll();

        User? GetById(int id);

    }
}
