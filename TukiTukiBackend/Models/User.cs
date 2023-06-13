namespace TukiTukiBackend.Models;

public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public string lastname { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public string phone { get; set; }
    public User(string name, string lastname, string email, string password, string phone)
    {
        this.name = name;
        this.lastname = lastname;
        this.email = email;
        this.password = password;
        this.phone = phone;
    }
}