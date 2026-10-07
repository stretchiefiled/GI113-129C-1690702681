namespace assiment02
{
    /*
* Student ID : 1690702681
* Name       : วรัทยา ปานทอง
* Section    : 129C
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants
            const string MaterialName = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.0;

            Console.WriteLine("================================");
            Console.WriteLine("        Welcome to The Forge");
            Console.WriteLine("================================");
            Console.WriteLine($"Material : {MaterialName}");
            Console.WriteLine($"Smelt Rate   : {SmeltRate:F4}");
            Console.WriteLine($"Salvage Rate : {SalvageRate:F4}");
            Console.WriteLine($"Max Batch    : {MaxBatch:F2}");
            Console.WriteLine();

            Console.Write("Choose Menu (S = Smelt, B = Breakdown): ");
            string menuInput = Console.ReadLine() ?? "";

            // char.TryParse ป้องกันโปรแกรม crash
            if (!char.TryParse(menuInput, out char menu))
            {
                Console.WriteLine("error: menu");
                return;
            }

            Console.Write("How much would you like: ");
            string amountInput = Console.ReadLine() ?? "";

            // double.TryParse ป้องกันโปรแกรม crash
            if (!double.TryParse(amountInput, out double amount))
            {
                Console.WriteLine("error: amount (parse ไม่ได้)");
                return;
            }

            // ตรวจสอบ amount ด้วย &&
            if (amount > 0 && amount <= MaxBatch)
            {
                // Nested if
                if (menu == 'S' || menu == 's')
                {
                    double result = amount * SmeltRate;

                    Console.WriteLine(
                        $"=> {amount:F2} {MaterialName} Ore - {result:F2} {MaterialName} Ingot"
                    );
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double result = amount / SalvageRate;

                    Console.WriteLine(
                        $"=> {amount:F2} {MaterialName} Ingot - {result:F2} {MaterialName} Ore"
                    );
                }
                else
                {
                    Console.WriteLine("error: menu");
                }
            }
            else
            {
                if (amount <= 0)
                {
                    Console.WriteLine("error: amount (ไม่มากกว่า 0)");
                }
                else
                {
                    Console.WriteLine("error: amount (เกินขอบเขต)");
                }
            }
        }
    }
}
