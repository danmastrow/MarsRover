namespace MarsRover
{
    partial class MainForm
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.animationSpeedInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedInput)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(697, 727);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // animationSpeedInput
            // 
            this.animationSpeedInput.Location = new System.Drawing.Point(618, 727);
            this.animationSpeedInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.animationSpeedInput.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.animationSpeedInput.Name = "animationSpeedInput";
            this.animationSpeedInput.Size = new System.Drawing.Size(73, 20);
            this.animationSpeedInput.TabIndex = 1;
            this.animationSpeedInput.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.animationSpeedInput.ValueChanged += new System.EventHandler(this.animationSpeedInput_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.animationSpeedInput);
            this.Controls.Add(this.buttonStart);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown animationSpeedInput;
    }
}

