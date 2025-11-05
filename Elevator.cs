using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ElevatorController
{
    class Elevator
    {
        public void Timer_up(PictureBox pictureElevator)
        {
            if (pictureElevator.Top >= 82)
            {
                pictureElevator.Top -= 1;
            }
        }

        public void Timer_down(PictureBox pictureElevator)
        {
            if (pictureElevator.Top <= 431)
            {
                pictureElevator.Top += 1;
            }
        }
    }
}
