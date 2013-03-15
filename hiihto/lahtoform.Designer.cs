namespace hiihto
{
    partial class lahtoform
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
            this.kielletyt_poista_Button = new System.Windows.Forms.Button();
            this.kielletyt_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kielletyt_lisaa_Button = new System.Windows.Forms.Button();
            this.kielletyt_textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.laht_sarjat_listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laht_kilpailijat_listBox = new System.Windows.Forms.ListBox();
            this.kilpailija_ylospain_Button = new System.Windows.Forms.Button();
            this.kilpailja_alaspain_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ryhmakoko = new System.Windows.Forms.TextBox();
            this.kisatiedot_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_kilpailijanumerotalkaen = new System.Windows.Forms.TextBox();
            this.kilpailijoita_kpl_Label = new System.Windows.Forms.Label();
            this.textBox_lahtovali = new System.Windows.Forms.TextBox();
            this.aloita_sarja_Button = new System.Windows.Forms.Button();
            this.kilpailja_jaa_ryhmat_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kielletyt_poista_Button
            // 
            this.kielletyt_poista_Button.Location = new System.Drawing.Point(108, 90);
            this.kielletyt_poista_Button.Name = "kielletyt_poista_Button";
            this.kielletyt_poista_Button.Size = new System.Drawing.Size(75, 23);
            this.kielletyt_poista_Button.TabIndex = 0;
            this.kielletyt_poista_Button.Text = "Poista valittu";
            this.kielletyt_poista_Button.UseVisualStyleBackColor = true;
            this.kielletyt_poista_Button.Click += new System.EventHandler(this.kielletyt_poista_Button_Click);
            // 
            // kielletyt_listBox
            // 
            this.kielletyt_listBox.FormattingEnabled = true;
            this.kielletyt_listBox.Location = new System.Drawing.Point(3, 33);
            this.kielletyt_listBox.Name = "kielletyt_listBox";
            this.kielletyt_listBox.Size = new System.Drawing.Size(84, 82);
            this.kielletyt_listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kielletyt numerot";
            // 
            // kielletyt_lisaa_Button
            // 
            this.kielletyt_lisaa_Button.Location = new System.Drawing.Point(108, 61);
            this.kielletyt_lisaa_Button.Name = "kielletyt_lisaa_Button";
            this.kielletyt_lisaa_Button.Size = new System.Drawing.Size(75, 23);
            this.kielletyt_lisaa_Button.TabIndex = 3;
            this.kielletyt_lisaa_Button.Text = "Lisää listaan";
            this.kielletyt_lisaa_Button.UseVisualStyleBackColor = true;
            this.kielletyt_lisaa_Button.Click += new System.EventHandler(this.kielletyt_lisaa_Button_Click);
            // 
            // kielletyt_textBox
            // 
            this.kielletyt_textBox.Location = new System.Drawing.Point(108, 33);
            this.kielletyt_textBox.Name = "kielletyt_textBox";
            this.kielletyt_textBox.Size = new System.Drawing.Size(75, 20);
            this.kielletyt_textBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kielletyt_listBox);
            this.panel1.Controls.Add(this.kielletyt_poista_Button);
            this.panel1.Controls.Add(this.kielletyt_lisaa_Button);
            this.panel1.Controls.Add(this.kielletyt_textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 116);
            this.panel1.TabIndex = 5;
            // 
            // laht_sarjat_listBox
            // 
            this.laht_sarjat_listBox.FormattingEnabled = true;
            this.laht_sarjat_listBox.Location = new System.Drawing.Point(12, 53);
            this.laht_sarjat_listBox.Name = "laht_sarjat_listBox";
            this.laht_sarjat_listBox.Size = new System.Drawing.Size(181, 225);
            this.laht_sarjat_listBox.TabIndex = 6;
            this.laht_sarjat_listBox.SelectedIndexChanged += new System.EventHandler(this.laht_sarjat_listBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sarjat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kilpailijat";
            // 
            // laht_kilpailijat_listBox
            // 
            this.laht_kilpailijat_listBox.FormattingEnabled = true;
            this.laht_kilpailijat_listBox.Location = new System.Drawing.Point(199, 53);
            this.laht_kilpailijat_listBox.Name = "laht_kilpailijat_listBox";
            this.laht_kilpailijat_listBox.Size = new System.Drawing.Size(495, 225);
            this.laht_kilpailijat_listBox.TabIndex = 9;
            // 
            // kilpailija_ylospain_Button
            // 
            this.kilpailija_ylospain_Button.Location = new System.Drawing.Point(700, 53);
            this.kilpailija_ylospain_Button.Name = "kilpailija_ylospain_Button";
            this.kilpailija_ylospain_Button.Size = new System.Drawing.Size(122, 23);
            this.kilpailija_ylospain_Button.TabIndex = 10;
            this.kilpailija_ylospain_Button.Text = "Siirrä valittu ylöspäin";
            this.kilpailija_ylospain_Button.UseVisualStyleBackColor = true;
            this.kilpailija_ylospain_Button.Click += new System.EventHandler(this.kilpailija_ylospain_Button_Click);
            // 
            // kilpailja_alaspain_Button
            // 
            this.kilpailja_alaspain_Button.Location = new System.Drawing.Point(700, 82);
            this.kilpailja_alaspain_Button.Name = "kilpailja_alaspain_Button";
            this.kilpailja_alaspain_Button.Size = new System.Drawing.Size(122, 23);
            this.kilpailja_alaspain_Button.TabIndex = 11;
            this.kilpailja_alaspain_Button.Text = "Siirä valittu alaspäin";
            this.kilpailja_alaspain_Button.UseVisualStyleBackColor = true;
            this.kilpailja_alaspain_Button.Click += new System.EventHandler(this.kilpailja_alaspain_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lähtöryhmän koko";
            // 
            // textBox_ryhmakoko
            // 
            this.textBox_ryhmakoko.Location = new System.Drawing.Point(700, 202);
            this.textBox_ryhmakoko.Name = "textBox_ryhmakoko";
            this.textBox_ryhmakoko.Size = new System.Drawing.Size(72, 20);
            this.textBox_ryhmakoko.TabIndex = 14;
            // 
            // kisatiedot_label
            // 
            this.kisatiedot_label.AutoSize = true;
            this.kisatiedot_label.Location = new System.Drawing.Point(12, 13);
            this.kisatiedot_label.Name = "kisatiedot_label";
            this.kisatiedot_label.Size = new System.Drawing.Size(35, 13);
            this.kisatiedot_label.TabIndex = 15;
            this.kisatiedot_label.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lähtöväli(Sek)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(697, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kilpailija nro:t alkean..";
            // 
            // textBox_kilpailijanumerotalkaen
            // 
            this.textBox_kilpailijanumerotalkaen.Location = new System.Drawing.Point(700, 124);
            this.textBox_kilpailijanumerotalkaen.Name = "textBox_kilpailijanumerotalkaen";
            this.textBox_kilpailijanumerotalkaen.Size = new System.Drawing.Size(72, 20);
            this.textBox_kilpailijanumerotalkaen.TabIndex = 19;
            // 
            // kilpailijoita_kpl_Label
            // 
            this.kilpailijoita_kpl_Label.AutoSize = true;
            this.kilpailijoita_kpl_Label.Location = new System.Drawing.Point(380, 34);
            this.kilpailijoita_kpl_Label.Name = "kilpailijoita_kpl_Label";
            this.kilpailijoita_kpl_Label.Size = new System.Drawing.Size(28, 13);
            this.kilpailijoita_kpl_Label.TabIndex = 20;
            this.kilpailijoita_kpl_Label.Text = ".......";
            // 
            // textBox_lahtovali
            // 
            this.textBox_lahtovali.Location = new System.Drawing.Point(700, 163);
            this.textBox_lahtovali.Name = "textBox_lahtovali";
            this.textBox_lahtovali.Size = new System.Drawing.Size(72, 20);
            this.textBox_lahtovali.TabIndex = 21;
            // 
            // aloita_sarja_Button
            // 
            this.aloita_sarja_Button.Location = new System.Drawing.Point(383, 322);
            this.aloita_sarja_Button.Name = "aloita_sarja_Button";
            this.aloita_sarja_Button.Size = new System.Drawing.Size(242, 97);
            this.aloita_sarja_Button.TabIndex = 22;
            this.aloita_sarja_Button.Text = "Aloita sarja";
            this.aloita_sarja_Button.UseVisualStyleBackColor = true;
            this.aloita_sarja_Button.Click += new System.EventHandler(this.aloita_sarja_Button_Click);
            // 
            // kilpailja_jaa_ryhmat_Button
            // 
            this.kilpailja_jaa_ryhmat_Button.Location = new System.Drawing.Point(700, 228);
            this.kilpailja_jaa_ryhmat_Button.Name = "kilpailja_jaa_ryhmat_Button";
            this.kilpailja_jaa_ryhmat_Button.Size = new System.Drawing.Size(124, 23);
            this.kilpailja_jaa_ryhmat_Button.TabIndex = 23;
            this.kilpailja_jaa_ryhmat_Button.Text = "Jaa ryhmät";
            this.kilpailja_jaa_ryhmat_Button.UseVisualStyleBackColor = true;
            this.kilpailja_jaa_ryhmat_Button.Click += new System.EventHandler(this.kilpailja_jaa_ryhmat_Button_Click);
            // 
            // lahtoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 447);
            this.Controls.Add(this.kilpailja_jaa_ryhmat_Button);
            this.Controls.Add(this.aloita_sarja_Button);
            this.Controls.Add(this.textBox_lahtovali);
            this.Controls.Add(this.kilpailijoita_kpl_Label);
            this.Controls.Add(this.textBox_kilpailijanumerotalkaen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kisatiedot_label);
            this.Controls.Add(this.textBox_ryhmakoko);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kilpailja_alaspain_Button);
            this.Controls.Add(this.kilpailija_ylospain_Button);
            this.Controls.Add(this.laht_kilpailijat_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laht_sarjat_listBox);
            this.Controls.Add(this.panel1);
            this.Name = "lahtoform";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kielletyt_poista_Button;
        private System.Windows.Forms.ListBox kielletyt_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kielletyt_lisaa_Button;
        private System.Windows.Forms.TextBox kielletyt_textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox laht_sarjat_listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox laht_kilpailijat_listBox;
        private System.Windows.Forms.Button kilpailija_ylospain_Button;
        private System.Windows.Forms.Button kilpailja_alaspain_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ryhmakoko;
        private System.Windows.Forms.Label kisatiedot_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_kilpailijanumerotalkaen;
        private System.Windows.Forms.Label kilpailijoita_kpl_Label;
        private System.Windows.Forms.TextBox textBox_lahtovali;
        private System.Windows.Forms.Button aloita_sarja_Button;
        private System.Windows.Forms.Button kilpailja_jaa_ryhmat_Button;
    }
}

