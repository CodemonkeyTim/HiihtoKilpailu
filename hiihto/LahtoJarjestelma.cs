using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using perusluokat;

namespace hiihto
{
    public partial class LahtoJarjestelma : Form
    {

        Hiihtokilpailu kilpailu;

        public LahtoJarjestelma()
        {
            InitializeComponent();
        }

        private void id_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tuoTiedotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            Serializer ser = new Serializer();

            kilpailu = ser.DeSerializeObject(dialog.FileName);
        }
    }
}
