using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Flappy_Bird
{
    internal class Bird: PictureBox
    {
        private GameWindows parent;
        public int speed;

        public Task taskMovingBird { get; set; }
        public delegate void DelegateMoveBird();
        public DelegateMoveBird delegateMoveBird { get; set; }
        public bool shouldMoveUp { get; set; }


        public Bird(GameWindows parent)
        {
            this.parent = parent;

            Image = Properties.Resources.Bird;
            Size = new Size(40, 40);
            SizeMode = PictureBoxSizeMode.StretchImage;
            Location = new Point(60, 40);

            speed = 10;

            this.parent.Controls.Add(this);

            shouldMoveUp = false;
            taskMovingBird = new Task(MovingBird);
            delegateMoveBird = new DelegateMoveBird(moveDown);
            taskMovingBird.Start();
        }

        public void moveDown()
        {
            
            if (shouldMoveUp) Top -= (speed / 2);
            else Top += speed;

            if (hasDie())
            {
                parent.gameOver = true;
            }

        }

        public bool hasDie()
        {
            //TODO: Vérifier si il c'est cogné avec son parent ou un poteau du parent
            foreach (Control control in parent.gamePage.Controls)
            {
                if (control.Tag == parent.pipe1.Tag || control == parent.ground)
                {
                    if (Bounds.IntersectsWith(control.Bounds) )
                        return true;
                }
            }

            if (Top < 0) return true;
            
            return false;
        }

        public void MovingBird()
        {
            Thread.Sleep(1500);

            while (true)
            {
                try
                {
                    parent.Invoke(delegateMoveBird);

                }
                catch (Exception) { }

                Thread.Sleep(200);
            }
        }
    }
}
