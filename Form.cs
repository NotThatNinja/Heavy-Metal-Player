using System;
using System.Media;

namespace Heavy_Metal_Player
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Random rand = new Random();
        private bool randomInterval = false;
        private int remainingTime = 0;

        public Form()
        {
            Icon = Properties.Resources.Icon;
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            randomInterval = false;
            int interval = (int)intervalBox.Value * 1000;
            remainingTime = interval / 1000;
            intervalTimer.Interval = interval;
            startTimer();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopTimer();
        }

        private void randomPlayButton_Click(object sender, EventArgs e)
        {
            randomInterval = true;
            intervalTimer.Interval = (int)randomFromBox.Value;
            startTimer();
        }

        private void startTimer()
        {
            intervalBox.Enabled = false;
            startButton.Enabled = false;
            randomPlayButton.Enabled = false;
            randomFromBox.Enabled = false;
            randomToBox.Enabled = false;
            stopButton.Enabled = true;

            updateRemainingTimer.Start();
            intervalTimer.Start();
        }

        private void stopTimer()
        {
            intervalTimer.Stop();
            updateRemainingTimer.Stop();
            remainingLabel.Text = "Remaining: 0";

            intervalBox.Enabled = true;
            stopButton.Enabled = false;
            randomPlayButton.Enabled = true;
            randomFromBox.Enabled = true;
            randomToBox.Enabled = true;
            startButton.Enabled = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void intervalTimer_Tick(object sender, EventArgs e)
        {
            if (randomInterval)
            {
                // Use a random interval from 1 second to 2 minutes
                int interval = rand.Next((int)randomFromBox.Value, (int)randomToBox.Value) * 1000;
                remainingTime = interval / 1000;
                intervalTimer.Interval = interval;
            }
            else
            {
                remainingTime = intervalTimer.Interval / 1000;
            }
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.MetalPipeFallingSoundEffect);
            soundPlayer.Play();
        }

        private void updateRemainingTimer_Tick(object sender, EventArgs e)
        {
            remainingTime -= 1;
            remainingLabel.Text = $"Remaining: {remainingTime}";
        }
    }
}
