namespace TurboRaceGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblSub = new Label();
            lblPlayer = new Label();
            txtName = new TextBox();
            lblSelect = new Label();
            cmbVehicle = new ComboBox();
            gbInfo = new GroupBox();
            lblPower = new Label();
            lblMax = new Label();
            lblCurrent = new Label();
            lblInit = new Label();
            lblVName = new Label();
            lblCap5 = new Label();
            lblCap4 = new Label();
            lblCap3 = new Label();
            lblCap2 = new Label();
            lblCap1 = new Label();
            btnStart = new Button();
            btnAccel = new Button();
            btnPower = new Button();
            btnBrake = new Button();
            btnRestart = new Button();
            btnReset = new Button();
            gbTrack = new GroupBox();
            bar = new ProgressBar();
            lblDistance = new Label();
            track = new Panel();
            car = new Label();
            lblFinish = new Label();
            lblStart = new Label();
            road = new Panel();
            gbLog = new GroupBox();
            lstLog = new ListBox();
            timer = new System.Windows.Forms.Timer(components);
            gbInfo.SuspendLayout();
            gbTrack.SuspendLayout();
            track.SuspendLayout();
            gbLog.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Consolas", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(0, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(900, 30);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "TURBO RACE GARAGE";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSub
            // 
            lblSub.ForeColor = Color.White;
            lblSub.Location = new Point(0, 38);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(900, 22);
            lblSub.TabIndex = 13;
            lblSub.Text = "Runtime Polymorphism Game";
            lblSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayer
            // 
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(15, 78);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(110, 22);
            lblPlayer.TabIndex = 12;
            lblPlayer.Text = "Player Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 75);
            txtName.MaxLength = 25;
            txtName.Name = "txtName";
            txtName.Size = new Size(305, 33);
            txtName.TabIndex = 11;
            // 
            // lblSelect
            // 
            lblSelect.ForeColor = Color.White;
            lblSelect.Location = new Point(15, 113);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(110, 22);
            lblSelect.TabIndex = 10;
            lblSelect.Text = "Select Vehicle:";
            // 
            // cmbVehicle
            // 
            cmbVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Items.AddRange(new object[] { "Sports Car", "Motorbike", "Monster Truck", "Electric Car" });
            cmbVehicle.Location = new Point(130, 110);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(305, 33);
            cmbVehicle.TabIndex = 9;
            cmbVehicle.SelectedIndexChanged += cmbVehicle_SelectedIndexChanged;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lblPower);
            gbInfo.Controls.Add(lblMax);
            gbInfo.Controls.Add(lblCurrent);
            gbInfo.Controls.Add(lblInit);
            gbInfo.Controls.Add(lblVName);
            gbInfo.Controls.Add(lblCap5);
            gbInfo.Controls.Add(lblCap4);
            gbInfo.Controls.Add(lblCap3);
            gbInfo.Controls.Add(lblCap2);
            gbInfo.Controls.Add(lblCap1);
            gbInfo.ForeColor = Color.Cyan;
            gbInfo.Location = new Point(15, 148);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(420, 150);
            gbInfo.TabIndex = 8;
            gbInfo.TabStop = false;
            gbInfo.Text = "Vehicle Information";
            // 
            // lblPower
            // 
            lblPower.ForeColor = Color.White;
            lblPower.Location = new Point(145, 120);
            lblPower.Name = "lblPower";
            lblPower.Size = new Size(265, 22);
            lblPower.TabIndex = 0;
            // 
            // lblMax
            // 
            lblMax.ForeColor = Color.White;
            lblMax.Location = new Point(145, 96);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(265, 22);
            lblMax.TabIndex = 1;
            // 
            // lblCurrent
            // 
            lblCurrent.ForeColor = Color.White;
            lblCurrent.Location = new Point(145, 72);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(265, 22);
            lblCurrent.TabIndex = 2;
            // 
            // lblInit
            // 
            lblInit.ForeColor = Color.White;
            lblInit.Location = new Point(145, 48);
            lblInit.Name = "lblInit";
            lblInit.Size = new Size(265, 22);
            lblInit.TabIndex = 3;
            // 
            // lblVName
            // 
            lblVName.ForeColor = Color.White;
            lblVName.Location = new Point(145, 24);
            lblVName.Name = "lblVName";
            lblVName.Size = new Size(265, 22);
            lblVName.TabIndex = 4;
            // 
            // lblCap5
            // 
            lblCap5.ForeColor = Color.White;
            lblCap5.Location = new Point(12, 120);
            lblCap5.Name = "lblCap5";
            lblCap5.Size = new Size(130, 22);
            lblCap5.TabIndex = 5;
            lblCap5.Text = "Special Power:";
            // 
            // lblCap4
            // 
            lblCap4.ForeColor = Color.White;
            lblCap4.Location = new Point(12, 96);
            lblCap4.Name = "lblCap4";
            lblCap4.Size = new Size(130, 22);
            lblCap4.TabIndex = 6;
            lblCap4.Text = "Maximum Speed:";
            // 
            // lblCap3
            // 
            lblCap3.ForeColor = Color.White;
            lblCap3.Location = new Point(12, 72);
            lblCap3.Name = "lblCap3";
            lblCap3.Size = new Size(130, 22);
            lblCap3.TabIndex = 7;
            lblCap3.Text = "Current Speed:";
            // 
            // lblCap2
            // 
            lblCap2.ForeColor = Color.White;
            lblCap2.Location = new Point(12, 48);
            lblCap2.Name = "lblCap2";
            lblCap2.Size = new Size(130, 22);
            lblCap2.TabIndex = 8;
            lblCap2.Text = "Initial Speed:";
            // 
            // lblCap1
            // 
            lblCap1.ForeColor = Color.White;
            lblCap1.Location = new Point(12, 24);
            lblCap1.Name = "lblCap1";
            lblCap1.Size = new Size(130, 22);
            lblCap1.TabIndex = 9;
            lblCap1.Text = "Vehicle:";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.MidnightBlue;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(15, 312);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(99, 36);
            btnStart.TabIndex = 7;
            btnStart.Text = "START RACE";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnAccel
            // 
            btnAccel.BackColor = Color.MidnightBlue;
            btnAccel.FlatStyle = FlatStyle.Flat;
            btnAccel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnAccel.ForeColor = Color.White;
            btnAccel.Location = new Point(122, 312);
            btnAccel.Name = "btnAccel";
            btnAccel.Size = new Size(99, 36);
            btnAccel.TabIndex = 6;
            btnAccel.Text = "Acelerate";
            btnAccel.UseVisualStyleBackColor = false;
            btnAccel.Click += btnAccel_Click;
            // 
            // btnPower
            // 
            btnPower.BackColor = Color.MidnightBlue;
            btnPower.FlatStyle = FlatStyle.Flat;
            btnPower.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnPower.ForeColor = Color.White;
            btnPower.Location = new Point(229, 312);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(99, 36);
            btnPower.TabIndex = 5;
            btnPower.Text = "Power";
            btnPower.UseVisualStyleBackColor = false;
            btnPower.Click += btnPower_Click;
            // 
            // btnBrake
            // 
            btnBrake.BackColor = Color.MidnightBlue;
            btnBrake.FlatStyle = FlatStyle.Flat;
            btnBrake.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnBrake.ForeColor = Color.White;
            btnBrake.Location = new Point(336, 312);
            btnBrake.Name = "btnBrake";
            btnBrake.Size = new Size(99, 36);
            btnBrake.TabIndex = 4;
            btnBrake.Text = "BRAKE";
            btnBrake.UseVisualStyleBackColor = false;
            btnBrake.Click += btnBrake_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.MidnightBlue;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnRestart.ForeColor = Color.White;
            btnRestart.Location = new Point(15, 358);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(205, 36);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "RESTART RACE";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.MidnightBlue;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(230, 358);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(205, 36);
            btnReset.TabIndex = 2;
            btnReset.Text = "RESET GAME";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // gbTrack
            // 
            gbTrack.Controls.Add(bar);
            gbTrack.Controls.Add(lblDistance);
            gbTrack.Controls.Add(track);
            gbTrack.ForeColor = Color.Cyan;
            gbTrack.Location = new Point(450, 75);
            gbTrack.Name = "gbTrack";
            gbTrack.Size = new Size(435, 150);
            gbTrack.TabIndex = 1;
            gbTrack.TabStop = false;
            gbTrack.Text = "Race Track";
            // 
            // bar
            // 
            bar.Location = new Point(12, 118);
            bar.Name = "bar";
            bar.Size = new Size(410, 22);
            bar.TabIndex = 0;
            // 
            // lblDistance
            // 
            lblDistance.ForeColor = Color.White;
            lblDistance.Location = new Point(12, 92);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(410, 22);
            lblDistance.TabIndex = 1;
            // 
            // track
            // 
            track.BackColor = Color.DarkSlateGray;
            track.Controls.Add(car);
            track.Controls.Add(lblFinish);
            track.Controls.Add(lblStart);
            track.Controls.Add(road);
            track.Location = new Point(10, 20);
            track.Name = "track";
            track.Size = new Size(415, 64);
            track.TabIndex = 2;
            // 
            // car
            // 
            car.BackColor = Color.Crimson;
            car.ForeColor = Color.White;
            car.Location = new Point(55, 12);
            car.Name = "car";
            car.Size = new Size(40, 22);
            car.TabIndex = 0;
            car.Text = "car";
            car.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFinish
            // 
            lblFinish.ForeColor = Color.White;
            lblFinish.Location = new Point(340, 36);
            lblFinish.Name = "lblFinish";
            lblFinish.Size = new Size(62, 22);
            lblFinish.TabIndex = 1;
            lblFinish.Text = "Finish";
            // 
            // lblStart
            // 
            lblStart.ForeColor = Color.White;
            lblStart.Location = new Point(4, 36);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(50, 22);
            lblStart.TabIndex = 2;
            lblStart.Text = "Start";
            // 
            // road
            // 
            road.BackColor = Color.Gray;
            road.Location = new Point(55, 44);
            road.Name = "road";
            road.Size = new Size(305, 3);
            road.TabIndex = 3;
            // 
            // gbLog
            // 
            gbLog.Controls.Add(lstLog);
            gbLog.ForeColor = Color.Cyan;
            gbLog.Location = new Point(450, 235);
            gbLog.Name = "gbLog";
            gbLog.Size = new Size(435, 220);
            gbLog.TabIndex = 0;
            gbLog.TabStop = false;
            gbLog.Text = "Race Log";
            // 
            // lstLog
            // 
            lstLog.BackColor = Color.Black;
            lstLog.BorderStyle = BorderStyle.None;
            lstLog.ForeColor = Color.LightGreen;
            lstLog.FormattingEnabled = true;
            lstLog.HorizontalScrollbar = true;
            lstLog.IntegralHeight = false;
            lstLog.Location = new Point(10, 20);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(415, 190);
            lstLog.TabIndex = 0;
            // 
            // timer
            // 
            timer.Interval = 500;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(900, 480);
            Controls.Add(gbLog);
            Controls.Add(gbTrack);
            Controls.Add(btnReset);
            Controls.Add(btnRestart);
            Controls.Add(btnBrake);
            Controls.Add(btnPower);
            Controls.Add(btnAccel);
            Controls.Add(btnStart);
            Controls.Add(gbInfo);
            Controls.Add(cmbVehicle);
            Controls.Add(lblSelect);
            Controls.Add(txtName);
            Controls.Add(lblPlayer);
            Controls.Add(lblSub);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9.5F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TURBO RACE GARAGE - Runtime Polymorphism Game";
            Load += Form1_Load_1;
            gbInfo.ResumeLayout(false);
            gbTrack.ResumeLayout(false);
            track.ResumeLayout(false);
            gbLog.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblCap1;
        private System.Windows.Forms.Label lblCap2;
        private System.Windows.Forms.Label lblCap3;
        private System.Windows.Forms.Label lblCap4;
        private System.Windows.Forms.Label lblCap5;
        private System.Windows.Forms.Label lblVName;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAccel;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbTrack;
        private System.Windows.Forms.Panel track;
        private System.Windows.Forms.Panel road;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label car;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Timer timer;
    }
}