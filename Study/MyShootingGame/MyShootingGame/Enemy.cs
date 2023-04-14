using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyShootingGame
{
    class Enemy
    {
        public int enemyX, enemyY; //적의 위치
        public bool isMoveLeft;
        public bool isMoveRight;
        public bool isMoveUp;
        public bool isMoveDown;
        public bool isFire;
        private int backgroundWidth, backgroundHeight;
        private int enemyHeight;
        private int enemyWidth;
        private Thread playerThread;
        private bool isPlayerMove = true;
        private int enemySpeed = 5;

        public bool IsPlayerMove
        {
            set
            {
                isPlayerMove = value;
            }
        }
        public Enemy(int backgroundWidth, int backgroundHeight, int playerHeight, int playerWidth)
        {
            this.backgroundWidth = backgroundWidth;
            this.backgroundHeight = backgroundHeight;
            this.enemyHeight = playerHeight;
            this.enemyWidth = playerWidth;
            enemyX = backgroundWidth;
            enemyY =
                (backgroundHeight
                - this.enemyHeight) / 2;
            playerThread = new Thread(EnemyMove);
            playerThread.Start();
        }

        public void EnemyMove()
        {
            enemyX -= enemySpeed;
        }
    }
}
