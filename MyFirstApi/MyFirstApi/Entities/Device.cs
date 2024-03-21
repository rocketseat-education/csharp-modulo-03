namespace MyFirstApi.Entities;

public class Device
{
    protected bool IsConnected() => false;

    public void Test()
    {
        var x = IsConnected();
    }
}