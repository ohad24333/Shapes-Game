using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Game
{
    class Triangle : Shape
    {
        public override int Top { get; set; }
        public override int Left { get; set; }
        public override char TheChar { get; set; }

        public Triangle(int top, int left, char theChar)
        {
            Top = top;
            Left = left;
            TheChar = theChar;
        }

        public void PrintTriangle(PlayGround playGround)
        {


            bool isPointIsGood;
            int triangleLong;
            do
            {
                isPointIsGood = true;
                triangleLong = new Random().Next(3, 10);
                Top = new Random().Next(2, 15);
                Left = new Random().Next(70);

                for (int i = 0; i <= triangleLong; i++)
                {
                    for (int j = 0; j <= i; j++)
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
                for (int i = 0; i <= triangleLong; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        playGround.PrintChar(new Point(Left + i, Top + j), TheChar);

                    }

                }
            }
        }
    }
}
