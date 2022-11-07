using SharpGL;
using SharpGL.SceneGraph.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Objects
{
   

    internal class ArrowBox
    {
        Texture texture = new Texture();
        int number = 0;
        public float x;
        public float y;
        public char key;
        public ArrowBox(int seed)
        {
            Random random = new Random(seed);
            int num = random.Next(4);
            number = num;
            
        }
        
        public void innitTexture(OpenGL gl)
        {
            if (number == 0)
            {
                texture.Create(gl, AppDomain.CurrentDomain.BaseDirectory + @"\Sprites\Up.png");
                key = 'w';
            }
            else if (number == 1)
            {
                texture.Create(gl, AppDomain.CurrentDomain.BaseDirectory + @"\Sprites\Left.png");
                key = 'a';
            }
            else if (number == 2)
            {
                texture.Create(gl, AppDomain.CurrentDomain.BaseDirectory + @"\Sprites\Right.png");
                key = 'd' ;
            }
            else if (number == 3)
            {
                texture.Create(gl, AppDomain.CurrentDomain.BaseDirectory + @"\Sprites\Down.png");
                key = 's';
            }
            
        }

        public void renderBox(OpenGL gl)
        {
            gl.LoadIdentity();
            texture.Bind(gl);
            gl.Translate(x, y, -10f);
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.15f, 0.15f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(0.15f, 0.15f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.15f, -0.15f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.15f, -0.15f);
            
            gl.End();
            gl.Flush();
        }

    }
}
