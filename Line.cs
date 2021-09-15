using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Game
{
    class Line : Shape
    {
        public override int Top { get; set; }
        public override int Left { get; set; }
        public override char TheChar { get; set; }

        public Line(int top, int left, char theChar)
        {
            Top = top;
            Left = left;
            TheChar = theChar;
        }

        public void PrintLine(PlayGround playGround)
        {
            bool isPointIsGood;
            int LineLong;
            do
            {
                isPointIsGood = true;
                LineLong = new Random().Next(2, 10);
                Top = new Random().Next(2, 15);
                Left = new Random().Next(70);
                //if (Left + LineLong < playGround.screenMat.GetLength(Top) - Left)
                //{
                for (int i = 0; i < LineLong; i++)
                    {

                        if (!(playGround.screenMat[Left + i, Top] == " " || playGround.screenMat[Left + i, Top] == null))
                        {
                            isPointIsGood = false;
                            break;
                        }

                    }
                //}

            } while (!isPointIsGood);

            if (isPointIsGood)
            {
                for (int i = 0; i < LineLong; i++)
                {
                    playGround.PrintChar(new Point(Left + i, Top), TheChar);
                }
            }

        }
    }
}
