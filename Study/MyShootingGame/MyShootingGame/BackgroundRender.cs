using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShootingGame
{
    /// <summary>
    /// 배경 객체
    /// </summary>
    public class BackgroundRender : Render
    {
        private int backgroundImageWidth;

        public BackgroundRender()
        {
            base.imageX = 0;
            base.imageY = 0;
            image = ResourceManager.BackgroundImage;
            backgroundImageWidth = image.Width;
        }

        public override void MoveImage()
        {
            imageX -= 5;
            if (imageX < -backgroundImageWidth)
            {
                imageX = backgroundImageWidth -5;
            }
        }
    }
}
