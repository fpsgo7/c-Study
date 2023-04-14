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
        Thread moveThread;
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
            moveThread = new Thread(PlayMode);
            moveThread.Start();
        }

        public void PlayMode()
        {
            while (isMainTrheadMove)
            {
                Program.playerMove.PlayerControll();
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
            moveThread.Join();
        }
    }
}
