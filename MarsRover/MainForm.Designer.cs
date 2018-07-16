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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.labelInputFile = new System.Windows.Forms.Label();
            this.openInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.graphicsScaleInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.roverColorDialog = new System.Windows.Forms.ColorDialog();
            this.roverDirectionColorDialog = new System.Windows.Forms.ColorDialog();
            this.plateauColorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonColors = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsScaleInput)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(697, 697);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // animationSpeedInput
            // 
            this.animationSpeedInput.Location = new System.Drawing.Point(12, 730);
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
            this.animationSpeedInput.Size = new System.Drawing.Size(106, 20);
            this.animationSpeedInput.TabIndex = 1;
            this.animationSpeedInput.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.animationSpeedInput.ValueChanged += new System.EventHandler(this.animationSpeedInput_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 714);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Animation Speed (ms)";
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(650, 727);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowseFile.TabIndex = 3;
            this.buttonBrowseFile.Text = "...";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Location = new System.Drawing.Point(359, 729);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.Size = new System.Drawing.Size(285, 20);
            this.textBoxInputFile.TabIndex = 4;
            // 
            // labelInputFile
            // 
            this.labelInputFile.AutoSize = true;
            this.labelInputFile.Location = new System.Drawing.Point(359, 713);
            this.labelInputFile.Name = "labelInputFile";
            this.labelInputFile.Size = new System.Drawing.Size(50, 13);
            this.labelInputFile.TabIndex = 5;
            this.labelInputFile.Text = "Input File";
            // 
            // openInputFileDialog
            // 
            this.openInputFileDialog.FileName = "openInputFileDialog";
            // 
            // graphicsScaleInput
            // 
            this.graphicsScaleInput.Location = new System.Drawing.Point(134, 730);
            this.graphicsScaleInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.graphicsScaleInput.Name = "graphicsScaleInput";
            this.graphicsScaleInput.Size = new System.Drawing.Size(76, 20);
            this.graphicsScaleInput.TabIndex = 6;
            this.graphicsScaleInput.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 713);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Graphics Scale";
            // 
            // roverColorDialog
            // 
            this.roverColorDialog.Color = System.Drawing.Color.DarkOrange;
            // 
            // buttonColors
            // 
            this.buttonColors.Location = new System.Drawing.Point(697, 726);
            this.buttonColors.Name = "buttonColors";
            this.buttonColors.Size = new System.Drawing.Size(75, 23);
            this.buttonColors.TabIndex = 8;
            this.buttonColors.Text = "Colors";
            this.buttonColors.UseVisualStyleBackColor = true;
            this.buttonColors.Click += new System.EventHandler(this.buttonColors_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.Color.Maroon;
            this.errorText.Location = new System.Drawing.Point(237, 688);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 13);
            this.errorText.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.buttonColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.graphicsScaleInput);
            this.Controls.Add(this.labelInputFile);
            this.Controls.Add(this.textBoxInputFile);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animationSpeedInput);
            this.Controls.Add(this.buttonStart);
            this.Name = "MainForm";
            this.Text = "MarsRover";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsScaleInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown animationSpeedInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.Label labelInputFile;
        private System.Windows.Forms.OpenFileDialog openInputFileDialog;
        private System.Windows.Forms.NumericUpDown graphicsScaleInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog roverColorDialog;
        private System.Windows.Forms.ColorDialog roverDirectionColorDialog;
        private System.Windows.Forms.ColorDialog plateauColorDialog;
        private System.Windows.Forms.Button buttonColors;
        private System.Windows.Forms.Label errorText;
    }
}

