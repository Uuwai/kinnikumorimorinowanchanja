using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace kinnikumorimorinowanchanja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kinniku_Click(object sender, EventArgs e)
        {
            SoundPlayer 筋肉 = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.kinniku);
            筋肉.Play();
        }

        private void mori_Click(object sender, EventArgs e)
        {
            SoundPlayer もり = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.mori);
            もり.Play();
        }

        private void no_Click(object sender, EventArgs e)
        {
            SoundPlayer の = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.no);
            の.Play();
        }
        private void wan_Click(object sender, EventArgs e)
        {
            SoundPlayer ワン = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.wan);
            ワン.Play();
        }

        private void chan_Click(object sender, EventArgs e)
        {
            SoundPlayer ちゃん = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.chan);
            ちゃん.Play();
        }

        private void ja_Click(object sender, EventArgs e)
        {
            SoundPlayer じゃ = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.ja);
            じゃ.Play();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            koitsunotarechichigigawarosu f2 = new koitsunotarechichigigawarosu();
            f2.Show();
        }
    }
}
