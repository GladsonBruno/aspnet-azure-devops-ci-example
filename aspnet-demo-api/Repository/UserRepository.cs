using aspnet_demo_api.Entity;
using aspnet_demo_api.Interface;

namespace aspnet_demo_api.Repository
{
    public class UserRepository : IUserRepository
    {

        private List<User> GenerateUsers()
        {

            List<User> users = new List<User>();

            for(int i = 0; i < 10; i++)
            {
                int userId = i + 1;
                string userName = $"Usuário {userId}";
                string userEmail = $"usuario-{userId}@gmail.com";

                User user = new User(userId, userName, userEmail);

                users.Add(user);

            }

            return users;

        }

        public List<User> GetAll()
        {
            return this.GenerateUsers();
        }


        public User? GetById(int id)
        {

            List<User> users = this.GenerateUsers();

            return users.Find(u => u.id == id);

        }

    }
}
