namespace Home_progetto
{
    partial class home
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lb_setPoint;
            System.Windows.Forms.Label lb_statoAllarme;
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_impostazioni = new System.Windows.Forms.GroupBox();
            this.rbt_temaScuro = new System.Windows.Forms.RadioButton();
            this.rbt_temaChiaro = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Allarme = new System.Windows.Forms.GroupBox();
            this.lb_allarme = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gb_temp = new System.Windows.Forms.GroupBox();
            this.btn_Aggiorna = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.l_temp = new System.Windows.Forms.Label();
            this.l_umid = new System.Windows.Forms.Label();
            this.lb_temp = new System.Windows.Forms.Label();
            this.cirPro_temp = new CircularProgressBar.CircularProgressBar();
            this.lb_hum = new System.Windows.Forms.Label();
            this.cirPro_umi = new CircularProgressBar.CircularProgressBar();
            this.btn_LuceLetto = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_LuceStanza = new System.Windows.Forms.Button();
            this.btn_LuceBagno = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_tv = new System.Windows.Forms.PictureBox();
            this.pb_fan = new System.Windows.Forms.PictureBox();
            this.pb_lucchetto = new System.Windows.Forms.PictureBox();
            this.pb_LuceStanza = new System.Windows.Forms.PictureBox();
            this.pb_LuceLetto = new System.Windows.Forms.PictureBox();
            this.pb_LuceBagno = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            lb_setPoint = new System.Windows.Forms.Label();
            lb_statoAllarme = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gb_info.SuspendLayout();
            this.gb_impostazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.Allarme.SuspendLayout();
            this.gb_temp.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lucchetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LuceStanza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LuceLetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LuceBagno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_setPoint
            // 
            lb_setPoint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lb_setPoint.AutoSize = true;
            lb_setPoint.BackColor = System.Drawing.Color.Transparent;
            lb_setPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_setPoint.Location = new System.Drawing.Point(245, 123);
            lb_setPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_setPoint.Name = "lb_setPoint";
            lb_setPoint.Size = new System.Drawing.Size(151, 29);
            lb_setPoint.TabIndex = 28;
            lb_setPoint.Text = "SET POINT";
            // 
            // lb_statoAllarme
            // 
            lb_statoAllarme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lb_statoAllarme.AutoSize = true;
            lb_statoAllarme.BackColor = System.Drawing.Color.Transparent;
            lb_statoAllarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_statoAllarme.Location = new System.Drawing.Point(56, 69);
            lb_statoAllarme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_statoAllarme.Name = "lb_statoAllarme";
            lb_statoAllarme.Size = new System.Drawing.Size(223, 29);
            lb_statoAllarme.TabIndex = 33;
            lb_statoAllarme.Text = "STATO ALLARME";
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM5";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.gb_info);
            this.panel1.Controls.Add(this.gb_impostazioni);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 794);
            this.panel1.TabIndex = 13;
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.label9);
            this.gb_info.Controls.Add(this.label8);
            this.gb_info.Controls.Add(this.label7);
            this.gb_info.Controls.Add(this.label6);
            this.gb_info.Controls.Add(this.label5);
            this.gb_info.Controls.Add(this.label4);
            this.gb_info.Controls.Add(this.label3);
            this.gb_info.Controls.Add(this.label2);
            this.gb_info.Controls.Add(this.label1);
            this.gb_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_info.Location = new System.Drawing.Point(0, 287);
            this.gb_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_info.Name = "gb_info";
            this.gb_info.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_info.Size = new System.Drawing.Size(353, 363);
            this.gb_info.TabIndex = 2;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "Informazioni Casa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "- Televisione";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "- Luci";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "- Riscaldamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "- Allarme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Funzionalità:   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bagni : 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stanze : 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metratura : 30mq ";
            // 
            // gb_impostazioni
            // 
            this.gb_impostazioni.Controls.Add(this.rbt_temaScuro);
            this.gb_impostazioni.Controls.Add(this.rbt_temaChiaro);
            this.gb_impostazioni.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_impostazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_impostazioni.Location = new System.Drawing.Point(0, 650);
            this.gb_impostazioni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_impostazioni.Name = "gb_impostazioni";
            this.gb_impostazioni.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_impostazioni.Size = new System.Drawing.Size(353, 144);
            this.gb_impostazioni.TabIndex = 1;
            this.gb_impostazioni.TabStop = false;
            this.gb_impostazioni.Text = "Impostazioni tema";
            // 
            // rbt_temaScuro
            // 
            this.rbt_temaScuro.AutoSize = true;
            this.rbt_temaScuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_temaScuro.Location = new System.Drawing.Point(24, 63);
            this.rbt_temaScuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbt_temaScuro.Name = "rbt_temaScuro";
            this.rbt_temaScuro.Size = new System.Drawing.Size(100, 20);
            this.rbt_temaScuro.TabIndex = 1;
            this.rbt_temaScuro.TabStop = true;
            this.rbt_temaScuro.Text = "Tema scuro";
            this.rbt_temaScuro.UseVisualStyleBackColor = true;
            this.rbt_temaScuro.CheckedChanged += new System.EventHandler(this.rbt_temaScuro_CheckedChanged);
            // 
            // rbt_temaChiaro
            // 
            this.rbt_temaChiaro.AutoSize = true;
            this.rbt_temaChiaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_temaChiaro.Location = new System.Drawing.Point(24, 34);
            this.rbt_temaChiaro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbt_temaChiaro.Name = "rbt_temaChiaro";
            this.rbt_temaChiaro.Size = new System.Drawing.Size(104, 20);
            this.rbt_temaChiaro.TabIndex = 0;
            this.rbt_temaChiaro.TabStop = true;
            this.rbt_temaChiaro.Text = "Tema chiaro";
            this.rbt_temaChiaro.UseVisualStyleBackColor = true;
            this.rbt_temaChiaro.Click += new System.EventHandler(this.rbt_temaChiaro_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Home_progetto.Properties.Resources.arduino_logo;
            this.pictureBox2.Location = new System.Drawing.Point(36, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 251);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(435, 895);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 48);
            this.button4.TabIndex = 30;
            this.button4.Text = "Stato allarme";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.Allarme);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.gb_temp);
            this.panel3.Controls.Add(this.btn_LuceLetto);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.btn_LuceStanza);
            this.panel3.Controls.Add(this.btn_LuceBagno);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1060, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 794);
            this.panel3.TabIndex = 35;
            // 
            // Allarme
            // 
            this.Allarme.Controls.Add(this.lb_allarme);
            this.Allarme.Controls.Add(lb_statoAllarme);
            this.Allarme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Allarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allarme.Location = new System.Drawing.Point(0, 328);
            this.Allarme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Allarme.Name = "Allarme";
            this.Allarme.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Allarme.Size = new System.Drawing.Size(643, 160);
            this.Allarme.TabIndex = 35;
            this.Allarme.TabStop = false;
            this.Allarme.Text = "Allarme";
            // 
            // lb_allarme
            // 
            this.lb_allarme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_allarme.AutoSize = true;
            this.lb_allarme.BackColor = System.Drawing.Color.Lime;
            this.lb_allarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_allarme.Location = new System.Drawing.Point(405, 64);
            this.lb_allarme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_allarme.Name = "lb_allarme";
            this.lb_allarme.Size = new System.Drawing.Size(61, 36);
            this.lb_allarme.TabIndex = 33;
            this.lb_allarme.Text = "ON";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(415, 22);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 34;
            this.dateTimePicker2.Value = new System.DateTime(2023, 3, 30, 10, 23, 46, 0);
            // 
            // gb_temp
            // 
            this.gb_temp.Controls.Add(this.btn_Aggiorna);
            this.gb_temp.Controls.Add(this.textBox1);
            this.gb_temp.Controls.Add(this.l_temp);
            this.gb_temp.Controls.Add(lb_setPoint);
            this.gb_temp.Controls.Add(this.l_umid);
            this.gb_temp.Controls.Add(this.lb_temp);
            this.gb_temp.Controls.Add(this.cirPro_temp);
            this.gb_temp.Controls.Add(this.lb_hum);
            this.gb_temp.Controls.Add(this.cirPro_umi);
            this.gb_temp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_temp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_temp.Location = new System.Drawing.Point(0, 488);
            this.gb_temp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_temp.Name = "gb_temp";
            this.gb_temp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_temp.Size = new System.Drawing.Size(643, 306);
            this.gb_temp.TabIndex = 33;
            this.gb_temp.TabStop = false;
            this.gb_temp.Text = "Temperatura e Umidità";
            // 
            // btn_Aggiorna
            // 
            this.btn_Aggiorna.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Aggiorna.Location = new System.Drawing.Point(271, 199);
            this.btn_Aggiorna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Aggiorna.Name = "btn_Aggiorna";
            this.btn_Aggiorna.Size = new System.Drawing.Size(99, 46);
            this.btn_Aggiorna.TabIndex = 32;
            this.btn_Aggiorna.Text = "Aggiorna";
            this.btn_Aggiorna.UseVisualStyleBackColor = true;
            this.btn_Aggiorna.Click += new System.EventHandler(this.btn_Aggiorna_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(270, 167);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 29;
            // 
            // l_temp
            // 
            this.l_temp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_temp.AutoSize = true;
            this.l_temp.BackColor = System.Drawing.Color.Transparent;
            this.l_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_temp.Location = new System.Drawing.Point(33, 48);
            this.l_temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_temp.Name = "l_temp";
            this.l_temp.Size = new System.Drawing.Size(163, 29);
            this.l_temp.TabIndex = 8;
            this.l_temp.Text = "Temperatura";
            // 
            // l_umid
            // 
            this.l_umid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_umid.AutoSize = true;
            this.l_umid.BackColor = System.Drawing.Color.Transparent;
            this.l_umid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_umid.Location = new System.Drawing.Point(479, 48);
            this.l_umid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_umid.Name = "l_umid";
            this.l_umid.Size = new System.Drawing.Size(102, 29);
            this.l_umid.TabIndex = 9;
            this.l_umid.Text = "Umidità";
            // 
            // lb_temp
            // 
            this.lb_temp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_temp.AutoSize = true;
            this.lb_temp.BackColor = System.Drawing.Color.Transparent;
            this.lb_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_temp.Location = new System.Drawing.Point(77, 167);
            this.lb_temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(75, 29);
            this.lb_temp.TabIndex = 26;
            this.lb_temp.Text = "17 °C";
            // 
            // cirPro_temp
            // 
            this.cirPro_temp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cirPro_temp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cirPro_temp.AnimationSpeed = 500;
            this.cirPro_temp.BackColor = System.Drawing.Color.Transparent;
            this.cirPro_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cirPro_temp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirPro_temp.InnerColor = System.Drawing.SystemColors.Control;
            this.cirPro_temp.InnerMargin = 2;
            this.cirPro_temp.InnerWidth = -1;
            this.cirPro_temp.Location = new System.Drawing.Point(14, 89);
            this.cirPro_temp.Margin = new System.Windows.Forms.Padding(4);
            this.cirPro_temp.MarqueeAnimationSpeed = 2000;
            this.cirPro_temp.Name = "cirPro_temp";
            this.cirPro_temp.OuterColor = System.Drawing.Color.Bisque;
            this.cirPro_temp.OuterMargin = -25;
            this.cirPro_temp.OuterWidth = 26;
            this.cirPro_temp.ProgressColor = System.Drawing.Color.Red;
            this.cirPro_temp.ProgressWidth = 25;
            this.cirPro_temp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cirPro_temp.Size = new System.Drawing.Size(200, 185);
            this.cirPro_temp.StartAngle = 270;
            this.cirPro_temp.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPro_temp.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cirPro_temp.SubscriptText = "23";
            this.cirPro_temp.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPro_temp.SuperscriptMargin = new System.Windows.Forms.Padding(-1);
            this.cirPro_temp.SuperscriptText = "C°";
            this.cirPro_temp.TabIndex = 10;
            this.cirPro_temp.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cirPro_temp.Value = 68;
            // 
            // lb_hum
            // 
            this.lb_hum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_hum.AutoSize = true;
            this.lb_hum.BackColor = System.Drawing.Color.Transparent;
            this.lb_hum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hum.Location = new System.Drawing.Point(495, 167);
            this.lb_hum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_hum.Name = "lb_hum";
            this.lb_hum.Size = new System.Drawing.Size(71, 29);
            this.lb_hum.TabIndex = 27;
            this.lb_hum.Text = "35 %";
            // 
            // cirPro_umi
            // 
            this.cirPro_umi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cirPro_umi.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cirPro_umi.AnimationSpeed = 500;
            this.cirPro_umi.BackColor = System.Drawing.Color.Transparent;
            this.cirPro_umi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cirPro_umi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirPro_umi.InnerColor = System.Drawing.SystemColors.Control;
            this.cirPro_umi.InnerMargin = 2;
            this.cirPro_umi.InnerWidth = -1;
            this.cirPro_umi.Location = new System.Drawing.Point(430, 89);
            this.cirPro_umi.Margin = new System.Windows.Forms.Padding(4);
            this.cirPro_umi.MarqueeAnimationSpeed = 2000;
            this.cirPro_umi.Name = "cirPro_umi";
            this.cirPro_umi.OuterColor = System.Drawing.Color.Bisque;
            this.cirPro_umi.OuterMargin = -25;
            this.cirPro_umi.OuterWidth = 26;
            this.cirPro_umi.ProgressColor = System.Drawing.Color.Red;
            this.cirPro_umi.ProgressWidth = 25;
            this.cirPro_umi.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cirPro_umi.Size = new System.Drawing.Size(200, 185);
            this.cirPro_umi.StartAngle = 270;
            this.cirPro_umi.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPro_umi.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cirPro_umi.SubscriptText = "23";
            this.cirPro_umi.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPro_umi.SuperscriptMargin = new System.Windows.Forms.Padding(-1);
            this.cirPro_umi.SuperscriptText = "C°";
            this.cirPro_umi.TabIndex = 25;
            this.cirPro_umi.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cirPro_umi.Value = 68;
            // 
            // btn_LuceLetto
            // 
            this.btn_LuceLetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuceLetto.Location = new System.Drawing.Point(484, 95);
            this.btn_LuceLetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LuceLetto.Name = "btn_LuceLetto";
            this.btn_LuceLetto.Size = new System.Drawing.Size(141, 76);
            this.btn_LuceLetto.TabIndex = 22;
            this.btn_LuceLetto.Text = "Luce  Letto";
            this.btn_LuceLetto.UseVisualStyleBackColor = true;
            this.btn_LuceLetto.Click += new System.EventHandler(this.btn_LuceLetto_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-355, 11);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btn_LuceStanza
            // 
            this.btn_LuceStanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuceStanza.Location = new System.Drawing.Point(44, 95);
            this.btn_LuceStanza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LuceStanza.Name = "btn_LuceStanza";
            this.btn_LuceStanza.Size = new System.Drawing.Size(141, 76);
            this.btn_LuceStanza.TabIndex = 20;
            this.btn_LuceStanza.Text = "Luce Stanza";
            this.btn_LuceStanza.UseVisualStyleBackColor = true;
            this.btn_LuceStanza.Click += new System.EventHandler(this.btn_LuceStanza_Click);
            // 
            // btn_LuceBagno
            // 
            this.btn_LuceBagno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuceBagno.Location = new System.Drawing.Point(269, 95);
            this.btn_LuceBagno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LuceBagno.Name = "btn_LuceBagno";
            this.btn_LuceBagno.Size = new System.Drawing.Size(141, 76);
            this.btn_LuceBagno.TabIndex = 21;
            this.btn_LuceBagno.Text = "Luce Bagno";
            this.btn_LuceBagno.UseVisualStyleBackColor = true;
            this.btn_LuceBagno.Click += new System.EventHandler(this.btn_LuceBagno_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pb_tv);
            this.panel2.Controls.Add(this.pb_fan);
            this.panel2.Controls.Add(this.pb_lucchetto);
            this.panel2.Controls.Add(this.pb_LuceStanza);
            this.panel2.Controls.Add(this.pb_LuceLetto);
            this.panel2.Controls.Add(this.pb_LuceBagno);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(353, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 794);
            this.panel2.TabIndex = 36;
            // 
            // pb_tv
            // 
            this.pb_tv.BackColor = System.Drawing.Color.Transparent;
            this.pb_tv.Image = global::Home_progetto.Properties.Resources.tv_spenta;
            this.pb_tv.InitialImage = null;
            this.pb_tv.Location = new System.Drawing.Point(421, 34);
            this.pb_tv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_tv.Name = "pb_tv";
            this.pb_tv.Size = new System.Drawing.Size(80, 80);
            this.pb_tv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_tv.TabIndex = 33;
            this.pb_tv.TabStop = false;
            // 
            // pb_fan
            // 
            this.pb_fan.BackColor = System.Drawing.Color.Transparent;
            this.pb_fan.Image = global::Home_progetto.Properties.Resources.fan_Off;
            this.pb_fan.Location = new System.Drawing.Point(111, 181);
            this.pb_fan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_fan.Name = "pb_fan";
            this.pb_fan.Size = new System.Drawing.Size(64, 64);
            this.pb_fan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_fan.TabIndex = 32;
            this.pb_fan.TabStop = false;
            // 
            // pb_lucchetto
            // 
            this.pb_lucchetto.BackColor = System.Drawing.Color.Transparent;
            this.pb_lucchetto.Image = global::Home_progetto.Properties.Resources.unlocked1;
            this.pb_lucchetto.Location = new System.Drawing.Point(249, 572);
            this.pb_lucchetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_lucchetto.Name = "pb_lucchetto";
            this.pb_lucchetto.Size = new System.Drawing.Size(64, 64);
            this.pb_lucchetto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_lucchetto.TabIndex = 31;
            this.pb_lucchetto.TabStop = false;
            // 
            // pb_LuceStanza
            // 
            this.pb_LuceStanza.BackColor = System.Drawing.Color.Transparent;
            this.pb_LuceStanza.Image = global::Home_progetto.Properties.Resources.lamp__off;
            this.pb_LuceStanza.Location = new System.Drawing.Point(249, 265);
            this.pb_LuceStanza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_LuceStanza.Name = "pb_LuceStanza";
            this.pb_LuceStanza.Size = new System.Drawing.Size(64, 64);
            this.pb_LuceStanza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_LuceStanza.TabIndex = 19;
            this.pb_LuceStanza.TabStop = false;
            // 
            // pb_LuceLetto
            // 
            this.pb_LuceLetto.BackColor = System.Drawing.Color.Transparent;
            this.pb_LuceLetto.Image = global::Home_progetto.Properties.Resources.lamp__off;
            this.pb_LuceLetto.Location = new System.Drawing.Point(455, 282);
            this.pb_LuceLetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_LuceLetto.Name = "pb_LuceLetto";
            this.pb_LuceLetto.Size = new System.Drawing.Size(64, 64);
            this.pb_LuceLetto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_LuceLetto.TabIndex = 23;
            this.pb_LuceLetto.TabStop = false;
            // 
            // pb_LuceBagno
            // 
            this.pb_LuceBagno.BackColor = System.Drawing.Color.Transparent;
            this.pb_LuceBagno.Image = global::Home_progetto.Properties.Resources.lamp__off;
            this.pb_LuceBagno.Location = new System.Drawing.Point(407, 428);
            this.pb_LuceBagno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_LuceBagno.Name = "pb_LuceBagno";
            this.pb_LuceBagno.Size = new System.Drawing.Size(64, 64);
            this.pb_LuceBagno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_LuceBagno.TabIndex = 24;
            this.pb_LuceBagno.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Home_progetto.Properties.Resources.Immagine_2023_03_20_231629;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "- Cancello";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 794);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "home";
            this.Text = "G&G HOME";
            this.panel1.ResumeLayout(false);
            this.gb_info.ResumeLayout(false);
            this.gb_info.PerformLayout();
            this.gb_impostazioni.ResumeLayout(false);
            this.gb_impostazioni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.Allarme.ResumeLayout(false);
            this.Allarme.PerformLayout();
            this.gb_temp.ResumeLayout(false);
            this.gb_temp.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lucchetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LuceStanza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LuceLetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LuceBagno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb_LuceStanza;
        private System.Windows.Forms.PictureBox pb_LuceLetto;
        private System.Windows.Forms.PictureBox pb_LuceBagno;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pb_lucchetto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gb_temp;
        private CircularProgressBar.CircularProgressBar cirPro_umi;
        private System.Windows.Forms.Button btn_LuceLetto;
        private System.Windows.Forms.Button btn_Aggiorna;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label l_temp;
        private System.Windows.Forms.Label l_umid;
        private System.Windows.Forms.Button btn_LuceStanza;
        private System.Windows.Forms.Button btn_LuceBagno;
        private CircularProgressBar.CircularProgressBar cirPro_temp;
        private System.Windows.Forms.Label lb_hum;
        private System.Windows.Forms.Label lb_temp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox Allarme;
        private System.Windows.Forms.Label lb_allarme;
        private System.Windows.Forms.PictureBox pb_fan;
        private System.Windows.Forms.PictureBox pb_tv;
        private System.Windows.Forms.GroupBox gb_impostazioni;
        private System.Windows.Forms.RadioButton rbt_temaScuro;
        private System.Windows.Forms.RadioButton rbt_temaChiaro;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}

