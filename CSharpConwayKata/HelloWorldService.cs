namespace CSharpConwayKata;

public class HelloWorldService
{
    public string SayHello(bool toTheWorld)
    {
        var audience = toTheWorld ? "world" : "Conway";
        return $"Hello, {audience}!";
    }
}
