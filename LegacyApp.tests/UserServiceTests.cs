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
    [Fact]
    public void AddUsers_ThrowsExceptionWhenClientDoesntExist()
    {
        // Arrange
        var userService = new UserService();

        // Act
        Action action = (  ) => userService.AddUser(
            "Joe", 
            "Smith",
            "Smith.Cool@gmail.com",
            DateTime.Parse("2000-01-01"),
            100);
        
        // Assert
        Assert.Throws<ArgumentException>(action);
        
    }

    public void GetById_ThrowsExceptionWhenNoID()
    {
        
        // Arrange
        
        Dictionary<int, Client> database = new Dictionary<int, Client>()
        {
            {1, new Client{ClientId = 1, Name = "Kowalski", Address = "Warszawa, Złota 12", Email = "kowalski@wp.pl", Type = "NormalClient"}},
            {2, new Client{ClientId = 2, Name = "Malewski", Address = "Warszawa, Koszykowa 86", Email = "malewski@gmail.pl", Type = "VeryImportantClient"}},
            {3, new Client{ClientId = 3, Name = "Smith", Address = "Warszawa, Kolorowa 22", Email = "smith@gmail.pl", Type = "ImportantClient"}},
            {4, new Client{ClientId = 4, Name = "Doe", Address = "Warszawa, Koszykowa 32", Email = "doe@gmail.pl", Type = "ImportantClient"}},
            {5, new Client{ClientId = 5, Name = "Kwiatkowski", Address = "Warszawa, Złota 52", Email = "kwiatkowski@wp.pl", Type = "NormalClient"}},
            {6, new Client{ClientId = 6, Name = "Andrzejewicz", Address = "Warszawa, Koszykowa 52", Email = "andrzejewicz@wp.pl", Type = "NormalClient"}}
        };

        // Act
        //Action action = () => ClientRepository.GetById(399);
        
        //Assert
        
        //Assert.Throws<ArgumentException>(action);
    }
}