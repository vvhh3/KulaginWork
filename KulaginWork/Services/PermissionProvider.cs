using KulaginWork.Models;

namespace KulaginWork.Services;

public class PermissionProvider
{

    public bool IsCanViewPageSettings(User user)
    {
        if (user.Roll == Rolles.Admin)
        {
            return true;
        }

        return false;
    }
}