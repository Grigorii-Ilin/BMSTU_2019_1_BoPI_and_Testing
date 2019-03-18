namespace graph
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
            this.btOk = new System.Windows.Forms.Button();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.rbEndCircle = new System.Windows.Forms.RadioButton();
            this.rbStartCircle = new System.Windows.Forms.RadioButton();
            this.rbCreateWay = new System.Windows.Forms.RadioButton();
            this.rbDeleteCircle = new System.Windows.Forms.RadioButton();
            this.rbCreateCircle = new System.Windows.Forms.RadioButton();
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbWayLen = new System.Windows.Forms.Label();
            this.gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(953, 26);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.rbEndCircle);
            this.gbActions.Controls.Add(this.rbStartCircle);
            this.gbActions.Controls.Add(this.rbCreateWay);
            this.gbActions.Controls.Add(this.rbDeleteCircle);
            this.gbActions.Controls.Add(this.rbCreateCircle);
            this.gbActions.Location = new System.Drawing.Point(906, 73);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(161, 174);
            this.gbActions.TabIndex = 2;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Действия";
            // 
            // rbEndCircle
            // 
            this.rbEndCircle.AutoSize = true;
            this.rbEndCircle.Location = new System.Drawing.Point(6, 112);
            this.rbEndCircle.Name = "rbEndCircle";
            this.rbEndCircle.Size = new System.Drawing.Size(119, 17);
            this.rbEndCircle.TabIndex = 5;
            this.rbEndCircle.TabStop = true;
            this.rbEndCircle.Text = "Задать конец пути";
            this.rbEndCircle.UseVisualStyleBackColor = true;
            // 
            // rbStartCircle
            // 
            this.rbStartCircle.AutoSize = true;
            this.rbStartCircle.Location = new System.Drawing.Point(6, 89);
            this.rbStartCircle.Name = "rbStartCircle";
            this.rbStartCircle.Size = new System.Drawing.Size(124, 17);
            this.rbStartCircle.TabIndex = 4;
            this.rbStartCircle.TabStop = true;
            this.rbStartCircle.Text = "Задать начало пути";
            this.rbStartCircle.UseVisualStyleBackColor = true;
            // 
            // rbCreateWay
            // 
            this.rbCreateWay.AutoSize = true;
            this.rbCreateWay.Location = new System.Drawing.Point(7, 66);
            this.rbCreateWay.Name = "rbCreateWay";
            this.rbCreateWay.Size = new System.Drawing.Size(104, 17);
            this.rbCreateWay.TabIndex = 2;
            this.rbCreateWay.TabStop = true;
            this.rbCreateWay.Text = "Создать дорогу";
            this.rbCreateWay.UseVisualStyleBackColor = true;
            // 
            // rbDeleteCircle
            // 
            this.rbDeleteCircle.AutoSize = true;
            this.rbDeleteCircle.Location = new System.Drawing.Point(7, 43);
            this.rbDeleteCircle.Name = "rbDeleteCircle";
            this.rbDeleteCircle.Size = new System.Drawing.Size(93, 17);
            this.rbDeleteCircle.TabIndex = 1;
            this.rbDeleteCircle.TabStop = true;
            this.rbDeleteCircle.Text = "Удалить круг";
            this.rbDeleteCircle.UseVisualStyleBackColor = true;
            // 
            // rbCreateCircle
            // 
            this.rbCreateCircle.AutoSize = true;
            this.rbCreateCircle.Location = new System.Drawing.Point(7, 20);
            this.rbCreateCircle.Name = "rbCreateCircle";
            this.rbCreateCircle.Size = new System.Drawing.Size(92, 17);
            this.rbCreateCircle.TabIndex = 0;
            this.rbCreateCircle.TabStop = true;
            this.rbCreateCircle.Text = "Создать круг";
            this.rbCreateCircle.UseVisualStyleBackColor = true;
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Location = new System.Drawing.Point(943, 556);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(121, 13);
            this.lbAbout.TabIndex = 3;
            this.lbAbout.Text = "Ильин Г.Б. ИУ7-68Б(В)";
            // 
            // lbWayLen
            // 
            this.lbWayLen.AutoSize = true;
            this.lbWayLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWayLen.Location = new System.Drawing.Point(906, 293);
            this.lbWayLen.Name = "lbWayLen";
            this.lbWayLen.Size = new System.Drawing.Size(100, 20);
            this.lbWayLen.TabIndex = 4;
            this.lbWayLen.Text = "Длина пути:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 578);
            this.Controls.Add(this.lbWayLen);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.btOk);
            this.Name = "Form1";
            this.Text = "Алгоритм дейкстры";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.gbActions.ResumeLayout(false);
            this.gbActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.RadioButton rbEndCircle;
        private System.Windows.Forms.RadioButton rbStartCircle;
        private System.Windows.Forms.RadioButton rbCreateWay;
        private System.Windows.Forms.RadioButton rbDeleteCircle;
        private System.Windows.Forms.RadioButton rbCreateCircle;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbWayLen;
    }
}

