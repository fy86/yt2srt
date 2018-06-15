using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yt2srt
{
    public partial class Form1 : Form
    {
        int nSaveTxt = 1;// default save txt file
        public Form1()
        {
            InitializeComponent();
        }

        private void selectfielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult dlgr = folderBrowserDialog1.ShowDialog();
            DialogResult dlgr = openFileDialog1.ShowDialog();
            if (dlgr == DialogResult.OK)
            {
                //string str = folderBrowserDialog1.SelectedPath;
                string str = openFileDialog1.FileName;
                string strext = System.IO.Path.GetExtension(str);
                string fname = System.IO.Path.GetDirectoryName(str)
                    + "\\" + System.IO.Path.GetFileNameWithoutExtension(str);

                this.Text = fname;

                if (strext.Equals(".txt", StringComparison.CurrentCultureIgnoreCase))
                {
                    richTextBox1.Text = System.IO.File.ReadAllText(str);
                    nSaveTxt = 0;
                }
                else
                {
                    nSaveTxt = 1;
                }

            }

        }
    }
}
