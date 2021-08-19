
namespace IR_Remote
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_on_off = new System.Windows.Forms.Button();
            this.bt_volplus = new System.Windows.Forms.Button();
            this.bt_volminus = new System.Windows.Forms.Button();
            this.conectar = new System.Windows.Forms.Button();
            this.bt_scanPort = new System.Windows.Forms.Button();
            this.port_comboBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bt_disconect = new System.Windows.Forms.Button();
            this.env_textBox = new System.Windows.Forms.TextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.bt_pplus = new System.Windows.Forms.Button();
            this.bt_pminus = new System.Windows.Forms.Button();
            this.bt_menu = new System.Windows.Forms.Button();
            this.bt_fl_abajo = new System.Windows.Forms.Button();
            this.bt_fl_derecha = new System.Windows.Forms.Button();
            this.bt_fl_arriba = new System.Windows.Forms.Button();
            this.bt_fl_izquierda = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.tb_datareceiver = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_mute = new System.Windows.Forms.Button();
            this.bt_CH_List = new System.Windows.Forms.Button();
            this.bt_source = new System.Windows.Forms.Button();
            this.bt_prech = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Estado:\r\n";
            // 
            // bt_on_off
            // 
            this.bt_on_off.BackColor = System.Drawing.Color.Red;
            this.bt_on_off.Location = new System.Drawing.Point(13, 14);
            this.bt_on_off.Name = "bt_on_off";
            this.bt_on_off.Size = new System.Drawing.Size(99, 23);
            this.bt_on_off.TabIndex = 10;
            this.bt_on_off.Text = "ON/OFF";
            this.bt_on_off.UseVisualStyleBackColor = false;
            this.bt_on_off.Click += new System.EventHandler(this.bt_on_off_Click);
            // 
            // bt_volplus
            // 
            this.bt_volplus.BackColor = System.Drawing.Color.Aqua;
            this.bt_volplus.Location = new System.Drawing.Point(14, 159);
            this.bt_volplus.Name = "bt_volplus";
            this.bt_volplus.Size = new System.Drawing.Size(55, 23);
            this.bt_volplus.TabIndex = 11;
            this.bt_volplus.Text = "VOL+";
            this.bt_volplus.UseVisualStyleBackColor = false;
            this.bt_volplus.Click += new System.EventHandler(this.bt_volplus_Click);
            // 
            // bt_volminus
            // 
            this.bt_volminus.BackColor = System.Drawing.Color.Aqua;
            this.bt_volminus.Location = new System.Drawing.Point(15, 188);
            this.bt_volminus.Name = "bt_volminus";
            this.bt_volminus.Size = new System.Drawing.Size(55, 23);
            this.bt_volminus.TabIndex = 12;
            this.bt_volminus.Text = "VOL-";
            this.bt_volminus.UseVisualStyleBackColor = false;
            this.bt_volminus.Click += new System.EventHandler(this.bt_volminus_Click);
            // 
            // conectar
            // 
            this.conectar.BackColor = System.Drawing.SystemColors.Control;
            this.conectar.Location = new System.Drawing.Point(12, 445);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(100, 22);
            this.conectar.TabIndex = 13;
            this.conectar.Text = "Connect";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // bt_scanPort
            // 
            this.bt_scanPort.BackColor = System.Drawing.SystemColors.Control;
            this.bt_scanPort.Location = new System.Drawing.Point(118, 416);
            this.bt_scanPort.Name = "bt_scanPort";
            this.bt_scanPort.Size = new System.Drawing.Size(75, 23);
            this.bt_scanPort.TabIndex = 14;
            this.bt_scanPort.Text = "Scan";
            this.bt_scanPort.UseVisualStyleBackColor = true;
            this.bt_scanPort.Click += new System.EventHandler(this.bt_scanPort_Click);
            // 
            // port_comboBox
            // 
            this.port_comboBox.FormattingEnabled = true;
            this.port_comboBox.Location = new System.Drawing.Point(12, 418);
            this.port_comboBox.Name = "port_comboBox";
            this.port_comboBox.Size = new System.Drawing.Size(100, 21);
            this.port_comboBox.TabIndex = 15;
            this.port_comboBox.Text = "COM";
            this.port_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // bt_disconect
            // 
            this.bt_disconect.BackColor = System.Drawing.SystemColors.Control;
            this.bt_disconect.Location = new System.Drawing.Point(118, 445);
            this.bt_disconect.Name = "bt_disconect";
            this.bt_disconect.Size = new System.Drawing.Size(75, 22);
            this.bt_disconect.TabIndex = 16;
            this.bt_disconect.Text = "Disconect";
            this.bt_disconect.UseVisualStyleBackColor = true;
            this.bt_disconect.Click += new System.EventHandler(this.bt_disconect_Click);
            // 
            // env_textBox
            // 
            this.env_textBox.Location = new System.Drawing.Point(13, 359);
            this.env_textBox.Name = "env_textBox";
            this.env_textBox.Size = new System.Drawing.Size(76, 20);
            this.env_textBox.TabIndex = 17;
            this.env_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.env_textBox_KeyPress);
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(2, 42);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(181, 23);
            this.bt_send.TabIndex = 18;
            this.bt_send.Text = "Send comands";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // bt_pplus
            // 
            this.bt_pplus.BackColor = System.Drawing.Color.Aqua;
            this.bt_pplus.Location = new System.Drawing.Point(135, 159);
            this.bt_pplus.Name = "bt_pplus";
            this.bt_pplus.Size = new System.Drawing.Size(55, 23);
            this.bt_pplus.TabIndex = 19;
            this.bt_pplus.Text = "P+";
            this.bt_pplus.UseVisualStyleBackColor = false;
            this.bt_pplus.Click += new System.EventHandler(this.bt_pplus_Click);
            // 
            // bt_pminus
            // 
            this.bt_pminus.BackColor = System.Drawing.Color.Aqua;
            this.bt_pminus.Location = new System.Drawing.Point(135, 188);
            this.bt_pminus.Name = "bt_pminus";
            this.bt_pminus.Size = new System.Drawing.Size(55, 23);
            this.bt_pminus.TabIndex = 20;
            this.bt_pminus.Text = "P-";
            this.bt_pminus.UseVisualStyleBackColor = false;
            this.bt_pminus.Click += new System.EventHandler(this.bt_pminus_Click);
            // 
            // bt_menu
            // 
            this.bt_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_menu.Location = new System.Drawing.Point(15, 218);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(178, 23);
            this.bt_menu.TabIndex = 21;
            this.bt_menu.Text = "Menu";
            this.bt_menu.UseVisualStyleBackColor = false;
            this.bt_menu.Click += new System.EventHandler(this.bt_menu_Click);
            // 
            // bt_fl_abajo
            // 
            this.bt_fl_abajo.BackColor = System.Drawing.Color.Aqua;
            this.bt_fl_abajo.Location = new System.Drawing.Point(76, 305);
            this.bt_fl_abajo.Name = "bt_fl_abajo";
            this.bt_fl_abajo.Size = new System.Drawing.Size(55, 23);
            this.bt_fl_abajo.TabIndex = 23;
            this.bt_fl_abajo.Text = "l";
            this.bt_fl_abajo.UseVisualStyleBackColor = false;
            this.bt_fl_abajo.Click += new System.EventHandler(this.bt_fl_abajo_Click);
            // 
            // bt_fl_derecha
            // 
            this.bt_fl_derecha.BackColor = System.Drawing.Color.Aqua;
            this.bt_fl_derecha.Location = new System.Drawing.Point(135, 276);
            this.bt_fl_derecha.Name = "bt_fl_derecha";
            this.bt_fl_derecha.Size = new System.Drawing.Size(55, 23);
            this.bt_fl_derecha.TabIndex = 24;
            this.bt_fl_derecha.Text = ">";
            this.bt_fl_derecha.UseVisualStyleBackColor = false;
            this.bt_fl_derecha.Click += new System.EventHandler(this.bt_fl_derecha_Click);
            // 
            // bt_fl_arriba
            // 
            this.bt_fl_arriba.BackColor = System.Drawing.Color.Aqua;
            this.bt_fl_arriba.Location = new System.Drawing.Point(76, 247);
            this.bt_fl_arriba.Name = "bt_fl_arriba";
            this.bt_fl_arriba.Size = new System.Drawing.Size(55, 23);
            this.bt_fl_arriba.TabIndex = 25;
            this.bt_fl_arriba.Text = "l";
            this.bt_fl_arriba.UseVisualStyleBackColor = false;
            this.bt_fl_arriba.Click += new System.EventHandler(this.bt_fl_arriba_Click);
            // 
            // bt_fl_izquierda
            // 
            this.bt_fl_izquierda.BackColor = System.Drawing.Color.Aqua;
            this.bt_fl_izquierda.Location = new System.Drawing.Point(16, 276);
            this.bt_fl_izquierda.Name = "bt_fl_izquierda";
            this.bt_fl_izquierda.Size = new System.Drawing.Size(55, 23);
            this.bt_fl_izquierda.TabIndex = 26;
            this.bt_fl_izquierda.Text = "<";
            this.bt_fl_izquierda.UseVisualStyleBackColor = false;
            this.bt_fl_izquierda.Click += new System.EventHandler(this.bt_fl_izquierda_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.GreenYellow;
            this.bt_ok.Location = new System.Drawing.Point(75, 276);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(55, 23);
            this.bt_ok.TabIndex = 27;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_return
            // 
            this.bt_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_return.Location = new System.Drawing.Point(16, 305);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(55, 23);
            this.bt_return.TabIndex = 28;
            this.bt_return.Text = "Return";
            this.bt_return.UseVisualStyleBackColor = false;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_exit.Location = new System.Drawing.Point(135, 305);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(55, 23);
            this.bt_exit.TabIndex = 29;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // tb_datareceiver
            // 
            this.tb_datareceiver.Location = new System.Drawing.Point(105, 359);
            this.tb_datareceiver.Name = "tb_datareceiver";
            this.tb_datareceiver.Size = new System.Drawing.Size(88, 20);
            this.tb_datareceiver.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(86, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 36);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_send);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(11, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 71);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send";
            // 
            // bt_mute
            // 
            this.bt_mute.Location = new System.Drawing.Point(76, 159);
            this.bt_mute.Name = "bt_mute";
            this.bt_mute.Size = new System.Drawing.Size(55, 23);
            this.bt_mute.TabIndex = 33;
            this.bt_mute.Text = "mute";
            this.bt_mute.UseVisualStyleBackColor = true;
            this.bt_mute.Click += new System.EventHandler(this.bt_mute_Click);
            // 
            // bt_CH_List
            // 
            this.bt_CH_List.Location = new System.Drawing.Point(75, 188);
            this.bt_CH_List.Name = "bt_CH_List";
            this.bt_CH_List.Size = new System.Drawing.Size(55, 23);
            this.bt_CH_List.TabIndex = 34;
            this.bt_CH_List.Text = "CH List";
            this.bt_CH_List.UseVisualStyleBackColor = true;
            this.bt_CH_List.Click += new System.EventHandler(this.bt_CH_List_Click);
            // 
            // bt_source
            // 
            this.bt_source.Location = new System.Drawing.Point(116, 14);
            this.bt_source.Name = "bt_source";
            this.bt_source.Size = new System.Drawing.Size(74, 23);
            this.bt_source.TabIndex = 35;
            this.bt_source.Text = "Source";
            this.bt_source.UseVisualStyleBackColor = true;
            this.bt_source.Click += new System.EventHandler(this.bt_source_Click);
            // 
            // bt_prech
            // 
            this.bt_prech.Location = new System.Drawing.Point(136, 130);
            this.bt_prech.Name = "bt_prech";
            this.bt_prech.Size = new System.Drawing.Size(55, 23);
            this.bt_prech.TabIndex = 36;
            this.bt_prech.Text = "Pre-CH";
            this.bt_prech.UseVisualStyleBackColor = true;
            this.bt_prech.Click += new System.EventHandler(this.bt_prech_Click);
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(14, 43);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(55, 23);
            this.bt_1.TabIndex = 37;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(75, 43);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(55, 23);
            this.bt_2.TabIndex = 38;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(136, 43);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(55, 23);
            this.bt_3.TabIndex = 39;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(14, 72);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(55, 23);
            this.bt_4.TabIndex = 40;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(75, 72);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(55, 23);
            this.bt_5.TabIndex = 41;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_6
            // 
            this.bt_6.Location = new System.Drawing.Point(135, 72);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(55, 23);
            this.bt_6.TabIndex = 42;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_7
            // 
            this.bt_7.Location = new System.Drawing.Point(15, 101);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(55, 23);
            this.bt_7.TabIndex = 43;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_8
            // 
            this.bt_8.Location = new System.Drawing.Point(75, 101);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(56, 23);
            this.bt_8.TabIndex = 44;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_9
            // 
            this.bt_9.Location = new System.Drawing.Point(135, 101);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(55, 23);
            this.bt_9.TabIndex = 45;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_0
            // 
            this.bt_0.Location = new System.Drawing.Point(15, 130);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(115, 23);
            this.bt_0.TabIndex = 46;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(203, 491);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_prech);
            this.Controls.Add(this.bt_source);
            this.Controls.Add(this.bt_CH_List);
            this.Controls.Add(this.bt_mute);
            this.Controls.Add(this.tb_datareceiver);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.env_textBox);
            this.Controls.Add(this.bt_return);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.bt_fl_izquierda);
            this.Controls.Add(this.bt_fl_arriba);
            this.Controls.Add(this.bt_fl_derecha);
            this.Controls.Add(this.bt_fl_abajo);
            this.Controls.Add(this.bt_menu);
            this.Controls.Add(this.bt_pminus);
            this.Controls.Add(this.bt_pplus);
            this.Controls.Add(this.bt_disconect);
            this.Controls.Add(this.port_comboBox);
            this.Controls.Add(this.bt_scanPort);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.bt_volminus);
            this.Controls.Add(this.bt_volplus);
            this.Controls.Add(this.bt_on_off);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.Text = "Samsung";
            this.TopMost = true;
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_on_off;
        private System.Windows.Forms.Button bt_volplus;
        private System.Windows.Forms.Button bt_volminus;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button bt_scanPort;
        private System.Windows.Forms.ComboBox port_comboBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bt_disconect;
        private System.Windows.Forms.TextBox env_textBox;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.Button bt_pplus;
        private System.Windows.Forms.Button bt_pminus;
        private System.Windows.Forms.Button bt_menu;
        private System.Windows.Forms.Button bt_fl_abajo;
        private System.Windows.Forms.Button bt_fl_derecha;
        private System.Windows.Forms.Button bt_fl_arriba;
        private System.Windows.Forms.Button bt_fl_izquierda;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.TextBox tb_datareceiver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_mute;
        private System.Windows.Forms.Button bt_CH_List;
        private System.Windows.Forms.Button bt_source;
        private System.Windows.Forms.Button bt_prech;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_0;
    }
}

