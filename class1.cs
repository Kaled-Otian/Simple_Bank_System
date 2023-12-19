
namespace Gradutaion_Project
{
    internal class withdraw : Add
    {
        public override void Bank(List<bank>Bank)
        {
            Console.WriteLine($"====================== WITHDRAWAL PROCESS =======================");
            Console.Write("Enter ID: ");
            string ID = Console.ReadLine();
            bank Foundedid = Bank.FirstOrDefault(x => x.Id == ID);
            if (Foundedid != null)
            {
                Console.Write("Enter Passward: ");
                string Passward = Console.ReadLine();
                bank Foundedpass = Bank.FirstOrDefault(x => x.passward == Passward);

                if (Foundedpass != null)
                {
                    Console.Write("Enter the withdrawal amount: ");
                    int withdrawamount = int.Parse(Console.ReadLine());
                    int newaccount = Foundedpass.account - withdrawamount;
                    Foundedpass.account = newaccount;
                    Console.WriteLine($"your balance has become: {newaccount}");
                }
                else
                {
                    Console.WriteLine("Wrong passward try again! ");
                }
            }
            else
            {
                Console.WriteLine("No Id like this try again! ");
            }
        }
    }
}