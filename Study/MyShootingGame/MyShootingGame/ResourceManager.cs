using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShootingGame
{
    public class ResourceManager
    {
        private Image backgroundImage; // 배경 이미지
        private Image playerImage; // 플레이어 이미지
        public Image BackgroundImage
        {
            get
            {
                return backgroundImage;
            }
        }
        public Image PlayerImage
        {
            get
            {
                return playerImage;
            }
        }

        public ResourceManager()
        {
            //이미지 소스 가져오기
            backgroundImage = Image.FromFile(@"C:\Users\FPSGO\Pictures\Saved Pictures\트루엔딩.PNG");
            playerImage = Image.FromFile(@"C:\Users\FPSGO\Pictures\Saved Pictures\new.JPG");
            //이미지 사이즈 재조정
            Size resize = new Size(100, 100);
            Bitmap playerResizeImage = new Bitmap(playerImage,resize);
            playerImage = playerResizeImage;
        }


    }
}
