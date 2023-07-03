namespace JwtAspNet.Models;

public record User(
    int Id, 
    string Name, 
    string Email, 
    string Image, 
    string Password, 
    string[] Roles);