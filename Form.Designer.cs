namespace Heavy_Metal_Player
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.randomPlayButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.intervalTimer = new System.Windows.Forms.Timer(this.components);
            this.updateRemainingTimer = new System.Windows.Forms.Timer(this.components);
            this.remainingLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.randomFromBox = new System.Windows.Forms.NumericUpDown();
            this.randomToBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomFromBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomToBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Play every";
            // 
            // intervalBox
            // 
            this.intervalBox.Location = new System.Drawing.Point(89, 12);
            this.intervalBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.intervalBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(75, 22);
            this.intervalBox.TabIndex = 2;
            this.intervalBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "seconds";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 68);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(93, 68);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // randomPlayButton
            // 
            this.randomPlayButton.Location = new System.Drawing.Point(236, 11);
            this.randomPlayButton.Name = "randomPlayButton";
            this.randomPlayButton.Size = new System.Drawing.Size(134, 23);
            this.randomPlayButton.TabIndex = 6;
            this.randomPlayButton.Text = "Play randomly";
            this.randomPlayButton.UseVisualStyleBackColor = true;
            this.randomPlayButton.Click += new System.EventHandler(this.randomPlayButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(295, 68);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 7;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // intervalTimer
            // 
            this.intervalTimer.Tick += new System.EventHandler(this.intervalTimer_Tick);
            // 
            // updateRemainingTimer
            // 
            this.updateRemainingTimer.Interval = 1000;
            this.updateRemainingTimer.Tick += new System.EventHandler(this.updateRemainingTimer_Tick);
            // 
            // remainingLabel
            // 
            this.remainingLabel.AutoSize = true;
            this.remainingLabel.Location = new System.Drawing.Point(174, 71);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(75, 16);
            this.remainingLabel.TabIndex = 8;
            this.remainingLabel.Text = "Remaining:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Random interval:";
            // 
            // randomFromBox
            // 
            this.randomFromBox.Location = new System.Drawing.Point(129, 111);
            this.randomFromBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.randomFromBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.randomFromBox.Name = "randomFromBox";
            this.randomFromBox.Size = new System.Drawing.Size(75, 22);
            this.randomFromBox.TabIndex = 10;
            this.randomFromBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // randomToBox
            // 
            this.randomToBox.Location = new System.Drawing.Point(252, 111);
            this.randomToBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.randomToBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.randomToBox.Name = "randomToBox";
            this.randomToBox.Size = new System.Drawing.Size(75, 22);
            this.randomToBox.TabIndex = 11;
            this.randomToBox.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "up to";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 143);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.randomToBox);
            this.Controls.Add(this.randomFromBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remainingLabel);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.randomPlayButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Heavy Metal Player";
            ((System.ComponentModel.ISupportInitialize)(this.intervalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomFromBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomToBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intervalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button randomPlayButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Timer intervalTimer;
        private System.Windows.Forms.Timer updateRemainingTimer;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown randomFromBox;
        private System.Windows.Forms.NumericUpDown randomToBox;
        private System.Windows.Forms.Label label4;
    }
}

