namespace Pilots
{
    partial class Child
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
            this.btnStart = new System.Windows.Forms.Button();
            this.numbGame = new System.Windows.Forms.NumericUpDown();
            this.matrixNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numbGame)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(280, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Играть";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numbGame
            // 
            this.numbGame.Location = new System.Drawing.Point(182, 26);
            this.numbGame.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numbGame.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numbGame.Name = "numbGame";
            this.numbGame.Size = new System.Drawing.Size(75, 20);
            this.numbGame.TabIndex = 1;
            this.numbGame.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // matrixNumber
            // 
            this.matrixNumber.AutoSize = true;
            this.matrixNumber.Location = new System.Drawing.Point(36, 28);
            this.matrixNumber.Name = "matrixNumber";
            this.matrixNumber.Size = new System.Drawing.Size(122, 13);
            this.matrixNumber.TabIndex = 2;
            this.matrixNumber.Text = "Размер игрового поля";
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 419);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numbGame);
            this.Controls.Add(this.matrixNumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Child";
            this.Text = "Новая игра";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numbGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numbGame;
        private System.Windows.Forms.Label matrixNumber;

    }
}