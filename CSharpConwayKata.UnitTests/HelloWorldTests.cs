using FluentAssertions;

namespace CSharpConwayKata.UnitTests;

public class HelloWorldTests
{
    [Fact]
    public void When_Speaking_To_World_Then_Should_Return_Hello_World()
    {
        // Arrange
        var service = new HelloWorldService();

        // Act
        var greeting = service.SayHello(true);

        // Assert
        greeting.Should().Be("Hello, world!");
    }

    [Fact]
    public void When_Not_Speaking_To_World_Then_Should_Return_Hello_Conway()
    {
        // Arrange
        var service = new HelloWorldService();

        // Act
        var greeting = service.SayHello(false);

        // Assert
        greeting.Should().Be("Hello, Conway!");
    }
}