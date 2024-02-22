using SchoolDemo.DataBase;

namespace SchoolDemo;
public class UserService : IUserService
{
    private readonly LoginDbContext _loginDbContext;

    public UserService(LoginDbContext loginDbContext)
    {
        _loginDbContext = loginDbContext;
    }
    public bool LoginUser(string email, string password)
    {
        LoginRequest user = _loginDbContext.Login.FirstOrDefault(i => i.Email == email && i.Password == password);
        return user != null;
    }
}
