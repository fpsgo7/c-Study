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
    public partial class MainForm : Form
    {
        //리소스를 관리하는 클래스 만들기
        //배경을 움직이는 클래스를 따로 만든다. 랜더큐 참고
        //플레이어 를 관리하는 클래스를 따로만든다.
        
        
        public MainForm()
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
                Program.playerMove.playerX, Program.playerMove.playerY);
            //e.Graphics.DrawImage(Program.resourceManager.EnemyImage,
            //    Program.enemy.enemyX, Program.enemy.enemyY);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.threadManger.IsMainTrheadMove = false;
            Program.threadManger.PlayeModeEnd();
            Program.moveBackGround.IsBackgroundMove = false;
            Program.moveBackGround.BackgroundMoveEnd();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                Program.playerMove.isMoveLeft =true;
            }
            if(e.KeyCode == Keys.Right)
            {
                Program.playerMove.isMoveRight = true;
            }
            if(e.KeyCode == Keys.Up)
            {
                Program.playerMove.isMoveUp = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                Program.playerMove.isMoveDown = true;
            }
            if (e.KeyData == Keys.Space)
            {
                Program.playerMove.isFire = true;
            }
               
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Program.playerMove.isMoveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                Program.playerMove.isMoveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                Program.playerMove.isMoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                Program.playerMove.isMoveDown = false;
            }
            if (e.KeyData == Keys.Space)
            {
                Program.playerMove.isFire = false;
            }
        }
    }
}
