using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL.Serialization;
using SharpGL.WinForms;
using SharpGL.SceneGraph;
using SharpGL;

namespace Graficacion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            gl.ClearColor(0, 0, 0, 0);

        }

        private void openGLControl1_Resize(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            gl.LoadIdentity();
            gl.Perspective(30.0f, (double)Width / (double)Height, 5, 100);
            gl.LookAt(-5, 5, -5, 0, 0, 0, 0, 1, 0);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;
            gl.LoadIdentity();

            //Rectangulo 1 Rojo
            gl.Translate(-1.5f, 0f, -5f);
            gl.Begin(OpenGL.GL_QUADS);
            {
                gl.Vertex(-0.1f, 1.0f, 0.0);
                gl.Vertex(1.0f, 1.0f, 0.0f);
                gl.Vertex(1.0f, -1.0f, 0.0f);
                gl.Vertex(-0.1f, -1.0f, 0.0f);
                //gl.Color(255f, 0.0f, 0.0f);
            }
            gl.End();
            //Rectangulo 2 Amarillo
            gl.Translate(1.12f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);
            {
                gl.Vertex(-0.1f, 1.0f, 0.0);
                gl.Vertex(1.0f, 1.0f, 0.0f);
                gl.Vertex(1.0f, -1.0f, 0.0f);
                gl.Vertex(-0.1f, -1.0f, 0.0f);
                //gl.Color(255f, 255f, 0.0f);
            }
            gl.End();
            //Rectangulo 3 Verde
            gl.Translate(1.12f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);
            {
                gl.Vertex(-0.1f, 1.0f, 0.0);
                gl.Vertex(1.0f, 1.0f, 0.0f);
                gl.Vertex(1.0f, -1.0f, 0.0f);
                gl.Vertex(-0.1f, -1.0f, 0.0f);
                //gl.Color(0.0f, 255f, 0.0f);
            }
            gl.End();
            //Rectangulo 4 Azul
            gl.Translate(1.12f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);
            {
                gl.Vertex(-0.1f, 1.0f, 0.0);
                gl.Vertex(1.0f, 1.0f, 0.0f);
                gl.Vertex(1.0f, -1.0f, 0.0f);
                gl.Vertex(-0.1f, -1.0f, 0.0f);
                //gl.Color(0.0f, 0.0f, 255f);
            }
            gl.End();
            gl.Flush();
            //Triangulo
            /*gl.Translate(-1.5f, 0f, -6f);
            gl.Begin(OpenGL.GL_TRIANGLES);
            {
                gl.Vertex(1.0f, 1.0f, 0.0f);
                gl.Vertex(-1.0f, -1.0f, 0.0f);
                gl.Vertex(1.0f, -1.0f, 0.0f);
            }
            gl.End();*/

            //Cuadrado
            /*gl.Translate(3f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);
            {
                gl.Vertex(-1.0f, 1.0f, 0.0);
                gl.Vertex(1.0f, 1.0f, 0.0f);
                gl.Vertex(1.0f, -1.0f, 0.0f);
                gl.Vertex(-1.0f, -1.0f, 0.0f);
            }
            gl.End();
            gl.Flush();*/
        }
    }
}
