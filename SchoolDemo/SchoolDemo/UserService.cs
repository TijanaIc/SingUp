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
        User user = _loginDbContext.Users.FirstOrDefault(i => i.UserName == email && i.Password == password);
        return user != null;
    }
}
