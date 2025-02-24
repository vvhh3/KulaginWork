using KulaginWork.Models;
using Microsoft.AspNetCore.Components;

namespace KulaginWork.Services;

public class AuthProvider
{
    private User Curentuser;
    
    public void Auth(Credentials credentials)
    {
        Curentuser = new User()
        {
            FirstName = "gh",
            Roll = Rolles.User
        };
        Curentuser = new User()
        {
            FirstName = "Валера",
            Roll = Rolles.Admin,
        };
    }


    public User GetCurrentUser()
    {
        return Curentuser;
    }
}