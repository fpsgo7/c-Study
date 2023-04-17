using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShootingGame
{
    /// <summary>
    ///  플레이어 랜더 객체
    /// </summary>
    public class PlayerRender : Render
    {
        public PlayerRender(int playerX, int playerY)
        {
            image = ResourceManager.PlayerImage;
            imageX = playerX;
            imageY = playerY;
        }

        public override void MoveImage()
        {
            imageX = GameWorld.player.playerX;
            imageY = GameWorld.player.playerY;
        }
    }
}
