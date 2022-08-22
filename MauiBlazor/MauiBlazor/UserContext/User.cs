using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazor.UserContext;

public class User
{
    public User() 
    {
        Profiles = new List<Profile> { new Profile() };
    }
    public User(int id, string name, string email, string cpf)
    {
        Id = id;
        GUID = Guid.NewGuid();
        Name = name;
        Email = email;
        Cpf = cpf;
        
        if (id == 5)
        {
            Profiles = new List<Profile>
            {
                new Profile($"email{id}_admin@gmail.com", Enums.EAccessLevel.Administrator),
                new Profile($"email{id}_dev@gmail.com", Enums.EAccessLevel.Developer)
            };
        }
        else
        {
            Profiles = new List<Profile>
            {
                new Profile($"email{id}_client@gmail.com", Enums.EAccessLevel.Client),
                new Profile($"email{id}_admin@gmail.com", Enums.EAccessLevel.Administrator),
                new Profile($"email{id}_dev@gmail.com", Enums.EAccessLevel.Developer)
            };
        }
        
        
    }

    public Guid? GUID { get; set; }
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public IList<Profile> Profiles { get; set; }
}