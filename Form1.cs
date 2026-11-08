using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurboRaceGame
{

    public partial class Form1 : Form
    {
        const double TrackLength = 100.0;

        Vehicle vehicle = new SportsCar();   // ONE reference for all vehicle types
        bool raceRunning;
        double distance;

        public Form1()
        {
            InitializeComponent();

            // keep the readable gray look when a button is disabled
            foreach (Button b in new Button[] { btnStart, btnAccel, btnPower, btnBrake, btnRestart, btnReset })
            {
                Button btn = b;
                btn.EnabledChanged += delegate
                {
                    btn.BackColor = btn.Enabled ? Color.MidnightBlue : Color.FromArgb(200, 200, 205);
                };
            }

            cmbVehicle.SelectedIndex = 0;
            SelectVehicle();
            cmbVehicle.SelectedIndexChanged += delegate { SelectVehicle(); };

            SetRaceButtons(false);   // Accelerate / Power / Brake disabled until the race starts
            UpdateTrack();
        }

        // Kept in case Form1.Designer.cs refers to it
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Runtime polymorphism: the class is chosen while the program runs
        Vehicle CreateVehicle(string? type)
        {
            switch (type)
            {
                case "Motorbike": return new Motorbike();
                case "Monster Truck": return new MonsterTruck();
                case "Electric Car": return new ElectricCar();
                default: return new SportsCar();
            }
        }

        void SelectVehicle()
        {
            vehicle = CreateVehicle(cmbVehicle.SelectedItem?.ToString());
            UpdateInfo();
        }

        void UpdateInfo()
        {
            lblVName.Text = vehicle.Name;
            lblInit.Text = vehicle.InitialSpeed + " km/h";
            lblCurrent.Text = vehicle.CurrentSpeed + " km/h";
            lblMax.Text = vehicle.MaxSpeed + " km/h";
            lblPower.Text = vehicle.PowerDescription;
        }

        void UpdateTrack()
        {
            double d = Math.Min(distance, TrackLength);
            lblDistance.Text = "Distance Covered: " + Math.Round(d, 1) + " / " + TrackLength + " km";
            bar.Value = (int)d;
            int left = 55, right = track.Width - 95;
            car.Left = left + (int)((right - left) * d / TrackLength);
        }

        void Log(string msg)
        {
            lstLog.Items.Add(msg);
            lstLog.TopIndex = lstLog.Items.Count - 1;
        }

        void SetRaceButtons(bool on)
        {
            btnAccel.Enabled = on;
            btnPower.Enabled = on;
            btnBrake.Enabled = on;
        }

        // Starts a new race with the current name + selected vehicle
        void BeginRace(string player)
        {
            vehicle = CreateVehicle(cmbVehicle.SelectedItem?.ToString());
            distance = 0;
            lstLog.Items.Clear();
            Log(player + " selected " + vehicle.Name + ".");
            Log(vehicle.Start());

            raceRunning = true;
            txtName.Enabled = false;
            cmbVehicle.Enabled = false;
            btnStart.Enabled = false;
            SetRaceButtons(true);
            UpdateInfo();
            UpdateTrack();
            timer.Start();
        }

        // ---------------- events ----------------
        void btnStart_Click(object? s, EventArgs e)
        {
            string player = txtName.Text.Trim();
            if (player.Length == 0)
            {
                MessageBox.Show("Please enter your player name first.");
                txtName.Focus();
                return;
            }
            BeginRace(player);
        }

        // Restart: same player + same vehicle, new race immediately
        void btnRestart_Click(object? s, EventArgs e)
        {
            string player = txtName.Text.Trim();
            if (player.Length == 0)
            {
                MessageBox.Show("Please enter your player name first.");
                txtName.Focus();
                return;
            }
            timer.Stop();
            BeginRace(player);
        }

        void btnAccel_Click(object? s, EventArgs e)
        {
            if (!raceRunning) return;
            Log(vehicle.Drive());        // runtime polymorphism
            UpdateInfo();
        }

        void btnPower_Click(object? s, EventArgs e)
        {
            if (!raceRunning) return;
            Log(vehicle.UsePower());     // runtime polymorphism
            UpdateInfo();
        }

        void btnBrake_Click(object? s, EventArgs e)
        {
            if (!raceRunning) return;
            Log(vehicle.Brake());
            UpdateInfo();
        }

        void timer_Tick(object? s, EventArgs e)
        {
            if (!raceRunning) return;
            distance += vehicle.CurrentSpeed / 80.0;
            UpdateTrack();

            if (distance >= TrackLength)
            {
                raceRunning = false;
                timer.Stop();
                SetRaceButtons(false);

                // unlock so the player can change name / vehicle and race again
                txtName.Enabled = true;
                cmbVehicle.Enabled = true;
                btnStart.Enabled = true;

                string player = txtName.Text.Trim();
                Log(player + " finished the race with " + vehicle.Name + "!");

                DialogResult r = MessageBox.Show(
                    "Congratulations " + player + "! You finished the race with the " +
                    vehicle.Name + ".\n\nDo you want to play again?",
                    "Race Finished", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    BeginRace(player);
                }
            }
        }

        // Reset: clears everything, back to the start screen
        void btnReset_Click(object? s, EventArgs e)
        {
            timer.Stop();
            raceRunning = false;
            distance = 0;
            txtName.Clear();
            txtName.Enabled = true;
            cmbVehicle.Enabled = true;
            btnStart.Enabled = true;
            SetRaceButtons(false);
            cmbVehicle.SelectedIndex = 0;
            lstLog.Items.Clear();
            SelectVehicle();
            UpdateTrack();
        }

        private void cmbVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}