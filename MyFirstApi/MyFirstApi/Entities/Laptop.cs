namespace MyFirstApi.Entities;

public class Laptop : Device
{
    public override string GetBrand()
    {
        return "Apple";
    }

    public override string Hello()
    {
        return base.Hello();
    }
    
    public string GetModel()
    {
        var isConnected = IsConnected();
        if(isConnected)
            return "MacBook";
        
        return "Unknow";
    }
}