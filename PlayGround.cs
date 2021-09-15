using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Game
{
    class PlayGround
    {
        public string[,] screenMat = new string[80, 25];

        public int ShapeNumber { get; set; } = 3;
        public int Score { get; set; } = 0;

        public void PrintChar(Point point, char ch)
        {
            screenMat[point.Vertical, point.Horizontal] = ch.ToString();
            Console.SetCursorPosition(point.Vertical, point.Horizontal);
            Console.Write(ch);
        }


        #region Moving Methods


        public void MoveUp(Point point)
        {
            // Making The Cohavit Blue

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(point.Vertical, point.Horizontal);
            Console.Write("*");
            screenMat[point.Vertical, point.Horizontal] = "*";

            // Cheking If New Piont Is Good

            Console.ForegroundColor = ConsoleColor.White;

            if ((screenMat[point.Vertical, point.Horizontal - 1] == null || screenMat[point.Vertical, point.Horizontal - 1] == " ") && (point.Horizontal - 1 > 0 ))
            {
                Console.SetCursorPosition(point.Vertical, point.Horizontal - 1);
                Console.Write("*");
                screenMat[point.Vertical, point.Horizontal - 1] = "*";
                point.Horizontal--;
                Score++;
                Console.SetCursorPosition(8, 1);
                Console.WriteLine(Score);
            }
            else
            {
                ShapeNumber++;
                for (int i = 0; i < screenMat.GetLength(0); i++)
                {
                    for (int j = 0; j < screenMat.GetLength(1); j++)
                    {
                        if (screenMat[i,j] == "*")
                        {
                            screenMat[i, j] = " ";
                            Console.SetCursorPosition(i, j);
                            Console.Write(" ");
                        }
                    }
                }

                PrintShape();
                PrintChar(new Point(5, 5), '*');
                point.Horizontal = 5;
                point.Vertical = 5;



            }

        }

        public void MoveDown(Point point)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(point.Vertical, point.Horizontal);
            Console.Write("*");
            screenMat[point.Vertical, point.Horizontal] = "*";
            Console.ForegroundColor = ConsoleColor.White;
            if ((screenMat[point.Vertical, point.Horizontal + 1] == null || screenMat[point.Vertical, point.Horizontal + 1] == " ") && (point.Horizontal + 1 < screenMat.GetUpperBound(1)))
            {
                Console.SetCursorPosition(point.Vertical, point.Horizontal + 1);
                Console.Write("*");
                screenMat[point.Vertical, point.Horizontal + 1] = "*";
                point.Horizontal++;
                Score++;
                Console.SetCursorPosition(8, 1);
                Console.WriteLine(Score);
            }
            else 
            {
                ShapeNumber++;
                for (int i = 0; i < screenMat.GetLength(0); i++)
                {
                    for (int j = 0; j < screenMat.GetLength(1); j++)
                    {
                        if (screenMat[i, j] == "*")
                        {
                            screenMat[i, j] = " ";
                            Console.SetCursorPosition(i, j);
                            Console.Write(" ");
                        }
                    }
                }

                PrintShape();
                PrintChar(new Point(5, 5), '*');
                point.Horizontal = 5;
                point.Vertical = 5;
            }

        }

        public void MoveLeft(Point point)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(point.Vertical, point.Horizontal);
            Console.Write("*");
            screenMat[point.Vertical, point.Horizontal] = "*";
            Console.ForegroundColor = ConsoleColor.White;
            if ((screenMat[point.Vertical - 1, point.Horizontal] == null || screenMat[point.Vertical -1, point.Horizontal] == " ") && (point.Vertical - 1 > 0))
            {
                Console.SetCursorPosition(point.Vertical - 1, point.Horizontal);
                Console.Write("*");
                screenMat[point.Vertical - 1, point.Horizontal] = "*";
                point.Vertical--;
                Score++;
                Console.SetCursorPosition(8, 1);
                Console.WriteLine(Score);

            }
            else 
            {
                ShapeNumber++;
                for (int i = 0; i < screenMat.GetLength(0); i++)
                {
                    for (int j = 0; j < screenMat.GetLength(1); j++)
                    {
                        if (screenMat[i, j] == "*")
                        {
                            screenMat[i, j] = " ";
                            Console.SetCursorPosition(i, j);
                            Console.Write(" ");
                        }
                    }
                }

                PrintShape();
                PrintChar(new Point(5, 5), '*');
                point.Horizontal = 5;
                point.Vertical = 5;
            }

        }

        public void MoveRight(Point point)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(point.Vertical, point.Horizontal);
            Console.Write("*");
            screenMat[point.Vertical, point.Horizontal] = "*";
            Console.ForegroundColor = ConsoleColor.White;
            if ((screenMat[point.Vertical + 1, point.Horizontal] == null || screenMat[point.Vertical +1 , point.Horizontal] == " ")&& (point.Vertical + 1 < screenMat.GetUpperBound(0)))
            {
                Console.SetCursorPosition(point.Vertical + 1, point.Horizontal);
                Console.Write("*");
                screenMat[point.Vertical + 1, point.Horizontal] = "*";
                point.Vertical++;
                Score++;
                Console.SetCursorPosition(8,1);
                Console.WriteLine(Score);
            }
            else
            {
                ShapeNumber++;
                for (int i = 0; i < screenMat.GetLength(0); i++)
                {
                    for (int j = 0; j < screenMat.GetLength(1); j++)
                    {
                        if (screenMat[i, j] == "*")
                        {
                            screenMat[i, j] = " ";
                            Console.SetCursorPosition(i, j);
                            Console.Write(" ");
                        }
                    }
                }

                PrintShape();
                PrintChar(new Point(5, 5), '*');
                point.Horizontal = 5;
                point.Vertical = 5;
            }

        }

        #endregion

        public void PrintShape()
        {

            ShapeEnum shape = (ShapeEnum)new Random().Next(3);

            switch (shape)
            {
                case ShapeEnum.Line:
                    new Line(new Random().Next(2,15), new Random().Next(70), '=').PrintLine(this);
                    break;
                case ShapeEnum.Squer:
                    new Squer(new Random().Next(2, 15), new Random().Next(70), 'o').PrintSquer(this);
                    break;
                case ShapeEnum.Triangle:
                    new Triangle(new Random().Next(2, 15), new Random().Next(70), '^').PrintTriangle(this);
                    break;
                case ShapeEnum.Rectangle:
                    new Rectangle(new Random().Next(2, 15), new Random().Next(70), '#').PrintRectangle(this);
                    break;           
            }
            Console.SetCursorPosition(16, 0);
            Console.Write(ShapeNumber);
        }

    }





}

