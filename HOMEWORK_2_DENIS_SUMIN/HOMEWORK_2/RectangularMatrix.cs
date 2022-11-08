using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_2
{
    internal class RectangularMatrix
    {
        private int size, sizeLine, sizeColumn;
        private int[,] matrix;

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int SizeLine
        {
            get
            {
                return this.sizeLine;
            }
            set
            {
                this.sizeLine = value;
            }
        }

        public int SizeColumn
        {
            get
            {
                return this.sizeColumn;
            }
            set
            {
                this.sizeColumn = value;
            }
        }
        public int[,] Matrix
        {
            get
            {
                return this.matrix;
            }
            set
            {// Зміна розміру мусить викликати виділення пам'яті
                this.matrix = value;
            }
        }

        public RectangularMatrix()
        {
            this.size = 0;
            this.matrix = new int[0, 0];
        }

        public RectangularMatrix(int size)
        {
            this.size = size;
            this.sizeLine = size;
            this.sizeColumn = size;
            this.matrix = new int[size, size];
        }

        public RectangularMatrix(int sizeA , int sizeB)
        {
            this.sizeLine = sizeA;
            this.sizeColumn = sizeB;
            this.matrix = new int[sizeA, sizeB];
        }

        public void VerticalSnake()
        {
            int number = 1;
            for (int i = 0; i < this.size; i++)
            {//можна оптимізувати
                if (i % 2 == 0)
                {
                    for (int j = 0; j < this.size; j++)
                    {
                        this.matrix[j, i] = number++;
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(0); j > 0;)
                    {
                        j--;
                        this.matrix[j, i] = number++;
                    }

                }
            }
        }

        public void SpiralSnake()
        {
            int columnNum = 0;
            int lineNum = 0;
            int number = 1;
            int tempsize = this.size;
            --tempsize;
            for (int i = tempsize; i >= 0; i -= 1)
            {
                for (int line = lineNum, column = columnNum; line < i; line++)
                {
                    this.matrix[line, column] = number++;
                }
                for (int line = i, column = columnNum; column < i; column++)
                {
                    this.matrix[line, column] = number++;
                }
                for (int line = i, column = i; line > columnNum; line--)
                {
                    this.matrix[line, column] = number++;
                }
                for (int line = lineNum, column = i; column > columnNum; column--)
                {
                    this.matrix[line, column] = number++;
                }
                if (i == columnNum)
                {
                    this.matrix[i, i] = number;
                }
                lineNum++;
                columnNum++;
            }
        }

        public void DiagonalSnake()
        {
            int tempsize = this.size;
            tempsize--;
            int colum = this.size; 

            int x, y,  
                value = 1; 

          
            for (int diag = 0; diag < colum; diag++) 
            {
                if (diag % 2 == 0) 
                {
                    x = diag; 
                    y = 0; 

                    while (x >= 0) 
                    {
                        this.matrix[x, y] = value; 
                        value++;
                        x -= 1;  
                        y += 1; 
                    }
                    
                }else 
                {
                    x = 0; 
                    y = diag; 

                    while (y >= 0) 
                    {
                        this.matrix[x, y] = value;
                        value++;
                        x++;     
                        y--;    
                    }
                }
            } 
           
            for (int diag = 1; diag < colum; diag++)
            {
                if (diag % 2 == 0) 
                {
                    x = diag; 
                    y = tempsize;  

                    while (x <= tempsize) 
                    {
                        this.matrix[x, y] = value;
                        value++;
                        x++; 
                        y--; 
                    }
                }else 
                {
                    x = tempsize; 
                    y = diag;  

                    while (y <= tempsize) 
                    {
                        this.matrix[x, y] = value;
                        value++;
                        x--; 
                        y++; 
                    }
                } 
            } 
        }

        public void LongNum()
        {//заповнення і пошук в одному методі - не добре!
            Random r = new Random();
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    this.matrix[i, j] = r.Next(0, 16);
                }
            }
            int startIndexLine = 0;
            int startIndexColumn = 0;
            int color = 0;
            int lenght = 1;
            for (int i = 0; i < size; i++)
            {
                int compareNum = this.matrix[i, 0];
                for (int j = 1; j < size; j++)
                {
                    int lenghtLine = 1;
                    int currentNum = this.matrix[i, j];
                    if (compareNum == currentNum)
                    {
                        lenghtLine++;
                        startIndexLine = i;
                        startIndexColumn = j - 1;
                        color = currentNum;
                    }
                    else
                    {
                        compareNum = currentNum;
                    }
                    if (lenght < lenghtLine)
                    {
                        lenght = lenghtLine;
                    }
                }
            }
            if (lenght == 1)
            {
                Console.WriteLine("Lenght:0,\tColor:0\tStart Index:-\t Last Index:-");
            }else
            {
                Console.WriteLine($"Lenght:{lenght}\nStart Index:{startIndexLine},{startIndexColumn}\nLast Index:{startIndexLine},{startIndexColumn + (--lenght)}");
            }
        }

        public void Show()
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    Console.Write(this.matrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
