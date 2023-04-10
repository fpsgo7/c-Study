using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShootingGame
{
    public partial class Form1 : Form
    {
        Image backgroundImage; // 배경 이미지
        Image playerSourceImage; // 플레이어 이미지
        Bitmap playerImage;//사용할 플레이어 이미지
        int backgroundImageWidth; // 이미지 폭
        int backgroundImageHeight; // 이미지 높이
        int backgroundImageX; // 배경 위치
        int playerX, playerY; //플레이어 위치
        Thread backgroundThread;
        public Form1()
        {
            InitializeComponent();
            backgroundImage = Image.FromFile(@"C:\Users\FPSGO\Pictures\Saved Pictures\트루엔딩.PNG");
            playerSourceImage = Image.FromFile(@"C:\Users\FPSGO\Pictures\Saved Pictures\new.JPG");
            Size playerSize = new Size(100, 100);
            playerImage = new Bitmap(playerSourceImage, playerSize);

            backgroundImageWidth = backgroundImage.Width;
            backgroundImageHeight = backgroundImage.Height;
            this.ClientSize = new System.Drawing.Size(backgroundImageWidth, backgroundImageHeight);
            backgroundImageX = 0;
            playerX = 10;
            playerY = (backgroundImage.Height - playerImage.Height) / 2;
            backgroundThread= new Thread(backgroundMove);
            backgroundThread.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(backgroundImage, backgroundImageX, 0);//배경이미지1
            e.Graphics.DrawImage(backgroundImage, backgroundImage.Width+backgroundImageX, 0);//배경이미지2
            e.Graphics.DrawImage(playerImage, playerX, playerY);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isContinue = false; // refreshScreen() 함수의 반복문 종료
            backgroundThread.Join(); // 쓰레드 종료 기다리기
        }
    }
}
