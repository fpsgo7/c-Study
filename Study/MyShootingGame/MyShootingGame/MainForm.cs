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

        Thread renderThread;
        private bool isRenderThread = true;

        public MainForm()
        {
            InitializeComponent();
            renderThread = new Thread(Rendering);
            renderThread.Start();
            this.ClientSize = new System.Drawing.Size(ResourceManager.BackgroundImage.Width
                , ResourceManager.BackgroundImage.Height);
           
        }
        public void Rendering()
        {
            while (isRenderThread)
            {
                this.Invalidate();
                try
                {
                    Thread.Sleep(20); // 0.2 초 기다림
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show(e.Message);
                    break;
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Render render in Renderer.renders)
            {
                e.Graphics.DrawImage(render.image,
                   render.imageX, render.imageY);
                render.MoveImage();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Program.threadManger.IsMainTrheadMove = false;
            //Program.threadManger.PlayeModeEnd();
            isRenderThread = false;
            renderThread.Join();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                GameWorld.player.isMoveLeft =true;
            }
            if(e.KeyCode == Keys.Right)
            {
                GameWorld.player.isMoveRight = true;
            }
            if(e.KeyCode == Keys.Up)
            {
                GameWorld.player.isMoveUp = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                GameWorld.player.isMoveDown = true;
            }
            if (e.KeyData == Keys.Space)
            {
                GameWorld.player.isFire = true;
            }
               
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GameWorld.player.isMoveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                GameWorld.player.isMoveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                GameWorld.player.isMoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                GameWorld.player.isMoveDown = false;
            }
            if (e.KeyData == Keys.Space)
            {
                GameWorld.player.isFire = false;
            }
        }
    }
}
