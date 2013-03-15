namespace hiihto
{
    partial class LahtoJarjestelma
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
            this.id_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.startTime_lbl = new System.Windows.Forms.Label();
            this.timeToStart_lbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(12, 9);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(62, 33);
            this.id_lbl.TabIndex = 0;
            this.id_lbl.Text = "Nro";
            this.id_lbl.Click += new System.EventHandler(this.id_lbl_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(115, 9);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(75, 33);
            this.name_lbl.TabIndex = 1;
            this.name_lbl.Text = "Nimi";
            // 
            // startTime_lbl
            // 
            this.startTime_lbl.AutoSize = true;
            this.startTime_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime_lbl.Location = new System.Drawing.Point(275, 9);
            this.startTime_lbl.Name = "startTime_lbl";
            this.startTime_lbl.Size = new System.Drawing.Size(141, 33);
            this.startTime_lbl.TabIndex = 2;
            this.startTime_lbl.Text = "Lähtöaika";
            // 
            // timeToStart_lbl
            // 
            this.timeToStart_lbl.AutoSize = true;
            this.timeToStart_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeToStart_lbl.Location = new System.Drawing.Point(466, 9);
            this.timeToStart_lbl.Name = "timeToStart_lbl";
            this.timeToStart_lbl.Size = new System.Drawing.Size(176, 33);
            this.timeToStart_lbl.TabIndex = 3;
            this.timeToStart_lbl.Text = "AikaLähtöön";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(624, 95);
            this.listBox1.TabIndex = 4;
            // 
            // LahtoJarjestelma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 214);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.timeToStart_lbl);
            this.Controls.Add(this.startTime_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.id_lbl);
            this.Name = "LahtoJarjestelma";
            this.Text = "Lähettäjä";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label startTime_lbl;
        private System.Windows.Forms.Label timeToStart_lbl;
        private System.Windows.Forms.ListBox listBox1;
    }
}