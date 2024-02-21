using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDemo;

[Table("Login", Schema = "dbo")]

public class LoginRequest
{
    [Key]
    public string Email { get; set; }
    public string Password { get; set; }
}
