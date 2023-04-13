using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyShootingGame
{
    public class MoveBackGround
    {
        public int backgroundImageX=0; // 배경 위치
        private int backgroundImageWidth; // 이미지 폭
        private int backgroundImageHeight; // 이미지 높이
        private Thread backgroundThread;
        private bool isBackgroundMove = true;
        public bool IsBackgroundMove
        {
            set
            {
                isBackgroundMove = value;
            }
        }
        public MoveBackGround(int backgroundImageWidth, int backgroundImageHeight)
        {
            this.backgroundImageWidth = backgroundImageWidth;
            this.backgroundImageHeight = backgroundImageHeight;

            backgroundThread= new Thread(BackgroundMove);
            backgroundThread.Start();
        }
        public void BackgroundMove()
        {
            while (isBackgroundMove)
            {
                backgroundImageX -= 5;
                if (backgroundImageX < -backgroundImageWidth)
                {
                    backgroundImageX = 0;
                }
                try
                {
                    Thread.Sleep(16); // 0.2 초 기다림
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
               
                Program.form1.Invalidate();
            }
        }
        public void BackgroundMoveEnd()
        {
            backgroundThread.Join();
        }
    }
}
