﻿namespace yt2srt
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectfielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastetxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteappendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleartxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveconvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectfielToolStripMenuItem,
            this.pastetxtToolStripMenuItem,
            this.pasteappendToolStripMenuItem,
            this.cleartxtToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.saveconvertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectfielToolStripMenuItem
            // 
            this.selectfielToolStripMenuItem.Name = "selectfielToolStripMenuItem";
            this.selectfielToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.selectfielToolStripMenuItem.Text = "select.file";
            // 
            // pastetxtToolStripMenuItem
            // 
            this.pastetxtToolStripMenuItem.Name = "pastetxtToolStripMenuItem";
            this.pastetxtToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.pastetxtToolStripMenuItem.Text = "paste.txt";
            // 
            // pasteappendToolStripMenuItem
            // 
            this.pasteappendToolStripMenuItem.Name = "pasteappendToolStripMenuItem";
            this.pasteappendToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.pasteappendToolStripMenuItem.Text = "paste.append";
            // 
            // cleartxtToolStripMenuItem
            // 
            this.cleartxtToolStripMenuItem.Name = "cleartxtToolStripMenuItem";
            this.cleartxtToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.cleartxtToolStripMenuItem.Text = "clear.txt";
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.convertToolStripMenuItem.Text = "convert";
            // 
            // saveconvertToolStripMenuItem
            // 
            this.saveconvertToolStripMenuItem.Name = "saveconvertToolStripMenuItem";
            this.saveconvertToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.saveconvertToolStripMenuItem.Text = "save.srt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 537);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "txt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "srt.en";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "srt.en_us";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 511);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "youtube2srt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectfielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastetxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteappendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleartxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveconvertToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

