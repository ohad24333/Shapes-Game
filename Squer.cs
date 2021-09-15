using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Game
{
    class Squer : Shape
    {
        public override int Top { get; set; }
        public override int Left { get; set; }
        public override char TheChar { get; set; }

        public Squer(int top, int left, char theChar)
        {
            Top = top;
            Left = left;
            TheChar = theChar;
        }

        public void PrintSquer(PlayGround playGround)
        {
           
           
                bool isPointIsGood;
                int SquerLong, SquerHigh;
                do
                {
                    isPointIsGood = true;
                    SquerLong = new Random().Next(2, 10);
                    Top = new Random().Next(2, 15);
                    Left = new Random().Next(70);
                    SquerHigh = SquerLong;

                   
                        for (int i = 0; i <= SquerLong; i++)
                        {
                            for (int j = 0; j <= SquerHigh; j++)
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
                    for (int i = 0; i <= SquerLong; i++)
                    {
                        for (int j = 0; j <= SquerLong; j++)
                        {
                            playGround.PrintChar(new Point(Left + i, Top + j), TheChar);

                        }

                    }
                }

            }
            
        }
    }

