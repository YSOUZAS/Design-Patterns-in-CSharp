using System;
namespace Design_Patterns_in_CSharp.Builder
{

    public class UserBuilder
    {
        private string name;
        private int age;
        private string phone;
        private string address;

        public UserBuilder(string name) => this.name = name;

        public User Build() => new User(this);

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }

    public class User
    {

        private readonly string name;
        private readonly int age;
        private readonly string phone;
        private readonly string address;

        public string Name { get => name; }
        public int Age { get => age; }
        public string Phone { get => phone; }
        public string Address { get => address; }



        public User(UserBuilder builder)
        {
            this.name = builder.Name;
            this.age = builder.Age;
            this.phone = builder.Phone;
            this.address = builder.Address;
        }

    }





}
