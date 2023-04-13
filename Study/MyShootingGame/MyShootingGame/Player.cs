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
        private int backgroundWidth,backgroundHeight;
        private int playerHeight;
        private Thread playerThread;
        private bool isPlayerMove = true;
        public bool IsPlayerMove
        {
            set
            {
                isPlayerMove = value;
            }
        }
        public Player(int backgroundWidth, int backgroundHeight,int playerHeight)
        {
            this.backgroundWidth = backgroundWidth;
            this.backgroundHeight = backgroundHeight;
            this.playerHeight = playerHeight;
            playerX = 10;
            playerY = 
                (backgroundHeight
                - this.playerHeight) / 2;
        }
        public void PlayerMove()
        {
            while (isPlayerMove)
            {

                playerX++;
                try
                {
                    Thread.Sleep(16); // 0.2 초 기다림
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
        }
    }
}
