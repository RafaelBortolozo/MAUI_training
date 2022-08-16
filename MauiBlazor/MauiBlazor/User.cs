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

	public static List<User> GetExampleListUsers()
	{
		var users = new List<User>
		{
			new User(1,"Nome Completo 1", "email_1@gmail.com", "951.912.615-17"),
            new User(2,"Nome Completo 2", "email_2@gmail.com", "987.132.198-42"),
            new User(3,"Nome Completo 3", "email_3@gmail.com", "136.511.221-40"),
            new User(4,"Nome Completo 4", "email_4@gmail.com", "778.455.162-54"),
            new User(5,"Nome Completo 5", "email_5@gmail.com", "008.795.142-69"),
            new User(6,"Nome Completo 6", "email_6@gmail.com", "951.912.615-17"),
            new User(7,"Nome Completo 7", "email_7@gmail.com", "987.132.198-42"),
            new User(8,"Nome Completo 8", "email_8@gmail.com", "136.511.221-40"),
            new User(9,"Nome Completo 9", "email_9@gmail.com", "778.455.162-54"),
            new User(10,"Nome Completo 10", "email_10@gmail.com", "008.795.142-69"),
            new User(11,"Nome Completo 11", "email_11@gmail.com", "951.912.615-17"),
            new User(12,"Nome Completo 12", "email_12@gmail.com", "987.132.198-42"),
            new User(13,"Nome Completo 13", "email_13@gmail.com", "136.511.221-40"),
            new User(14,"Nome Completo 14", "email_14@gmail.com", "778.455.162-54"),
            new User(15,"Nome Completo 15", "email_15@gmail.com", "008.795.142-69")
        };
		return users;
	}

    public User getUserByGUID(Guid guid)
    {

    }
}