namespace EF_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext(); //creates an instance of AppDbContext

            var users = context.Users.ToList(); //gets all of the info from users and saves it to a list

            foreach (var item in users)
            {
                Console.WriteLine($"Name: {item.Firstname} {item.Lastname}");
            }
        }
    }
}
