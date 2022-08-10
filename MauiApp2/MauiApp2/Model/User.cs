using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Model
{
    public class User
    {
        public User(string name, string email, int age)
        {
            Id = new Guid();
            Name = name;
            Email = email;
            Age = age;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
