namespace MyFirstApi.Entities;

public class Laptop : Device
{
    public string GetModel()
    {
        var isConnected = IsConnected();
        if(isConnected)
            return "MacBook";
        
        return "Unknow";
    }
}