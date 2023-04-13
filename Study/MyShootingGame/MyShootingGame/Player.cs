using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyShootingGame
{
    public class Player
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
        private Thread playerThread;
        private bool isPlayerMove = true;
        private int playerSpeed = 10;

       
        public bool IsPlayerMove
        {
            set
            {
                isPlayerMove = value;
            }
        }
        public Player(int backgroundWidth, int backgroundHeight,int playerHeight,int playerWidth)
        {
            this.backgroundWidth = backgroundWidth;
            this.backgroundHeight = backgroundHeight;
            this.playerHeight = playerHeight;
            this.playerWidth = playerWidth;
            playerX = 100;
            playerY = 
                (backgroundHeight
                - this.playerHeight) / 2;
            playerThread = new Thread(PlayerMove);
            playerThread.Start();
        }
        public void PlayerMove()
        {
            while (isPlayerMove)
            {

                if(isMoveUp && playerY > playerHeight)
                {
                    playerY-= playerSpeed;
                }
                if(isMoveDown && playerY < backgroundHeight - playerHeight)
                {
                    playerY+= playerSpeed;
                }
                if(isMoveRight && playerX < backgroundWidth - playerWidth)
                {
                    playerX+= playerSpeed;
                }
                if(isMoveLeft && playerX > playerWidth)
                {
                    playerX-= playerSpeed;
                }

                try
                {
                    Thread.Sleep(20); // 0.2 초 기다림
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
        }

        public void PlayerMoveEnd()
        {
            playerThread.Join();
        }
    }
}
