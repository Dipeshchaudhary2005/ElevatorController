using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ElevatorController
{
    class DoorController
    {
        public void Timer_door_close_down(PictureBox doorLeftdown, PictureBox doorRightdown)
        {
            if (doorLeftdown.Left <= 150 && doorRightdown.Left >= 254)
            {
                doorLeftdown.Left += 1;
                doorRightdown.Left -= 1;
            }
        }

        public void Timer_door_close_up(PictureBox doorLeftup, PictureBox doorRightup)
        {
            if (doorLeftup.Left <= 150 && doorRightup.Left >= 254)
            {
                doorLeftup.Left += 1;
                doorRightup.Left -= 1;
            }
        }

        public void Timer_door_open_down(PictureBox doorLeftdown, PictureBox doorRightdown)
        {
            if (doorLeftdown.Left >= 51 && doorRightdown.Left <= 340)
            {
                doorLeftdown.Left -= 1;
                doorRightdown.Left += 1;
            }
        }

        public void Timer_door_open_up(PictureBox doorLeftup, PictureBox doorRightup)
        {
            if (doorLeftup.Left >= 50 && doorRightup.Left <= 340)
            {
                doorLeftup.Left -= 1;
                doorRightup.Left += 1;
            }
        }
    }
}
