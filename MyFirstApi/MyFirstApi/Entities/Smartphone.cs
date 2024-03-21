namespace MyFirstApi.Entities;

public class Smartphone : Device
{
    public override string GetBrand()
    {
        return "Samsung";
    }
}