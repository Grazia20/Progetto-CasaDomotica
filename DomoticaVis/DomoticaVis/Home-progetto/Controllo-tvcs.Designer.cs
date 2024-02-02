namespace Home_progetto
{
    partial class Controllo_tvcs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_OnOffTV = new System.Windows.Forms.Button();
            this.bt_volPiuTv = new System.Windows.Forms.Button();
            this.bt_volMenTv = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_2Tv = new System.Windows.Forms.Button();
            this.bt_3Tv = new System.Windows.Forms.Button();
            this.bt_4Tv = new System.Windows.Forms.Button();
            this.bt_5Tv = new System.Windows.Forms.Button();
            this.bt_6Tv = new System.Windows.Forms.Button();
            this.bt_7Tv = new System.Windows.Forms.Button();
            this.bt_8Tv = new System.Windows.Forms.Button();
            this.bt_9Tv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Display = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Display);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 165);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_OnOffTV);
            this.flowLayoutPanel1.Controls.Add(this.bt_volPiuTv);
            this.flowLayoutPanel1.Controls.Add(this.bt_volMenTv);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.bt_2Tv);
            this.flowLayoutPanel1.Controls.Add(this.bt_3Tv);
            this.flowLayoutPanel1.Controls.Add(this.bt_4Tv);
            this.flowLayoutPanel1.Controls.Add(this.bt_5Tv);
            this.flowLayoutPanel1.Controls.Add(this.bt_6Tv);
            this.flowLayoutPanel1.Controls.Add(this.bt_7Tv);
            this.flowLayoutPanel1.Controls.Add(this.bt_8Tv);
            this.flowLayoutPanel1.Controls.Add(this.bt_9Tv);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 197);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 291);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // bt_OnOffTV
            // 
            this.bt_OnOffTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OnOffTV.Location = new System.Drawing.Point(3, 3);
            this.bt_OnOffTV.Name = "bt_OnOffTV";
            this.bt_OnOffTV.Size = new System.Drawing.Size(109, 65);
            this.bt_OnOffTV.TabIndex = 0;
            this.bt_OnOffTV.Text = "ON";
            this.bt_OnOffTV.UseVisualStyleBackColor = true;
            this.bt_OnOffTV.Click += new System.EventHandler(this.bt_OnOffTV_Click);
            // 
            // bt_volPiuTv
            // 
            this.bt_volPiuTv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_volPiuTv.Location = new System.Drawing.Point(118, 3);
            this.bt_volPiuTv.Name = "bt_volPiuTv";
            this.bt_volPiuTv.Size = new System.Drawing.Size(109, 65);
            this.bt_volPiuTv.TabIndex = 5;
            this.bt_volPiuTv.Text = "+";
            this.bt_volPiuTv.UseVisualStyleBackColor = true;
            this.bt_volPiuTv.Click += new System.EventHandler(this.bt_volPiuTv_Click);
            // 
            // bt_volMenTv
            // 
            this.bt_volMenTv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_volMenTv.Location = new System.Drawing.Point(233, 3);
            this.bt_volMenTv.Name = "bt_volMenTv";
            this.bt_volMenTv.Size = new System.Drawing.Size(109, 65);
            this.bt_volMenTv.TabIndex = 6;
            this.bt_volMenTv.Text = "-";
            this.bt_volMenTv.UseVisualStyleBackColor = true;
            this.bt_volMenTv.Click += new System.EventHandler(this.bt_volMenTv_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_2Tv
            // 
            this.bt_2Tv.BackColor = System.Drawing.Color.Lime;
            this.bt_2Tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_2Tv.Location = new System.Drawing.Point(118, 74);
            this.bt_2Tv.Name = "bt_2Tv";
            this.bt_2Tv.Size = new System.Drawing.Size(109, 65);
            this.bt_2Tv.TabIndex = 4;
            this.bt_2Tv.Text = "2";
            this.bt_2Tv.UseVisualStyleBackColor = false;
            this.bt_2Tv.Click += new System.EventHandler(this.bt_2Tv_Click);
            // 
            // bt_3Tv
            // 
            this.bt_3Tv.BackColor = System.Drawing.Color.Blue;
            this.bt_3Tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_3Tv.Location = new System.Drawing.Point(233, 74);
            this.bt_3Tv.Name = "bt_3Tv";
            this.bt_3Tv.Size = new System.Drawing.Size(109, 65);
            this.bt_3Tv.TabIndex = 7;
            this.bt_3Tv.Text = "3";
            this.bt_3Tv.UseVisualStyleBackColor = false;
            this.bt_3Tv.Click += new System.EventHandler(this.bt_3Tv_Click);
            // 
            // bt_4Tv
            // 
            this.bt_4Tv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_4Tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_4Tv.Location = new System.Drawing.Point(3, 145);
            this.bt_4Tv.Name = "bt_4Tv";
            this.bt_4Tv.Size = new System.Drawing.Size(109, 65);
            this.bt_4Tv.TabIndex = 8;
            this.bt_4Tv.Text = "4";
            this.bt_4Tv.UseVisualStyleBackColor = false;
            this.bt_4Tv.Click += new System.EventHandler(this.bt_4Tv_Click);
            // 
            // bt_5Tv
            // 
            this.bt_5Tv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_5Tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_5Tv.Location = new System.Drawing.Point(118, 145);
            this.bt_5Tv.Name = "bt_5Tv";
            this.bt_5Tv.Size = new System.Drawing.Size(109, 65);
            this.bt_5Tv.TabIndex = 9;
            this.bt_5Tv.Text = "5";
            this.bt_5Tv.UseVisualStyleBackColor = false;
            this.bt_5Tv.Click += new System.EventHandler(this.bt_5Tv_Click);
            // 
            // bt_6Tv
            // 
            this.bt_6Tv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_6Tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_6Tv.Location = new System.Drawing.Point(233, 145);
            this.bt_6Tv.Name = "bt_6Tv";
            this.bt_6Tv.Size = new System.Drawing.Size(109, 65);
            this.bt_6Tv.TabIndex = 10;
            this.bt_6Tv.Text = "6";
            this.bt_6Tv.UseVisualStyleBackColor = false;
            this.bt_6Tv.Click += new System.EventHandler(this.bt_6Tv_Click);
            // 
            // bt_7Tv
            // 
            this.bt_7Tv.BackColor = System.Drawing.Color.Yellow;
            this.bt_7Tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_7Tv.Location = new System.Drawing.Point(3, 216);
            this.bt_7Tv.Name = "bt_7Tv";
            this.bt_7Tv.Size = new System.Drawing.Size(109, 65);
            this.bt_7Tv.TabIndex = 11;
            this.bt_7Tv.Text = "7";
            this.bt_7Tv.UseVisualStyleBackColor = false;
            this.bt_7Tv.Click += new System.EventHandler(this.bt_7Tv_Click);
            // 
            // bt_8Tv
            // 
            this.bt_8Tv.BackColor = System.Drawing.Color.Navy;
            this.bt_8Tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_8Tv.Location = new System.Drawing.Point(118, 216);
            this.bt_8Tv.Name = "bt_8Tv";
            this.bt_8Tv.Size = new System.Drawing.Size(109, 65);
            this.bt_8Tv.TabIndex = 12;
            this.bt_8Tv.Text = "8";
            this.bt_8Tv.UseVisualStyleBackColor = false;
            this.bt_8Tv.Click += new System.EventHandler(this.bt_8Tv_Click);
            // 
            // bt_9Tv
            // 
            this.bt_9Tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_9Tv.Location = new System.Drawing.Point(233, 216);
            this.bt_9Tv.Name = "bt_9Tv";
            this.bt_9Tv.Size = new System.Drawing.Size(109, 65);
            this.bt_9Tv.TabIndex = 13;
            this.bt_9Tv.Text = "9";
            this.bt_9Tv.UseVisualStyleBackColor = true;
            this.bt_9Tv.Click += new System.EventHandler(this.bt_9Tv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(363, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 31);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.PowderBlue;
            this.Display.Image = global::Home_progetto.Properties.Resources.volume_down;
            this.Display.Location = new System.Drawing.Point(3, 4);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(341, 159);
            this.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Display.TabIndex = 0;
            this.Display.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // Controllo_tvcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(100, 50);
            this.Name = "Controllo_tvcs";
            this.Text = "Controllo_tvcs";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_OnOffTV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt_2Tv;
        private System.Windows.Forms.PictureBox Display;
        private System.Windows.Forms.Button bt_volPiuTv;
        private System.Windows.Forms.Button bt_volMenTv;
        private System.Windows.Forms.Button bt_3Tv;
        private System.Windows.Forms.Button bt_4Tv;
        private System.Windows.Forms.Button bt_5Tv;
        private System.Windows.Forms.Button bt_6Tv;
        private System.Windows.Forms.Button bt_7Tv;
        private System.Windows.Forms.Button bt_8Tv;
        private System.Windows.Forms.Button bt_9Tv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}