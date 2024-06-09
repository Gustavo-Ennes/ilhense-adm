namespace Mercado.Domain.Entities;

public class User
{
  public Guid? Id {get;set;}
  public required string Name{get;set;}
  public required string LastName {get;set;}
  public required string Email {get;set;}
  public required string Password {get;set;}
  public DateTime CreationDate {get;} = DateTime.Now;
}