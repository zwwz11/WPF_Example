
using WpfApp1.Model;
using WpfApp1.Service;

namespace TestProject
{
    public class UserServiceTest
    {
        UserService userService;
        [SetUp]
        public void SetUp()
        {
            userService = new();
        }

        [Test]
        public void 유저등록테스트()
        {
            userService.CreateUser(new()
            {
                ID = 0,
                Name = "Test",
                Age = 0,
            });

            var users = userService.GetAllUsers();
            var findUser = users.Find(x => x.ID == 0);
            Assert.IsNotNull(findUser);
        }

        [Test]
        public void 유저등록실패테스트()
        {
            // when
            userService.CreateUser(new()
            {
                ID = 0,
                Name = "Test",
                Age = 0,
            });

            // then
            var users = userService.GetAllUsers();
            var findUser = users.Find(x => x.ID == 1);
            Assert.IsNotNull(findUser);
        }

        [Test]
        public void 유저업데이트테스트()
        {
            User user = new()
            {
                ID = 0,
                Name = "Test",
                Age = 0,
            };

            userService.CreateUser(user);

            user.Age = 10;
            userService.UpdateUser(user);

            var findUser = userService.FindUserById(user);
            Assert.IsTrue(findUser?.Age == 10);
        }

        [Test]
        public void 유저업데이트실패테스트()
        {
            User user = new()
            {
                ID = 0,
                Name = "Test",
                Age = 0,
            };

            userService.CreateUser(user);

            user.Age = 10;
            userService.UpdateUser(user);

            var findUser = userService.FindUserById(new() { ID = 11 });
            Assert.IsTrue(findUser == null);
        }
    }
}
