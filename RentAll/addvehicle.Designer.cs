﻿namespace RentAll
{
    partial class addvehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addvehicle));
            this.btndelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnameplaka = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cmbyatarac = new System.Windows.Forms.ComboBox();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmodel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picvehicle = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbyakit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picvehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Maroon;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.Location = new System.Drawing.Point(139, 258);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 59);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "ÇIK";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Yakıt Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Kira Ücreti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Adı/Plaka";
            // 
            // txtucret
            // 
            this.txtucret.Location = new System.Drawing.Point(115, 92);
            this.txtucret.Multiline = true;
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(100, 20);
            this.txtucret.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Yat/Araba";
            // 
            // txtnameplaka
            // 
            this.txtnameplaka.Location = new System.Drawing.Point(115, 66);
            this.txtnameplaka.Multiline = true;
            this.txtnameplaka.Name = "txtnameplaka";
            this.txtnameplaka.Size = new System.Drawing.Size(100, 20);
            this.txtnameplaka.TabIndex = 26;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Green;
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdate.Location = new System.Drawing.Point(29, 258);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(104, 59);
            this.btnupdate.TabIndex = 25;
            this.btnupdate.Text = "EKLE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cmbyatarac
            // 
            this.cmbyatarac.FormattingEnabled = true;
            this.cmbyatarac.Items.AddRange(new object[] {
            "Araba"});
            this.cmbyatarac.Location = new System.Drawing.Point(115, 39);
            this.cmbyatarac.Name = "cmbyatarac";
            this.cmbyatarac.Size = new System.Drawing.Size(100, 21);
            this.cmbyatarac.TabIndex = 38;
            this.cmbyatarac.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbmarka
            // 
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(115, 143);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(100, 21);
            this.cmbmarka.TabIndex = 39;
            this.cmbmarka.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Model";
            // 
            // cmbmodel
            // 
            this.cmbmodel.FormattingEnabled = true;
            this.cmbmodel.Items.AddRange(new object[] {
            "M3",
            "Egea",
            "Golf",
            "3 Serisi",
            "E Serisi",
            "5 Serisi",
            "S Serisi",
            "A4",
            "A5",
            "Katamaran",
            "MotorYat"});
            this.cmbmodel.Location = new System.Drawing.Point(115, 170);
            this.cmbmodel.Name = "cmbmodel";
            this.cmbmodel.Size = new System.Drawing.Size(100, 21);
            this.cmbmodel.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(294, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 59);
            this.button1.TabIndex = 42;
            this.button1.Text = "Resim Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picvehicle
            // 
            this.picvehicle.Location = new System.Drawing.Point(265, 39);
            this.picvehicle.Name = "picvehicle";
            this.picvehicle.Size = new System.Drawing.Size(174, 121);
            this.picvehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picvehicle.TabIndex = 43;
            this.picvehicle.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbyakit
            // 
            this.cmbyakit.FormattingEnabled = true;
            this.cmbyakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin"});
            this.cmbyakit.Location = new System.Drawing.Point(115, 116);
            this.cmbyakit.Name = "cmbyakit";
            this.cmbyakit.Size = new System.Drawing.Size(100, 21);
            this.cmbyakit.TabIndex = 44;
            // 
            // addvehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(451, 430);
            this.Controls.Add(this.cmbyakit);
            this.Controls.Add(this.picvehicle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbmodel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbmarka);
            this.Controls.Add(this.cmbyatarac);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtucret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnameplaka);
            this.Controls.Add(this.btnupdate);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addvehicle";
            this.Text = "Araç Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.picvehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnameplaka;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox cmbyatarac;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbmodel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picvehicle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbyakit;
    }
}