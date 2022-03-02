using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Flappy_Bird
{
    public class Pipe
    {

        public static void move(PictureBox pipe, GameWindows parent) 
        {
            pipe.Left -= 10;

            if (pipe.Left < 0)
            {
                if (parent != null)
                    pipe.Left = parent.Width;
            }
        }

    }
}
