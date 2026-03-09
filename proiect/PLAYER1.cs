using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace proiect
{
    public partial class PLAYER1 : Form
    {
        SoundPlayer win = new SoundPlayer(soundLocation: "win.wav");
        SoundPlayer music = new SoundPlayer(soundLocation: "music.wav");
        public PLAYER1()
        {
            InitializeComponent();
        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 x = new Form2();
            x.Show();
            music.PlayLooping();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PLAYER1_Load(object sender, EventArgs e)
        {
            win.Play();
            
            
        }
    }
}
