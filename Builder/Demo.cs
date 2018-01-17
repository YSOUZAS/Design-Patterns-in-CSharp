using System;
namespace Design_Patterns_in_CSharp.Builder
{
    public class Demo
    {
        public Demo()
        {
        }

        public void Show()
        {
            var builder = new UserBuilder("Jancsi");
            builder.Age = 12;
            builder.Phone = "0123456789";
            builder.Address = "asdf";
            var user = builder.Build();

            Console.WriteLine(user.Name + " " + user.Age + " " + user.Phone + " " + user.Address);

        }
    }
}
