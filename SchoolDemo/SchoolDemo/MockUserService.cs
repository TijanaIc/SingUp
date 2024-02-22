namespace SchoolDemo;

public class MockUserService : IUserService
{
    public bool LoginUser(string email, string password)
    {
        return email == "admin@example.com" && password == "admin123";

    }
}
