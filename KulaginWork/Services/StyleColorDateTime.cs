namespace KulaginWork.Services;

public class StyleColorDateTime
{
    public string GetColor(DateTime now)
    {
        if (DateTime.Now.Second %2 != 0)
        {
            return "background-color:red";
        }
        else
        {
            return "background-color:green";
        }
    }
}