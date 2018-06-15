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
        public string strFnameEn;
        public string strFnameEnus;
        public string strFnameTxt;
        int nSaveTxt = 1;// default save txt file
        int hh, mm, ss, mm0, ss0;
        int hh1 = -1, mm1 = 0, ss1 = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private int IsTimeStamp(string str)
        {
            int n = 0;
            int i, len;
            string str1 = str.Trim();
            len = str1.Length;
            if (str1.Length > 6) return 0;
            for (i = 0; i < len; i++)
            {
                if (Char.IsDigit(str1[i])) continue;
                if (str1[i] == ':')
                {
                    n++;
                }
                else return 0;
            }
            if (n != 1) return 0;
            string[] mmss = str1.Split(':');
            mm0 = int.Parse(mmss[0]);
            ss0 = int.Parse(mmss[1]);
            hh = mm0 / 60;
            mm = mm0 % 60;
            ss = ss0;
            return 1;
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

        // paste
        private void pastetxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.Windows.Forms.Clipboard.GetText();
        }
        // paste append
        private void pasteappendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("\n" + System.Windows.Forms.Clipboard.GetText());
        }
        // clear
        private void cleartxtToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Text = "";

        private void convertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveconvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = this.Text;
            strFnameTxt = str + ".txt";
            strFnameEn = str + ".en.srt";
            strFnameEnus = str + ".en_US.srt";

            int ntxt = 0;
            string strTxt = "";
            string strTime = "";
            string strTime2 = "";
            int sn = 1;

            if (nSaveTxt > 0)
            {
                //System.IO.StreamWriter ftxt = new System.IO.StreamWriter(strFnameTxt);
                System.IO.File.WriteAllText(strFnameTxt, richTextBox1.Text);
            }
            System.IO.StreamWriter fen = new System.IO.StreamWriter(strFnameEn);
            System.IO.StreamWriter fus = new System.IO.StreamWriter(strFnameEnus);

            string[] lines = richTextBox1.Text.Split(new[] { '\n', '\r' });

            foreach (string line in lines)
            {
                if (line.Length == 0) continue;
                if (IsTimeStamp(line) > 0)
                {// time string
                    if (hh1 >= 0 && ntxt > 0)
                    {
                        strTime = string.Format("{0:D2}:{1:D2}:{2:D2},000 --> {3:D2}:{4:D2}:{5:D2},000", hh1, mm1, ss1, hh, mm, ss);
                        strTime2 = string.Format("{0:D2}:{1:D2}:{2:D2}", hh1, mm1, ss1);

                        fen.WriteLine(sn.ToString());
                        fen.WriteLine(strTime);
                        fen.WriteLine(strTxt);
                        fen.WriteLine("");

                        fus.WriteLine(sn.ToString());
                        fus.WriteLine(strTime);
                        fus.WriteLine(strTime2);
                        fus.WriteLine(strTxt);
                        fus.WriteLine("");

                        sn++;
                    }
                    hh1 = hh;
                    mm1 = mm;
                    ss1 = ss;
                    ntxt = 0;
                    strTxt = "";
                }
                else
                {
                    // txt string
                    if (!line.Substring(0, 1).Contains("["))
                    {
                        if (ntxt == 0)
                        {
                            strTxt = line;
                        }
                        else
                        {
                            strTxt += "\n" + line;
                        }
                        ntxt++;
                    }
                }
            }
            if (hh1 >= 0 && ntxt > 0)
            {
                hh = (hh1 * 60 + mm1 + 1) / 60;
                mm = (hh1 * 60 + mm1 + 1) % 60;
                ss = ss1;
                strTime = string.Format("{0:D2}:{1:D2}:{2:D2},000 --> {3:D2}:{4:D2}:{5:D2},000", hh1, mm1, ss1, hh, mm, ss);
                strTime2 = string.Format("{0:D2}:{1:D2}:{2:D2}", hh1, mm1, ss1);

                fen.WriteLine(sn.ToString());
                fen.WriteLine(strTime);
                fen.WriteLine(strTxt);
                fen.WriteLine("");

                fus.WriteLine(sn.ToString());
                fus.WriteLine(strTime);
                fus.WriteLine(strTime2);
                fus.WriteLine(strTxt);
                fus.WriteLine("");
            }

            fen.Close();
            fus.Close();
            MessageBox.Show(text: "done");

        }
    }
}
