using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyShootingGame
{
    public partial class Form1
    {
        bool isContinue = true;
        private void backgroundMove()
        {
            while (isContinue)
            {
                backgroundImageX -= 5;
                if(backgroundImageX < -backgroundImageWidth)
                {
                    backgroundImageX = 0;
                }
                try
                {
                    Thread.Sleep(16); // 0.2 초 기다림
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
                this.Invalidate();
            }
        }
    }
}
