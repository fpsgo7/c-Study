using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShootingGame
{
    public static class Background
    {
        public static void Init()
        {
            BackgroundRender background1 = new BackgroundRender();
            Renderer.AddRenders(background1);

            BackgroundRender background2 = new BackgroundRender();
            background2.imageX = background2.image.Width;
            Renderer.AddRenders(background2);
        }
      
    }
}
