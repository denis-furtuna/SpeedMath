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
    
   
       
   
    public partial class Form1 : Form
    {
        SoundPlayer music = new SoundPlayer(soundLocation: "music.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 x = new Form3();
           x.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
            music.PlayLooping();
        }
    }
}
