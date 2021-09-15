using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Game
{
    class Rectangle : Shape
    {
        public override int Top { get; set; }
        public override int Left { get; set; }
        public override char TheChar { get; set; }

        public Rectangle(int top, int left, char theChar)
        {
            Top = top;
            Left = left;
            TheChar = theChar;
        }

        public void PrintRectangle(PlayGround playGround)
        {


            bool isPointIsGood;
            int RectangleLong, RectangleHigh;
            do
            {
                isPointIsGood = true;
                RectangleLong = new Random().Next(2, 7);
                RectangleHigh = new Random().Next(2, 7);
                Top = new Random().Next(2, 15);
                Left = new Random().Next(70);


                for (int i = 0; i < RectangleLong; i++)
                {
                    for (int j = 0; j < RectangleHigh; j++)
                    {

                        if (!(playGround.screenMat[Left + j, Top + i] == " " || playGround.screenMat[Left + j, Top + i] == null))
                        {
                            isPointIsGood = false;
                            break;
                        }

                    }
                }



            } while (!isPointIsGood);

            if (isPointIsGood)
            {
                for (int i = 0; i < RectangleLong; i++)
                {
                    for (int j = 0; j < RectangleLong; j++)
                    {
                        playGround.PrintChar(new Point(Left + i, Top + j), TheChar);

                    }

                }
            }

        }

    }
}

