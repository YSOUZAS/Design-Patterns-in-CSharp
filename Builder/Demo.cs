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
            var builder = new UserBuilder("Jancsi")
            {
                Age = 12,
                Phone = "0123456789",
                Address = "asdf"
            };
            var user = builder.Build();

            Console.WriteLine(user.Name + " " + user.Age + " " + user.Phone + " " + user.Address);

        }
    }
}
