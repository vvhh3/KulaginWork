namespace KulaginWork.Models;

public class User
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Surname { get; set; }
    public Rolles Roll { get; set; } = Rolles.User;
}