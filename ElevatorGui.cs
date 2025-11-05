using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ElevatorController
{
    public partial class ElevatorGui : Form
    {
        bool go_down = false;
        bool go_up = false;
        bool arrive_G = false;
        bool arrive_1 = false;

        // Single DbCommand instance
        DbCommand dbcmd = new DbCommand();

        public ElevatorGui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Open database connection
                GlobalConnection.DbConnection();

                // Load logs into DataGridView at startup
                LoadData();

                // Set initial position (Ground Floor)
                arrive_G = true;
                arrive_1 = false;
                pictureElevator.Top = 431;

                // Initialize floor indicator to show "G"
                UpdateFloorIndicator("G");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to DB: " + ex.Message);
            }
        }

        // Method to update floor indicator display
        private void UpdateFloorIndicator(string floor)
        {
            lblFloorIndicator.Text = floor;
        }

        // Method to load logs into DataGridView
        public void LoadData()
        {
            try
            {
                DataTable dt = dbcmd.ViewActionLog();
                dataGridView1.DataSource = dt;

                // Auto-size columns for better display
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load logs: " + ex.Message);
            }
        }

        // Save log helper method and refresh grid
        private void SaveAndRefreshLog(string action)
        {
            try
            {
                dbcmd.SaveLog(action);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save log: " + ex.Message);
            }
        }

        // TIMER EVENTS - Elevator Movement
        private void timer_up_Tick(object sender, EventArgs e)
        {
            if (pictureElevator.Top >= 82)
            {
                Elevator eu = new Elevator();
                eu.Timer_up(pictureElevator);
            }
            else
            {
                timer_up.Enabled = false;
                SaveAndRefreshLog("Elevator arrived at First Floor");

                btnDown.Enabled = true;
                btnGFloor.Enabled = true;
                btnClose.Enabled = true;
                btnOpen.Enabled = true;
                btnUp.BackColor = Color.White;
                btn1Floor.BackColor = Color.White;

                timer_door_open_up.Enabled = true;
                timer_door_close_up.Enabled = false;
                arrive_1 = true;
                arrive_G = false;

                // Update floor indicator to show "1"
                UpdateFloorIndicator("1");
            }
        }

        private void timer_down_Tick(object sender, EventArgs e)
        {
            if (pictureElevator.Top <= 431)
            {
                Elevator ed = new Elevator();
                ed.Timer_down(pictureElevator);
            }
            else
            {
                timer_down.Enabled = false;
                SaveAndRefreshLog("Elevator arrived at Ground Floor");

                btnUp.Enabled = true;
                btn1Floor.Enabled = true;
                btnClose.Enabled = true;
                btnOpen.Enabled = true;
                btnDown.BackColor = Color.White;
                btnGFloor.BackColor = Color.White;

                timer_door_open_down.Enabled = true;
                timer_door_close_down.Enabled = false;
                arrive_G = true;
                arrive_1 = false;

                // Update floor indicator to show "G"
                UpdateFloorIndicator("G");
            }
        }

        // TIMER EVENTS - Door Operations
        private void timer_door_open_up_Tick(object sender, EventArgs e)
        {
            if (doorLeftup.Left >= 50 && doorRightup.Left <= 340)
            {
                DoorController dou = new DoorController();
                dou.Timer_door_open_up(doorLeftup, doorRightup);
            }
            else
            {
                timer_door_open_up.Enabled = false;
                SaveAndRefreshLog("First Floor Door Opened");

                btnDown.Enabled = true;
            }
        }

        private void timer_door_close_up_Tick(object sender, EventArgs e)
        {
            if (doorLeftup.Left <= 150 && doorRightup.Left >= 254)
            {
                DoorController dcu = new DoorController();
                dcu.Timer_door_close_up(doorLeftup, doorRightup);
            }
            else
            {
                timer_door_close_up.Enabled = false;
                SaveAndRefreshLog("First Floor Door Closed");

                if (go_up)
                {
                    timer_down.Enabled = true;
                    go_up = false;
                }
            }
        }

        private void timer_door_open_down_Tick(object sender, EventArgs e)
        {
            if (doorLeftdown.Left >= 51 && doorRightdown.Left <= 340)
            {
                DoorController dod = new DoorController();
                dod.Timer_door_open_down(doorLeftdown, doorRightdown);
            }
            else
            {
                timer_door_open_down.Enabled = false;
                SaveAndRefreshLog("Ground Floor Door Opened");
            }
        }

        private void timer_door_close_down_Tick(object sender, EventArgs e)
        {
            if (doorLeftdown.Left <= 150 && doorRightdown.Left >= 254)
            {
                DoorController dcd = new DoorController();
                dcd.Timer_door_close_down(doorLeftdown, doorRightdown);
            }
            else
            {
                timer_door_close_down.Enabled = false;
                SaveAndRefreshLog("Ground Floor Door Closed");

                if (go_down)
                {
                    timer_up.Enabled = true;
                    go_down = false;
                }
            }
        }

        // BUTTON EVENTS - Control Panel Inside Elevator
        private void btn1Floor_Click(object sender, EventArgs e)
        {
            if (!arrive_1) // Only move if not already on first floor
            {
                go_down = true;
                btn1Floor.BackColor = Color.Green;
                arrive_G = false;
                timer_door_close_down.Enabled = true;
                timer_door_open_down.Enabled = false;

                // Disable buttons during movement
                btn1Floor.Enabled = false;
                btnGFloor.Enabled = false;
            }
        }

        private void btnGFloor_Click(object sender, EventArgs e)
        {
            if (!arrive_G) // Only move if not already on ground floor
            {
                go_up = true;
                btnGFloor.BackColor = Color.Green;
                arrive_1 = false;
                timer_door_close_up.Enabled = true;
                timer_door_open_up.Enabled = false;

                // Disable buttons during movement
                btn1Floor.Enabled = false;
                btnGFloor.Enabled = false;
            }
        }

        // BUTTON EVENTS - Floor Request Buttons (Outside Elevator)
        private void btnUp_Click(object sender, EventArgs e)
        {
            // Request from Ground Floor to go UP to First Floor
            if (!arrive_1)
            {
                go_down = true; // Elevator needs to move up to first floor
                btnUp.BackColor = Color.Green;
                timer_door_close_down.Enabled = true;
                timer_door_open_down.Enabled = false;
                arrive_G = false;

                btnUp.Enabled = false;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            // Request from First Floor to go DOWN to Ground Floor
            if (!arrive_G)
            {
                go_up = true; // Elevator needs to close door first, then go down
                btnDown.BackColor = Color.Green;
                timer_door_close_up.Enabled = true;
                timer_door_open_up.Enabled = false;
                arrive_1 = false;

                btnDown.Enabled = false;
            }
        }

        // BUTTON EVENTS - Door Control
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (arrive_G)
            {
                timer_door_open_down.Enabled = true;
                timer_door_close_down.Enabled = false;
            }
            else if (arrive_1)
            {
                timer_door_open_up.Enabled = true;
                timer_door_close_up.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (arrive_G)
            {
                timer_door_close_down.Enabled = true;
                timer_door_open_down.Enabled = false;
            }
            else if (arrive_1)
            {
                timer_door_close_up.Enabled = true;
                timer_door_open_up.Enabled = false;
            }
        }

        // DELETE LOGS BUTTON
        private void btnDeleteLogs_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete all logs?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    dbcmd.DeleteAllLogs();
                    LoadData();
                    MessageBox.Show("All logs deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete logs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // EXIT BUTTON
        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalConnection.CloseConnection();
            this.Close();
        }

        // Empty event handlers for designer (no functionality needed)
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void doorLeftdown_Click(object sender, EventArgs e) { }
        private void doorRightup_Click(object sender, EventArgs e) { }
        private void pictureBox7_Click(object sender, EventArgs e) { }
        private void pictureBox9_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureElevator_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void doorRightdown_Click(object sender, EventArgs e)
        {

        }
    }
}