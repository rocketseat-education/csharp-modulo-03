namespace MyFirstApi.Entities;

public abstract class Device
{
    protected bool IsConnected() => false;

    public abstract string GetBrand();

    public virtual string Hello()
    {
        return "Hello world";
    }
}