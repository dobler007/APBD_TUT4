namespace LegacyApp.tests;

public class UserServiceTests
{
    [Fact]
    public void AddUsers_ReturnsFalseWhenFirstNameIsEmpty()
    {
        // Arrange
        var userService = new UserService();

        // Act
        var result = userService.AddUser(
            null, 
            "Smith",
            "Smith.Cool@gmail.com",
            DateTime.Parse("2000-01-01"),
            1);
        
        // Assert
        Assert.False(result);

    }
}