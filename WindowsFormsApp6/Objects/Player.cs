using SharpGL;
using SharpGL.SceneGraph.Assets;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Objects
{
    public class Player
    {
        Texture entitytex = new Texture(); 
        public Vector2 position = new Vector2(0.0f, 0.0f);
        public int points = 0;
        public int lives = 3;
        public Player()
        {
            
            
            
            
        }

        public void initializeTexture(OpenGL gl)
        {
            entitytex.Create(gl, AppDomain.CurrentDomain.BaseDirectory + @"\Sprites\Mario.png");
           
        }
        
        public void takeDamage(int points)
        {
            lives = lives - points;
        }

        public void addPoints(int i)
        {
           points = points + i;
        }

        public void EntityRender(OpenGL gl)
        {
            gl.LoadIdentity();
            entitytex.Bind(gl);
            
            gl.Translate(0, 0, -10f);
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
        }



    }
}
