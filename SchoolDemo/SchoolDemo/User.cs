using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDemo;

[Table("Users", Schema = "dbo")]

public class User
{
    [Key]
    public int UserID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
