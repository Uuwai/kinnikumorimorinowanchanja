using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace kinnikumorimorinowanchanja
{
    public partial class koitsunotarechichigigawarosu : Form
    {
        public koitsunotarechichigigawarosu()
        {
            InitializeComponent();
        }

        private void koitsu_Click(object sender, EventArgs e)
        {
            SoundPlayer こいつ = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.koitsu1);
            こいつ.Play();
        }

        private void no_Click(object sender, EventArgs e)
        {
            SoundPlayer の = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.no2);
            の.Play();
        }

        private void ta_Click(object sender, EventArgs e)
        {
            SoundPlayer た = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.ta);
            た.Play();
        }

        private void re_Click(object sender, EventArgs e)
        {
            SoundPlayer れ = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.re);
            れ.Play();
        }

        private void chi_Click(object sender, EventArgs e)
        {
            SoundPlayer ち = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.chi);
            ち.Play();
        }

        private void giga_Click(object sender, EventArgs e)
        {
            SoundPlayer ギガ = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.giga);
            ギガ.Play();
        }

        private void waro_Click(object sender, EventArgs e)
        {
            SoundPlayer わろ = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.waro);
            わろ.Play();
        }

        private void su_Click(object sender, EventArgs e)
        {
            SoundPlayer す = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.su);
            す.Play();
        }

        private void ee_Click(object sender, EventArgs e)
        {
            SoundPlayer エー = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.e_);
            エー.Play();
        }

        private void o_Click(object sender, EventArgs e)
        {
            SoundPlayer ヲッ = new SoundPlayer(kinnikumorimorinowanchanja.Properties.Resources.wo);
            ヲッ.Play();
        }
    }
}
