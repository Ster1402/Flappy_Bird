using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Flappy_Bird
{
    public partial class GameWindows : Form
    {

        //Properties
        public bool gameStarted { get; set; }
        public bool gameOver { get; set; }
        public bool launch { get; set; }
        public Task taskGame { get; set; }
        public delegate void DelegateTaskGame();
        public DelegateTaskGame delegateTaskGame { get; set; }
        internal Bird bird { get; set; }


        public GameWindows()
        {
            InitializeComponent();
            gameStarted = false;
            launch = false;

            GamePages.TabPages.Remove(gamePage);

            taskGame = new Task(gameTask);
            delegateTaskGame = new DelegateTaskGame(ManageGame);

        }

        //Mouse Enter Event
        private void handleMouseEnter(object sender, EventArgs e)
        {
            //Change color
            ((Label)sender).ForeColor = Color.Brown;
        }
        //Mouse Leave Event
        private void handleMouseLeave(object sender, EventArgs e)
        {
            //Change color
            ((Label)sender).ForeColor = Color.FromArgb(253, 253, 253, 255);
        }

        private void exitGame(object sender, EventArgs e)
        {
            buttonExit.Cursor = Cursors.WaitCursor;
            Application.Exit();
        }


        //Start Game
        private void startGame()
        {
            gameStarted = true;
            gameOver = false;

            if (!launch)
            {
                bird = new Bird(this);

                gamePage.Controls.Add(bird);
                bird.BringToFront();

                taskGame.Start();

            }else
            {

            }

            bird.Location = new Point(20, 40);

            launch = true;

            GamePages.TabPages.Remove(menuPage);
            GamePages.TabPages.Add(gamePage);

        }

        private void handleStartClicked(object sender, EventArgs e)
        {
            startGame();
        }

        #region Task Game

        public void gameTask()
        {
            Thread.Sleep(1550);

            while (true)
            {
                try
                {

                    if (gameStarted)
                        Invoke(delegateTaskGame);

                }
                catch (Exception) { }
                
                Thread.Sleep(350);
            }
        }

        public void ManageGame()
        {
            if (gameOver)
            {
                //Game
                MessageBox.Show("Game Over");
            }
            else
            {
                foreach (Control pipe in gamePage.Controls)
                {
                    if (pipe.Tag == pipe1.Tag)
                        Pipe.move((PictureBox) pipe, this);
                }
            }
        }

        public void restartGame()
        {

        }
        public void stopGame()
        {

        }


        #endregion

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && gameStarted)
            {
                bird.shouldMoveUp = true;
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && gameStarted)
            {
                bird.shouldMoveUp = false;
            }
        }
    }
}
