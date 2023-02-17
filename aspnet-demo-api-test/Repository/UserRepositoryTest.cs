using aspnet_demo_api.Entity;
using aspnet_demo_api.Repository;

namespace aspnet_demo_api_test.Repository
{
    public class UserRepositoryTest
    {
        UserRepository userRepository = new UserRepository();

        [Fact]
        public void TestIfUserOneExists()
        {
            User? user = this.userRepository.GetById(1);

            Assert.NotNull(user);

            User expectedUser = new User(1, "Usuário 1", "usuario-1@gmail.com");

            Assert.Equal(expectedUser.id, user.id);
            Assert.Equal(expectedUser.username, user.username);
            Assert.Equal(expectedUser.email, user.email);

        }

        [Fact]
        public void TestIfUserElevenNotExists()
        {
            User? user = this.userRepository.GetById(11);

            Assert.Null(user);

        }

        [Fact]
        public void TestGetAllUsers()
        {
            List<User> users = this.userRepository.GetAll();

            Assert.Equal(10, users.Count);

        }
    }
}
