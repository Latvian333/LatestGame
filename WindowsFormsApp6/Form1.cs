using SharpGL;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Raytracing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Automation;
using System.Xml;
using WindowsFormsApp6.Objects;
using System.Media;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Player player = new Player();
        Enemy goomba1 = new Enemy();
        Enemy goomba2 = new Enemy();
        Enemy goomba3 = new Enemy();
        EnemyList enemies = new EnemyList();
        BackGround background = new BackGround();
        SoundPlayer Splayer = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + @"\Objects\Sounds\playerDeath.wav");
        SoundPlayer music = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + @"\Objects\Sounds\music.wav");
        int deathsoundcounter = 0;
        int totalenemies = 3;

        public Form1()
        {
            enemies.Add(goomba1);
            enemies.Add(goomba2);
            enemies.Add(goomba3);

            InitializeComponent();
            GameOverBG.Hide();
            GameOverText.Hide();
            GameOverPoints.Hide();
            OpenGL gl = this.openGLControl2.OpenGL;
            gl.Enable(OpenGL.GL_CULL_FACE);
            gl.CullFace(OpenGL.GL_FRONT);
            gl.FrontFace(OpenGL.GL_CCW);
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            gl.Enable(OpenGL.GL_BLEND);
        }

        private void openGLControl2_GDIDraw(object sender, SharpGL.RenderEventArgs args)
        {
           

            OpenGL gl = this.openGLControl2.OpenGL;

            
            gl.LookAt(0, 0, -50, 0, 0, 0, 0, 1, 0);
            gl.ClearColor(0, 255, 0, 255);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            if (player.lives > 0)
            {
                music.Play();
                
                int damage = 0;
                damage = enemies.checkifreachedplayer(gl, totalenemies);
                player.takeDamage(damage);
                label1.Text = "Points: " + player.points.ToString();
                label2.Text = "Lives: " + player.lives.ToString();
               
                gl.BlendFunc(OpenGL.GL_SRC_ALPHA, OpenGL.GL_ONE_MINUS_SRC_ALPHA);



                player.initializeTexture(gl);
                player.EntityRender(gl);
                enemies.render(gl);
                gl.Flush();
            }

            if (player.lives <= 0 || player.points >= 4000)
            {
                if (player.points >= 4000)
                {
                    GameOverText.Text = "YOU WON!!!!!";
                }
                if (deathsoundcounter == 0)
                {
                    Splayer.Play();
                    deathsoundcounter++;
                }
                
                GameOverPoints.Text = "Your Points:" + player.points.ToString();
                GameOverPoints.Show();
                GameOverText.Show();
                GameOverBG.Show();
               
            }


        }


        private void openGLControl2_KeyDown(object sender, KeyPressEventArgs e)
        {
         int points = enemies.checkifpressed(e);
            player.addPoints(points);
            label1.Text = "Points: " + player.points.ToString();
            label2.Text = "Lives: " + player.lives.ToString();
        }

        
    }
}
