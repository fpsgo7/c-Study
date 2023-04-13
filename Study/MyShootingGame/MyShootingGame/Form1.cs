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
        //리소스를 관리하는 클래스 만들기
        //배경을 움직이는 클래스를 따로 만든다. 랜더큐 참고
        //플레이어 를 관리하는 클래스를 따로만든다.
        
        
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(Program.resourceManager.BackgroundImage.Width
                , Program.resourceManager.BackgroundImage.Height);
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Program.resourceManager.BackgroundImage, 
                Program.moveBackGround.backgroundImageX, 0);//배경이미지1
            e.Graphics.DrawImage(Program.resourceManager.BackgroundImage,
                Program.resourceManager.BackgroundImage.Width +
                Program.moveBackGround.backgroundImageX, 0);//배경이미지2
            e.Graphics.DrawImage(Program.resourceManager.PlayerImage, 
                Program.player.playerX, Program.player.playerY);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.moveBackGround.IsBackgroundMove = false;
            Program.moveBackGround.BackgroundMoveEnd(); 
        }
    }
}
