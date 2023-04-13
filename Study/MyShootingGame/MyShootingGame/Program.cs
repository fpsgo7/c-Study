using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShootingGame
{
    static class Program
    {
        public static ResourceManager resourceManager;
        public static MoveBackGround moveBackGround;
        public static Form1 form1;
        public static Player player;
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            resourceManager = new ResourceManager();
            moveBackGround = new MoveBackGround(resourceManager.BackgroundImage.Width,
               resourceManager.BackgroundImage.Height);
            player = new Player(resourceManager.BackgroundImage.Width,
               resourceManager.BackgroundImage.Height,
               resourceManager.PlayerImage.Height,
               resourceManager.PlayerImage.Width);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1 = new Form1());
        }
    }
}
