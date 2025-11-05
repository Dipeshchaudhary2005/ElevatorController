using System;

namespace ElevatorController
{
    partial class ElevatorGui
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_up = new System.Windows.Forms.Timer(this.components);
            this.timer_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_down = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteLogs = new System.Windows.Forms.Button();
            this.panelFloorIndicator = new System.Windows.Forms.Panel();
            this.lblFloorIndicator = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btn1Floor = new System.Windows.Forms.Button();
            this.btnGFloor = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.doorRightdown = new System.Windows.Forms.PictureBox();
            this.doorRightup = new System.Windows.Forms.PictureBox();
            this.doorLeftdown = new System.Windows.Forms.PictureBox();
            this.doorLeftup = new System.Windows.Forms.PictureBox();
            this.pictureElevator = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFloorIndicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRightdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRightup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeftdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeftup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_up
            // 
            this.timer_up.Interval = 10;
            this.timer_up.Tick += new System.EventHandler(this.timer_up_Tick);
            // 
            // timer_down
            // 
            this.timer_down.Interval = 10;
            this.timer_down.Tick += new System.EventHandler(this.timer_down_Tick);
            // 
            // timer_door_open_up
            // 
            this.timer_door_open_up.Interval = 5;
            this.timer_door_open_up.Tick += new System.EventHandler(this.timer_door_open_up_Tick);
            // 
            // timer_door_close_up
            // 
            this.timer_door_close_up.Interval = 5;
            this.timer_door_close_up.Tick += new System.EventHandler(this.timer_door_close_up_Tick);
            // 
            // timer_door_open_down
            // 
            this.timer_door_open_down.Interval = 5;
            this.timer_door_open_down.Tick += new System.EventHandler(this.timer_door_open_down_Tick);
            // 
            // timer_door_close_down
            // 
            this.timer_door_close_down.Interval = 5;
            this.timer_door_close_down.Tick += new System.EventHandler(this.timer_door_close_down_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(891, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(729, 640);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(891, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Elevator Action Logs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 466);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ground Floor";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1513, 714);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 52);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteLogs
            // 
            this.btnDeleteLogs.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLogs.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLogs.Location = new System.Drawing.Point(891, 714);
            this.btnDeleteLogs.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteLogs.Name = "btnDeleteLogs";
            this.btnDeleteLogs.Size = new System.Drawing.Size(173, 52);
            this.btnDeleteLogs.TabIndex = 24;
            this.btnDeleteLogs.Text = "Delete Logs";
            this.btnDeleteLogs.UseVisualStyleBackColor = false;
            this.btnDeleteLogs.Click += new System.EventHandler(this.btnDeleteLogs_Click);
            // 
            // panelFloorIndicator
            // 
            this.panelFloorIndicator.BackColor = System.Drawing.Color.Black;
            this.panelFloorIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFloorIndicator.Controls.Add(this.lblFloorIndicator);
            this.panelFloorIndicator.Location = new System.Drawing.Point(705, 310);
            this.panelFloorIndicator.Margin = new System.Windows.Forms.Padding(4);
            this.panelFloorIndicator.Name = "panelFloorIndicator";
            this.panelFloorIndicator.Size = new System.Drawing.Size(115, 80);
            this.panelFloorIndicator.TabIndex = 25;
            // 
            // lblFloorIndicator
            // 
            this.lblFloorIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFloorIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorIndicator.ForeColor = System.Drawing.Color.Lime;
            this.lblFloorIndicator.Location = new System.Drawing.Point(0, 0);
            this.lblFloorIndicator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloorIndicator.Name = "lblFloorIndicator";
            this.lblFloorIndicator.Size = new System.Drawing.Size(113, 78);
            this.lblFloorIndicator.TabIndex = 0;
            this.lblFloorIndicator.Text = "G";
            this.lblFloorIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.White;
            this.btnDown.Image = global::CtrlElevator.Properties.Resources.elevatordown;
            this.btnDown.Location = new System.Drawing.Point(492, 622);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(68, 60);
            this.btnDown.TabIndex = 15;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::CtrlElevator.Properties.Resources.elevator_panel;
            this.pictureBox9.Location = new System.Drawing.Point(479, 593);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(92, 113);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.Image = global::CtrlElevator.Properties.Resources.elevatorup;
            this.btnUp.Location = new System.Drawing.Point(492, 197);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(65, 58);
            this.btnUp.TabIndex = 14;
            this.btnUp.TabStop = false;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btn1Floor
            // 
            this.btn1Floor.BackColor = System.Drawing.Color.White;
            this.btn1Floor.Image = global::CtrlElevator.Properties.Resources._1_btn_image;
            this.btn1Floor.Location = new System.Drawing.Point(732, 416);
            this.btn1Floor.Margin = new System.Windows.Forms.Padding(4);
            this.btn1Floor.Name = "btn1Floor";
            this.btn1Floor.Size = new System.Drawing.Size(67, 60);
            this.btn1Floor.TabIndex = 13;
            this.btn1Floor.UseVisualStyleBackColor = false;
            this.btn1Floor.Click += new System.EventHandler(this.btn1Floor_Click);
            // 
            // btnGFloor
            // 
            this.btnGFloor.BackColor = System.Drawing.Color.White;
            this.btnGFloor.Image = global::CtrlElevator.Properties.Resources.G_btn1;
            this.btnGFloor.Location = new System.Drawing.Point(732, 484);
            this.btnGFloor.Margin = new System.Windows.Forms.Padding(4);
            this.btnGFloor.Name = "btnGFloor";
            this.btnGFloor.Size = new System.Drawing.Size(67, 60);
            this.btnGFloor.TabIndex = 12;
            this.btnGFloor.UseVisualStyleBackColor = false;
            this.btnGFloor.Click += new System.EventHandler(this.btnGFloor_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::CtrlElevator.Properties.Resources.open;
            this.btnOpen.Location = new System.Drawing.Point(767, 566);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(53, 49);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::CtrlElevator.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(705, 566);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 49);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CtrlElevator.Properties.Resources.elevator_panel;
            this.pictureBox8.Location = new System.Drawing.Point(479, 171);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(88, 105);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CtrlElevator.Properties.Resources.elevator_panel;
            this.pictureBox7.Location = new System.Drawing.Point(680, 281);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(164, 350);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // doorRightdown
            // 
            this.doorRightdown.Image = global::CtrlElevator.Properties.Resources.elevatordoor2;
            this.doorRightdown.Location = new System.Drawing.Point(339, 530);
            this.doorRightdown.Margin = new System.Windows.Forms.Padding(4);
            this.doorRightdown.Name = "doorRightdown";
            this.doorRightdown.Size = new System.Drawing.Size(132, 263);
            this.doorRightdown.TabIndex = 6;
            this.doorRightdown.TabStop = false;
            this.doorRightdown.Click += new System.EventHandler(this.doorRightdown_Click);
            // 
            // doorRightup
            // 
            this.doorRightup.Image = global::CtrlElevator.Properties.Resources.elevatordoor2;
            this.doorRightup.Location = new System.Drawing.Point(339, 101);
            this.doorRightup.Margin = new System.Windows.Forms.Padding(4);
            this.doorRightup.Name = "doorRightup";
            this.doorRightup.Size = new System.Drawing.Size(132, 263);
            this.doorRightup.TabIndex = 5;
            this.doorRightup.TabStop = false;
            this.doorRightup.Click += new System.EventHandler(this.doorRightup_Click);
            // 
            // doorLeftdown
            // 
            this.doorLeftdown.Image = global::CtrlElevator.Properties.Resources.elevatordoor1;
            this.doorLeftdown.Location = new System.Drawing.Point(199, 530);
            this.doorLeftdown.Margin = new System.Windows.Forms.Padding(4);
            this.doorLeftdown.Name = "doorLeftdown";
            this.doorLeftdown.Size = new System.Drawing.Size(144, 263);
            this.doorLeftdown.TabIndex = 3;
            this.doorLeftdown.TabStop = false;
            this.doorLeftdown.Click += new System.EventHandler(this.doorLeftdown_Click);
            // 
            // doorLeftup
            // 
            this.doorLeftup.Image = global::CtrlElevator.Properties.Resources.elevatordoor1;
            this.doorLeftup.Location = new System.Drawing.Point(200, 101);
            this.doorLeftup.Margin = new System.Windows.Forms.Padding(4);
            this.doorLeftup.Name = "doorLeftup";
            this.doorLeftup.Size = new System.Drawing.Size(143, 263);
            this.doorLeftup.TabIndex = 1;
            this.doorLeftup.TabStop = false;
            this.doorLeftup.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureElevator
            // 
            this.pictureElevator.Image = global::CtrlElevator.Properties.Resources.elevator1;
            this.pictureElevator.Location = new System.Drawing.Point(200, 530);
            this.pictureElevator.Margin = new System.Windows.Forms.Padding(4);
            this.pictureElevator.Name = "pictureElevator";
            this.pictureElevator.Size = new System.Drawing.Size(271, 263);
            this.pictureElevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureElevator.TabIndex = 0;
            this.pictureElevator.TabStop = false;
            this.pictureElevator.Click += new System.EventHandler(this.pictureElevator_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CtrlElevator.Properties.Resources.abc;
            this.pictureBox1.Location = new System.Drawing.Point(49, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CtrlElevator.Properties.Resources.abc;
            this.pictureBox2.Location = new System.Drawing.Point(49, 423);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(581, 469);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ElevatorGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 1055);
            this.Controls.Add(this.panelFloorIndicator);
            this.Controls.Add(this.btnDeleteLogs);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btn1Floor);
            this.Controls.Add(this.btnGFloor);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.doorRightdown);
            this.Controls.Add(this.doorRightup);
            this.Controls.Add(this.doorLeftdown);
            this.Controls.Add(this.doorLeftup);
            this.Controls.Add(this.pictureElevator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ElevatorGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator Control System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFloorIndicator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRightdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRightup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeftdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeftup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureElevator;
        private System.Windows.Forms.PictureBox doorLeftup;
        private System.Windows.Forms.PictureBox doorLeftdown;
        private System.Windows.Forms.PictureBox doorRightup;
        private System.Windows.Forms.PictureBox doorRightdown;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGFloor;
        private System.Windows.Forms.Button btn1Floor;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Timer timer_up;
        private System.Windows.Forms.Timer timer_down;
        private System.Windows.Forms.Timer timer_door_open_up;
        private System.Windows.Forms.Timer timer_door_close_up;
        private System.Windows.Forms.Timer timer_door_open_down;
        private System.Windows.Forms.Timer timer_door_close_down;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteLogs;
        private System.Windows.Forms.Panel panelFloorIndicator;
        private System.Windows.Forms.Label lblFloorIndicator;
    }

}