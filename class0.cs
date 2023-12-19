
namespace Gradutaion_Project
{
    internal class Add : bank
    {
        public virtual void Bank (List<bank> Bank)
        {
            Console.WriteLine($"============================ ADD CLIENT ================================");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Id: ");
            string id = Console.ReadLine();

            Console.Write("Enter balance: ");
            int balance = int.Parse(Console.ReadLine());

            Console.Write("Enter passward: ");
            string passward = Console.ReadLine();

            bank newclient = new bank { Name = name, Id = id, account = balance, passward = passward};
            Bank.Add(newclient);

            Console.WriteLine($"=================== CLIENT INFORMATION YOU ENTERD ======================");
            Console.WriteLine($"Name: {newclient.Name}");
            Console.WriteLine($"Id: {newclient.Id}");
            Console.WriteLine($"Balance: {newclient.account}");
            Console.WriteLine($"Passward: **");
        }
    }
}