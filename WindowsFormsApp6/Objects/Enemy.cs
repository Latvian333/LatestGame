using SharpGL;
using SharpGL.SceneGraph.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp6.Objects.Player;

namespace WindowsFormsApp6.Objects
{
    internal class Enemy
    {
        Texture texenemy = new Texture();
        public float x = 0;
        public float y = 0;
        public bool reachedplayer = false;
        public List<ArrowBox> arrowBoxes = new List<ArrowBox>();
        public int boxcount = 4;

        public Enemy()
        {
            DateTime now = DateTime.Now;
            Random random = new Random((int)now.Ticks);
           

            int num = random.Next(10);
            if (num == 1 )
            {
                y = 6.5f;
            }else if (num == 2)
            {
                y = -6.5f;
            }
            else if (num == 3)
            {
                y = 5;
            }
            else if (num == 4)
            {
                y = - 5;
            }else if(num == 5)
            {
                y = 6;
            }else if(num == 6)
            {
                y = -6;
            }else if (num == 7)
            {
                y = -7;
            }else if (num == 8)
            {
                y = 7;
            }else if (num == 9)
            {
                y = 8;
            }else if(num == 10)
            {
                y = -8;
            }

                num = random.Next(10);
            if (num == 1)
            {
                x = 6.5f;
            }
            else if (num == 2)
            {
                x = -6.5f;
            }
            else if (num == 3)
            {
                x = 5;
            }
            else if (num == 4)
            {
                x = -5;
            }
            else if (num == 5)
            {
                x = 6;
            }
            else if (num == 6)
            {
                x = -6;
            }
            else if (num == 7)
            {
                x = -7;
            }
            else if (num == 8)
            {
                x = 7;
            }
            else if (num == 9)
            {
                x = 8;
            }
            else if (num == 10)
            {
                x = -8;
            }

            for (int i = 0; i < 4; i++) {
                ArrowBox box = new ArrowBox((int)now.Ticks + i);
                arrowBoxes.Add(box);
            }

            
        
        }



        public void initializetexture(OpenGL gl)
        {
            texenemy.Create(gl, AppDomain.CurrentDomain.BaseDirectory + @"\Sprites\goomba.png");
            
        }



        public void renderEnemy(OpenGL gl)
        {
            gl.LoadIdentity();
            texenemy.Bind(gl);
            Move();
            
            gl.Translate(x, y, -10f);
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.25f, 0.25f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(0.25f, 0.25f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.25f, -0.25f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.25f, -0.25f);
            gl.End();
            gl.Flush();

            renderboxes(gl);
        }

        public void Move()
        {
            if(x < 1 && x > -1 && y < 1 && y > -1)
            {
                reachedplayer = true;
            }


                if (x < 0)
                {
                    x = x + 0.005f;
                }
                else
                {
                    x = x - 0.005f;
                }

                if (y < 0)
                {
                    y = y + 0.005f;
                }
                else
                {
                    y = y - 0.005f;
                }

            
        }

        public void renderboxes(OpenGL gl)
        {


            for (int i = 0; i < arrowBoxes.Count; i++)
            {
                ArrowBox box = arrowBoxes.ElementAt(i);

                float ybox = y - 0.5f;
                float xbox = x - 0.5f * i;

                    box.y = ybox;
                    box.x = xbox;
                
                box.innitTexture(gl);
                box.renderBox(gl);
            }

        }

        public int checkboxes(KeyPressEventArgs e)
        {
            if (arrowBoxes.Count - 1 != -1)
            {
                if (e.KeyChar == arrowBoxes.Last().key)
                {
                    arrowBoxes.RemoveAt(arrowBoxes.Count - 1);
                    boxcount = boxcount - 1;
                    return 50;
                }
            }
            return 0;

        }
        ~Enemy()
        {

        }
    }
}
