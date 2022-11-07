namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl2 = new SharpGL.OpenGLControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameOverBG = new System.Windows.Forms.PictureBox();
            this.GameOverText = new System.Windows.Forms.Label();
            this.GameOverPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBG)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl2
            // 
            this.openGLControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl2.DrawFPS = true;
            this.openGLControl2.FrameRate = 60;
            this.openGLControl2.Location = new System.Drawing.Point(0, 0);
            this.openGLControl2.Name = "openGLControl2";
            this.openGLControl2.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL4_4;
            this.openGLControl2.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl2.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl2.Size = new System.Drawing.Size(1099, 555);
            this.openGLControl2.TabIndex = 0;
            this.openGLControl2.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl2_GDIDraw);
            this.openGLControl2.GDIDraw += new SharpGL.RenderEventHandler(this.openGLControl2_GDIDraw);
            this.openGLControl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.openGLControl2_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1015, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1018, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // GameOverBG
            // 
            this.GameOverBG.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.BG;
            this.GameOverBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameOverBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameOverBG.Location = new System.Drawing.Point(0, 0);
            this.GameOverBG.Name = "GameOverBG";
            this.GameOverBG.Size = new System.Drawing.Size(1099, 555);
            this.GameOverBG.TabIndex = 3;
            this.GameOverBG.TabStop = false;
            // 
            // GameOverText
            // 
            this.GameOverText.AutoSize = true;
            this.GameOverText.BackColor = System.Drawing.Color.Black;
            this.GameOverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverText.ForeColor = System.Drawing.Color.Red;
            this.GameOverText.Location = new System.Drawing.Point(345, 84);
            this.GameOverText.Name = "GameOverText";
            this.GameOverText.Size = new System.Drawing.Size(457, 76);
            this.GameOverText.TabIndex = 4;
            this.GameOverText.Text = "GAME OVER!";
            this.GameOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverPoints
            // 
            this.GameOverPoints.AutoSize = true;
            this.GameOverPoints.BackColor = System.Drawing.SystemColors.Desktop;
            this.GameOverPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverPoints.ForeColor = System.Drawing.Color.Red;
            this.GameOverPoints.Location = new System.Drawing.Point(248, 201);
            this.GameOverPoints.Name = "GameOverPoints";
            this.GameOverPoints.Size = new System.Drawing.Size(321, 63);
            this.GameOverPoints.TabIndex = 5;
            this.GameOverPoints.Text = "Your Points:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1099, 555);
            this.Controls.Add(this.GameOverPoints);
            this.Controls.Add(this.GameOverText);
            this.Controls.Add(this.GameOverBG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openGLControl2);
            this.KeyPreview = true;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private SharpGL.OpenGLControl openGLControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox GameOverBG;
        private System.Windows.Forms.Label GameOverText;
        private System.Windows.Forms.Label GameOverPoints;
    }
}

