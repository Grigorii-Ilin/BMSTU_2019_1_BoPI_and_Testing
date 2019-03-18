namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btStart = new System.Windows.Forms.Button();
            this.tmOneMove = new System.Windows.Forms.Timer(this.components);
            this.lbXCoord = new System.Windows.Forms.Label();
            this.lbYCoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(655, 26);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 1;
            this.btStart.TabStop = false;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStartStop_Click);
            // 
            // tmOneMove
            // 
            this.tmOneMove.Interval = 40;
            this.tmOneMove.Tick += new System.EventHandler(this.tmSquareMove_Tick);
            // 
            // lbXCoord
            // 
            this.lbXCoord.AutoSize = true;
            this.lbXCoord.Location = new System.Drawing.Point(687, 79);
            this.lbXCoord.Name = "lbXCoord";
            this.lbXCoord.Size = new System.Drawing.Size(0, 13);
            this.lbXCoord.TabIndex = 1;
            // 
            // lbYCoord
            // 
            this.lbYCoord.AutoSize = true;
            this.lbYCoord.Location = new System.Drawing.Point(690, 105);
            this.lbYCoord.Name = "lbYCoord";
            this.lbYCoord.Size = new System.Drawing.Size(0, 13);
            this.lbYCoord.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbYCoord);
            this.Controls.Add(this.lbXCoord);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Двигающийся квадрат";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer tmOneMove;
        private System.Windows.Forms.Label lbXCoord;
        private System.Windows.Forms.Label lbYCoord;
    }
}

