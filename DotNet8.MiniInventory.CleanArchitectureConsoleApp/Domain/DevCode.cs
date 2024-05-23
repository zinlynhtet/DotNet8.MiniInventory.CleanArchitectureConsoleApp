namespace DotNet8.MiniInventory.CleanArchitectureConsoleApp;

public static class DevCode
{
    public static int ToInt(this object item)
    {
        return Convert.ToInt16(item);
    }
    
    public static decimal ToDecimal(this object item)
    {
        return Convert.ToDecimal(item);
    }
}