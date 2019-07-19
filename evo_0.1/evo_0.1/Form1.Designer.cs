namespace evo_0._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Stop = new System.Windows.Forms.Button();
            this.timerF = new System.Windows.Forms.Timer(this.components);
            this.crith = new System.Windows.Forms.PictureBox();
            this.food = new System.Windows.Forms.PictureBox();
            this.crit = new System.Windows.Forms.PictureBox();
            this.timerHunger = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(22, 13);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(22, 43);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // timerF
            // 
            this.timerF.Interval = 10;
            this.timerF.Tick += new System.EventHandler(this.timerF_Tick);
            // 
            // crith
            // 
            this.crith.Image = global::evo_0._1.Properties.Resources.crit_h;
            this.crith.Location = new System.Drawing.Point(215, 164);
            this.crith.Name = "crith";
            this.crith.Size = new System.Drawing.Size(90, 73);
            this.crith.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.crith.TabIndex = 4;
            this.crith.TabStop = false;
            this.crith.Visible = false;
            // 
            // food
            // 
            this.food.Image = global::evo_0._1.Properties.Resources.food;
            this.food.Location = new System.Drawing.Point(766, 702);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(27, 23);
            this.food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.food.TabIndex = 3;
            this.food.TabStop = false;
            this.food.Visible = false;
            // 
            // crit
            // 
            this.crit.Image = global::evo_0._1.Properties.Resources.crit0;
            this.crit.Location = new System.Drawing.Point(215, 164);
            this.crit.Name = "crit";
            this.crit.Size = new System.Drawing.Size(90, 73);
            this.crit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.crit.TabIndex = 0;
            this.crit.TabStop = false;
            // 
            // timerHunger
            // 
            this.timerHunger.Enabled = true;
            this.timerHunger.Interval = 5000;
            this.timerHunger.Tick += new System.EventHandler(this.timerHunger_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(479, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(793, 726);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crith);
            this.Controls.Add(this.food);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.crit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.crith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox crit;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.PictureBox food;
        private System.Windows.Forms.Timer timerF;
        private System.Windows.Forms.PictureBox crith;
        private System.Windows.Forms.Timer timerHunger;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

