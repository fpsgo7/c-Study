using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShootingGame
{
    public class ThreadManger
    {
        Thread mainThread;
        private bool isMainTrheadMove = true;
        public bool IsMainTrheadMove
        {
            set
            {
                isMainTrheadMove = value;
            }
        }
        public ThreadManger()
        {
            mainThread = new Thread(PlayMode);
            mainThread.Start();
        }

        public void PlayMode()
        {
            while (isMainTrheadMove)
            {
                GameWorld.player.PlayerControll();
                try
                {
                    Thread.Sleep(20); // 0.2 초 기다림
                } 
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show(e.Message);
                    break;
                }
            }
        }

        public void PlayeModeEnd()
        {
            mainThread.Join();
        }
    }
}
