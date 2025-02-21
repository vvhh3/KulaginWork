namespace KulaginWork.Services;

public class StyleColorDateTime
{
    public string GetColor(DateTime now)
    {
        if (DateTime.Now.Second %2 != 0)
        {
        return "background-color:gray";
        }
        else
        {
            return "background-color:yellow";
        }
    }
}