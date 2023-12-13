namespace AuthCore.Models;

public record User(Guid Id, string Name, string Email, string Password, string[] Roles);