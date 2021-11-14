namespace SimpleScanningApp
{
    partial class ScanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanForm));
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonA5 = new System.Windows.Forms.RadioButton();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.Interval = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Stop = new System.Windows.Forms.Panel();
            this.toPDF = new System.Windows.Forms.Panel();
            this.Run = new System.Windows.Forms.Panel();
            this.RunOne = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(562, 706);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 706);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 775);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonA5);
            this.panel3.Controls.Add(this.radioButton);
            this.panel3.Controls.Add(this.Interval);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 750);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 25);
            this.panel3.TabIndex = 2;
            // 
            // radioButtonA5
            // 
            this.radioButtonA5.AutoSize = true;
            this.radioButtonA5.Checked = true;
            this.radioButtonA5.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonA5.Location = new System.Drawing.Point(54, 0);
            this.radioButtonA5.Name = "radioButtonA5";
            this.radioButtonA5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButtonA5.Size = new System.Drawing.Size(54, 25);
            this.radioButtonA5.TabIndex = 3;
            this.radioButtonA5.TabStop = true;
            this.radioButtonA5.Text = "A5";
            this.radioButtonA5.UseVisualStyleBackColor = true;
            this.radioButtonA5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton.Location = new System.Drawing.Point(0, 0);
            this.radioButton.Name = "radioButton";
            this.radioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButton.Size = new System.Drawing.Size(54, 25);
            this.radioButton.TabIndex = 2;
            this.radioButton.Text = "A4";
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Interval
            // 
            this.Interval.Dock = System.Windows.Forms.DockStyle.Right;
            this.Interval.Location = new System.Drawing.Point(466, 0);
            this.Interval.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Interval.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(96, 22);
            this.Interval.TabIndex = 1;
            this.Interval.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Stop);
            this.panel2.Controls.Add(this.toPDF);
            this.panel2.Controls.Add(this.Run);
            this.panel2.Controls.Add(this.RunOne);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 44);
            this.panel2.TabIndex = 1;
            // 
            // Stop
            // 
            this.Stop.BackgroundImage = global::SimpleScanningApp.Properties.Resources.Stop;
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Stop.Dock = System.Windows.Forms.DockStyle.Left;
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(76, 0);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(38, 44);
            this.Stop.TabIndex = 3;
            this.Stop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stop_MouseClick);
            // 
            // toPDF
            // 
            this.toPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toPDF.BackgroundImage = global::SimpleScanningApp.Properties.Resources.pdf;
            this.toPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toPDF.Location = new System.Drawing.Point(507, 3);
            this.toPDF.Name = "toPDF";
            this.toPDF.Size = new System.Drawing.Size(52, 39);
            this.toPDF.TabIndex = 2;
            this.toPDF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toPDF_MouseClick);
            // 
            // Run
            // 
            this.Run.BackgroundImage = global::SimpleScanningApp.Properties.Resources.Run;
            this.Run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Run.Dock = System.Windows.Forms.DockStyle.Left;
            this.Run.Location = new System.Drawing.Point(38, 0);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(38, 44);
            this.Run.TabIndex = 1;
            this.Run.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Run_MouseClick);
            // 
            // RunOne
            // 
            this.RunOne.BackgroundImage = global::SimpleScanningApp.Properties.Resources.RunOne;
            this.RunOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RunOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.RunOne.Location = new System.Drawing.Point(0, 0);
            this.RunOne.Name = "RunOne";
            this.RunOne.Size = new System.Drawing.Size(38, 44);
            this.RunOne.TabIndex = 0;
            this.RunOne.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RunOne_MouseClick);
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 775);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Stop;
        private System.Windows.Forms.Panel toPDF;
        private System.Windows.Forms.Panel Run;
        private System.Windows.Forms.Panel RunOne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown Interval;
        private System.Windows.Forms.RadioButton radioButtonA5;
        private System.Windows.Forms.RadioButton radioButton;
    }
}