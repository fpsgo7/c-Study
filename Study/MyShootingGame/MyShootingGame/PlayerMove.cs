using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyShootingGame
{
    public class PlayerMove
    {
        public int playerX, playerY; //플레이어 위치
        public bool isMoveLeft;
        public bool isMoveRight;
        public bool isMoveUp;
        public bool isMoveDown;
        public bool isFire;
        private int backgroundWidth,backgroundHeight;
        private int playerHeight;
        private int playerWidth;
        private int playerSpeed = 10;

       
        public PlayerMove(int backgroundWidth, int backgroundHeight,int playerHeight,int playerWidth)
        {
            this.backgroundWidth = backgroundWidth;
            this.backgroundHeight = backgroundHeight;
            this.playerHeight = playerHeight;
            this.playerWidth = playerWidth;
            playerX = 100;
            playerY = 
                (backgroundHeight
                - this.playerHeight) / 2;
        }
        public void PlayerControll()
        {
            if (isMoveUp && playerY > 0)
            {
                playerY -= playerSpeed;
            }
            if (isMoveDown && playerY < backgroundHeight - playerHeight)
            {
                playerY += playerSpeed;
            }
            if (isMoveRight && playerX < backgroundWidth - playerWidth)
            {
                playerX += playerSpeed;
            }
            if (isMoveLeft && playerX > 0)
            {
                playerX -= playerSpeed;
            }
        }
    }
}
