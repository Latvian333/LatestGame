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
    public class BackGround
    {
        Texture entitytex = new Texture(); 
        public Vector2 position = new Vector2(0.0f, 0.0f);

        public BackGround()
        {
             
            
            
            
        }

        public void initializeTexture(OpenGL gl)
        {
            entitytex.Create(gl, AppDomain.CurrentDomain.BaseDirectory + @"\Sprites\dirt.jpg");
           
        }

        public void EntityRender(OpenGL gl)
        {
            gl.LoadIdentity();
            entitytex.Bind(gl);
            
            gl.Translate(0, 0, -40f);
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-30.0f, 30.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(30.0f, 30.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(30.0f, -30.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-30.0f, -30.0f);
            gl.End();
            gl.Flush();
        }



    }
}
