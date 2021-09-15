using System;

namespace Shapes_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.ForegroundColor = ConsoleColor.White;

            int numberOfShapes = new Random().Next(3, 6);
            PlayGround playGround = new PlayGround() {ShapeNumber = numberOfShapes};
            Console.WriteLine($"Num of Shapes : {playGround.ShapeNumber}");
            Console.WriteLine($"Score : {playGround.Score}");

            Point point = new Point(5, 5);
            playGround.PrintChar(point,'*');



            for (int i = 0; i < numberOfShapes; i++)
            {
                playGround.PrintShape();
                System.Threading.Thread.Sleep(100);
            }


            while (playGround.ShapeNumber <= 15)
            {

                var key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        playGround.MoveUp(point);
                        break;
                    case ConsoleKey.DownArrow:
                        playGround.MoveDown(point);
                        break;
                    case ConsoleKey.LeftArrow:
                        playGround.MoveLeft(point);
                        break;
                    case ConsoleKey.RightArrow:
                        playGround.MoveRight(point);
                        break;
                }
            }
         
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                    playGround.screenMat[j, i] = " ";
                }
            }

            Console.SetCursorPosition(30,10);
            Console.Write("Game Over");
            Console.SetCursorPosition(40, 10);
            Console.WriteLine($"Score : {playGround.Score}");
            Console.ReadKey();

        }
    }
}
