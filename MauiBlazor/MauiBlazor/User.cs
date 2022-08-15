namespace MauiBlazor;

public class User
{
	
	public User() { }
	public User (int id, string name, string email, string cpf)
	{
        Id = id;
		GUID = Guid.NewGuid();
        Name = name;
        Email = email;
        Cpf = cpf;
    }

	public Guid GUID { get; set; }
	public int Id { get; set; }
	public string Name { get; set; }
	public string Email { get; set; }
	public string Cpf { get; set; }

	public List<User> GetExampleListUsers()
	{
		var users = new List<User>
		{
			new User(1,"Nome Completo 1", "email1", "95191261517"),
            new User(2,"Nome Completo 2", "email2", "98713219842"),
            new User(3,"Nome Completo 3", "email3", "13651122140"),
            new User(4,"Nome Completo 4", "email4", "77845516254"),
            new User(5,"Nome Completo 5", "email5", "00879514269")
        };
		return users;
	}
}