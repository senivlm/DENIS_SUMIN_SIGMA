namespace HOMEWORK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RectangularMatrix matr = new RectangularMatrix(10);

            RectangularMatrix matr1 = new RectangularMatrix(3,3);

            RectangularMatrix matr2 = new RectangularMatrix(10);

            RectangularMatrix matr3 = new RectangularMatrix(10);

            matr.DiagonalSnake();
            matr.Show();

            Console.Clear();

            matr1.VerticalSnake();
            matr1.Show();

            Console.Clear();

            matr2.SpiralSnake();
            matr2.Show();

            Console.Clear();

            matr3.LongNum();
            matr3.Show();

            Console.ReadLine();
        }
    }
}