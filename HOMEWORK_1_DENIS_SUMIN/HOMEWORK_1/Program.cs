namespace HOMEWORK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check.StartMessage();

            Buy firstbuy = new Buy();

            Check.WorkProcess(firstbuy);

            Check.ShowProductInfo(firstbuy);

            Check.ShowBuyInfo(firstbuy);
        }
    }
}