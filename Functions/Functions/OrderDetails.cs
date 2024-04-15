namespace Functions
{
    internal class OrderDetails
    {
        public static string GetOrderDetails(byte size, int[] OrdId, string[] OrdName, double[] OrdPrice, string[] ExpDate)
        {
            string str = "";
            for (int i = 0; i < OrdId.Length; i++)
            {
                str = str + "Order Id  :  " + OrdId[i] + " ";
                str = str + "Order Name  :  " + OrdName[i] + " ";
                str = str + "Order Id  :  " + OrdId[i] + " ";
                str = str + "Order Id  :  " + OrdId[i] + " \n\n";
            }
            return str;
        }

        public static void SetOrderDetails(byte size, int[] OrdId, string[] OrdName, double[] OrdPrice, string[] ExpDate)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter order Details  for Item - {i + 1} : \n");
                Console.Write("Enter Order Id : ");
                OrdId[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Order Name : ");
                OrdName[i] = Console.ReadLine();
                Console.Write("Enter Order Price : ");
                OrdPrice[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Expected Date of the Order : ");
                ExpDate[i] = Console.ReadLine();
            }
        }
        public static void Main()
        {
            Console.Write("Enter number of orders : ");
            byte size = Convert.ToByte(Console.ReadLine());

            int[] OrdId = new int[size];
            string[] OrdName = new string[size];
            double[] OrdPrice = new double[size];
            string[] ExpDate = new string[size];

            SetOrderDetails(size, OrdId, OrdName, OrdPrice, ExpDate);
            Console.Write("\nOrder Details : \n");
            string str = GetOrderDetails(size, OrdId, OrdName, OrdPrice, ExpDate);

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
