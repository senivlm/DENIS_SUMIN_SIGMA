namespace HOMEWORK_1
{
    internal class Buy
    {
        private static int size;
        private decimal sum = default;
        private readonly Product[] products = null;
        private readonly int[] numbersProducts = null;

        public static int Size 
        {
            get 
            { 
                return size; 
            }
        }

        public decimal Sum 
        {
            get
            {
                return this.sum;
            }
            set
            {
                this.sum = value;
            }
        }
        static Buy()
        {
            Console.Write("Вкажiть кiлькicть продуктiв якi ви хочете купити:");
            size = Convert.ToInt32(Console.ReadLine());
        }
        public Buy()
        {
            products = new Product[size];
            numbersProducts = new int[size];
            Sum = 0;
            for (int i = 0; i < products.Length; i++)
            {
                products[i] = new Product();
            }
        }

        public Product[] Products
        {
            get
            {
                return this.products;
            }
        }

        public void AddProducts()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.Write($"Вкажiть назву продукту:");
                products[i].Name = Console.ReadLine();
                Console.Write($"Вкажiть цiну продукту в гривнях:");
                products[i].Price = Convert.ToDecimal(Console.ReadLine());
                Console.Write($"Вкажiть вагу продукту в кiлограмах:");
                products[i].Weight = Convert.ToInt32((Console.ReadLine()));
            }
            Console.Clear();
        }

        public void AddNumberProducts()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.Write($"Вкажiть кiлькiсть товару {products[i].Name} в штуках:");
                numbersProducts[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
        }

        public void PurchaseAmount()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Sum += (numbersProducts[i] * products[i].Price);
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < products.Length; i++)
            {
                result += string.Format($"Ви купили:{products[i].Name},\t" +
                                            $"в кiлькостi:{numbersProducts[i]} штук.\n");
            }
            result += $"Сума покупки складає:{Sum} гривень";
            return result;
        }
    }
}