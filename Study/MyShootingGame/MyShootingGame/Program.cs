using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShootingGame
{
    static class Program
    {
        public static ThreadManger threadManger;
        public static MoveBackGround moveBackGround;
        public static MainForm form1;
        public static PlayerMove playerMove;

        //public static Enemy enemy;
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ResourceManager.Init();
            //moveBackGround = new MoveBackGround(resourceManager.BackgroundImage.Width,
            //   resourceManager.BackgroundImage.Height);
            //playerMove = new PlayerMove(resourceManager.BackgroundImage.Width,
            //   resourceManager.BackgroundImage.Height,
            //   resourceManager.PlayerImage.Height,
            //   resourceManager.PlayerImage.Width);
            //enemy = new Enemy(resourceManager.BackgroundImage.Width,
            //   resourceManager.BackgroundImage.Height,
            //   resourceManager.PlayerImage.Height,
            //   resourceManager.PlayerImage.Width);
            threadManger = new ThreadManger();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1 = new MainForm());
        }
    }
}
