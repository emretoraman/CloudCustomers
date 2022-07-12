using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
        {
            new User
            {
                Id = 1,
                Name = "Test User 1",
                Address = new Address
                {
                    Street = "123 Main St",
                    City = "Somewhere",
                    ZipCode = "53704"
                },
                Email = "test1@example.com"
            },
            new User
            {
                Id = 2,
                Name = "Test User 2",
                Address = new Address
                {
                    Street = "900 Main St",
                    City = "Somewhere",
                    ZipCode = "34543"
                },
                Email = "test2@example.com"
            },
            new User
            {
                Id = 3,
                Name = "Test User 3",
                Address = new Address
                {
                    Street = "108 Maple St",
                    City = "Somewhere",
                    ZipCode = "87654"
                },
                Email = "test3@example.com"
            }
        };
    }
}
