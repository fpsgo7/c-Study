using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShootingGame
{
    public static class GameWorld
    {
        public static Player player;
        public static ThreadManger threadManger;
        public static void Init()
        {
            Background.Init();
            player = new Player(ResourceManager.BackgroundImage.Width,
                ResourceManager.BackgroundImage.Height,
                ResourceManager.PlayerImage.Height,
                ResourceManager.PlayerImage.Width);
            threadManger = new ThreadManger();
        }
    }
}
