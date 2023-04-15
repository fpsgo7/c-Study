using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShootingGame
{
    static public class ResourceManager
    {
        static private Image backgroundImage; // 배경 이미지
        static private Image playerImage; // 플레이어 이미지
        static private Image bullet;//총알 이미지
        static private Image enemyImage;//적의 이미지
        static public Image BackgroundImage
        {
            get
            {
                return backgroundImage;
            }
        }
        static public Image PlayerImage
        {
            get
            {
                return playerImage;
            }
        }
        static public Image EnemyImage
        {
            get
            {
                return EnemyImage;
            }
        }
        static public void Init()
        {
            try
            {  
                //이미지 소스 가져오기
                backgroundImage = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Resources/석양.jpg");
                playerImage = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Resources/플레이어.PNG");
                enemyImage = Image.FromFile(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Resources/플레이어.PNG");
            }
            catch
            {
                MessageBox.Show(System.Windows.Forms.Application.StartupPath);
                MessageBox.Show(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName );
                MessageBox.Show("이미지가 없습니다.");
            }
          
            //플레이어이미지 사이즈 재조정
            Size resize = new Size(100, 100);
            Bitmap playerResizeImage = new Bitmap(playerImage,resize);
            playerImage = playerResizeImage;

            Bitmap enemyResizeImage = new Bitmap(playerImage, resize);
            enemyImage = enemyResizeImage;
        }


    }
}
