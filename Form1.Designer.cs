namespace Flappy_Bird
{
    partial class GameWindows
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindows));
            this.GamePages = new System.Windows.Forms.TabControl();
            this.menuPage = new System.Windows.Forms.TabPage();
            this.buttonExit = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.gamePage = new System.Windows.Forms.TabPage();
            this.pipe4 = new System.Windows.Forms.PictureBox();
            this.pipe3 = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.GamePages.SuspendLayout();
            this.menuPage.SuspendLayout();
            this.gamePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // GamePages
            // 
            this.GamePages.Controls.Add(this.menuPage);
            this.GamePages.Controls.Add(this.gamePage);
            this.GamePages.Location = new System.Drawing.Point(-6, 1);
            this.GamePages.Name = "GamePages";
            this.GamePages.SelectedIndex = 0;
            this.GamePages.Size = new System.Drawing.Size(811, 498);
            this.GamePages.TabIndex = 0;
            this.GamePages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.GamePages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // menuPage
            // 
            this.menuPage.BackgroundImage = global::Flappy_Bird.Properties.Resources.Background;
            this.menuPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPage.Controls.Add(this.buttonExit);
            this.menuPage.Controls.Add(this.buttonStart);
            this.menuPage.Controls.Add(this.title);
            this.menuPage.Location = new System.Drawing.Point(4, 22);
            this.menuPage.Name = "menuPage";
            this.menuPage.Padding = new System.Windows.Forms.Padding(3);
            this.menuPage.Size = new System.Drawing.Size(803, 472);
            this.menuPage.TabIndex = 0;
            this.menuPage.Text = "menuPage";
            this.menuPage.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.buttonExit.Location = new System.Drawing.Point(357, 263);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 40);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Tag = "MainMenu";
            this.buttonExit.Text = "Exit";
            this.buttonExit.Click += new System.EventHandler(this.exitGame);
            this.buttonExit.MouseEnter += new System.EventHandler(this.handleMouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.handleMouseLeave);
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.buttonStart.Location = new System.Drawing.Point(295, 196);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(219, 40);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Tag = "MainMenu";
            this.buttonStart.Text = "Start Game";
            this.buttonStart.Click += new System.EventHandler(this.handleStartClicked);
            this.buttonStart.MouseEnter += new System.EventHandler(this.handleMouseEnter);
            this.buttonStart.MouseLeave += new System.EventHandler(this.handleMouseLeave);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Kunstler Script", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Yellow;
            this.title.Location = new System.Drawing.Point(176, 53);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(448, 104);
            this.title.TabIndex = 2;
            this.title.Tag = "MainMenu";
            this.title.Text = "Flappy Bird";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamePage
            // 
            this.gamePage.BackgroundImage = global::Flappy_Bird.Properties.Resources.Background;
            this.gamePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePage.Controls.Add(this.pipe4);
            this.gamePage.Controls.Add(this.pipe3);
            this.gamePage.Controls.Add(this.pipe2);
            this.gamePage.Controls.Add(this.pipe1);
            this.gamePage.Controls.Add(this.ground);
            this.gamePage.Location = new System.Drawing.Point(4, 22);
            this.gamePage.Name = "gamePage";
            this.gamePage.Padding = new System.Windows.Forms.Padding(3);
            this.gamePage.Size = new System.Drawing.Size(803, 472);
            this.gamePage.TabIndex = 1;
            this.gamePage.Text = "gamePage";
            this.gamePage.UseVisualStyleBackColor = true;
            // 
            // pipe4
            // 
            this.pipe4.Image = global::Flappy_Bird.Properties.Resources.PipeDown;
            this.pipe4.Location = new System.Drawing.Point(646, 340);
            this.pipe4.Name = "pipe4";
            this.pipe4.Size = new System.Drawing.Size(83, 78);
            this.pipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe4.TabIndex = 6;
            this.pipe4.TabStop = false;
            this.pipe4.Tag = "pipe";
            // 
            // pipe3
            // 
            this.pipe3.Image = global::Flappy_Bird.Properties.Resources.PipeUp;
            this.pipe3.Location = new System.Drawing.Point(646, 0);
            this.pipe3.Name = "pipe3";
            this.pipe3.Size = new System.Drawing.Size(83, 192);
            this.pipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe3.TabIndex = 5;
            this.pipe3.TabStop = false;
            this.pipe3.Tag = "pipe";
            // 
            // pipe2
            // 
            this.pipe2.Image = global::Flappy_Bird.Properties.Resources.PipeDown;
            this.pipe2.Location = new System.Drawing.Point(443, 253);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(100, 165);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2.TabIndex = 4;
            this.pipe2.TabStop = false;
            this.pipe2.Tag = "pipe";
            // 
            // pipe1
            // 
            this.pipe1.Image = global::Flappy_Bird.Properties.Resources.PipeUp;
            this.pipe1.Location = new System.Drawing.Point(253, 0);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(83, 192);
            this.pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1.TabIndex = 3;
            this.pipe1.TabStop = false;
            this.pipe1.Tag = "pipe";
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird.Properties.Resources.Ground;
            this.ground.Location = new System.Drawing.Point(-3, 418);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(810, 76);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // GameWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.GamePages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird - SterDevs";
            this.GamePages.ResumeLayout(false);
            this.menuPage.ResumeLayout(false);
            this.menuPage.PerformLayout();
            this.gamePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl GamePages;
        private System.Windows.Forms.TabPage menuPage;
        private System.Windows.Forms.Label buttonExit;
        private System.Windows.Forms.Label buttonStart;
        private System.Windows.Forms.Label title;
        public  System.Windows.Forms.TabPage gamePage;
        public System.Windows.Forms.PictureBox ground;
        public System.Windows.Forms.PictureBox pipe4;
        public System.Windows.Forms.PictureBox pipe3;
        public System.Windows.Forms.PictureBox pipe2;
        public System.Windows.Forms.PictureBox pipe1;
    }
}

