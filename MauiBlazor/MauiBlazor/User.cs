namespace MauiApp1;

public class User
{
	
	public User() { }
	public User (string name, string email, string cpf)
	{
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Cpf = cpf;
    }

	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Email { get; set; }
	public string Cpf { get; set; }

	public List<User> GetExampleListUsers()
	{
		var users = new List<User>
		{
			new User("Nome Completo 1", "email1", "95191261517"),
            new User("Nome Completo 2", "email2", "98713219842"),
            new User("Nome Completo 3", "email3", "13651122140"),
            new User("Nome Completo 4", "email4", "77845516254"),
            new User("Nome Completo 5", "email5", "00879514269")
        };
		return users;
	}
}