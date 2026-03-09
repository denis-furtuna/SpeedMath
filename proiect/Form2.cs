using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Form2 : Form
    {
        
        struct exercitii
        {
            public string ec;
            public double a, b, c;
            public int corect;
            public bool ok;
        }
        exercitii []easy= new exercitii[30];
        exercitii []mediu= new exercitii[30];
        exercitii []hard= new exercitii[30];
       
        
        public Form2()
        {
            easy[0].ec = "2+2";
            easy[0].a = 3;
            easy[0].b = 4;
            easy[0].c = 5;
            easy[0].corect = 2;

            easy[1].ec = "5+16";
            easy[1].a = 20;
            easy[1].b = 22;
            easy[1].c = 21;
            easy[1].corect = 3;

            easy[2].ec = "9+18";
            easy[2].a = 25;
            easy[2].b = 27;
            easy[2].c = 37;
            easy[2].corect = 2;

            easy[3].ec = "28+13";
            easy[3].a = 51;
            easy[3].b = 31;
            easy[3].c = 41;
            easy[3].corect = 3;

            easy[4].ec = "|-10|";
            easy[4].a = 10;
            easy[4].b = -10;
            easy[4].c = 0;
            easy[4].corect = 1;

            easy[5].ec = "3x12";
            easy[5].a = 36;
            easy[5].b = 26;
            easy[5].c = 30;
            easy[5].corect = 1;

            easy[6].ec = "9x5";
            easy[6].a = 43;
            easy[6].b = 45;
            easy[6].c = 50;
            easy[6].corect = 2;

            easy[7].ec = "2x2+2";
            easy[7].a = 4;
            easy[7].b = 8;
            easy[7].c = 6;
            easy[7].corect = 3;

            easy[8].ec = "9x9";
            easy[8].a = 80;
            easy[8].b = 81;
            easy[8].c = 91;
            easy[8].corect = 2;

            easy[9].ec = "36x2";
            easy[9].a = 62;
            easy[9].b = 69;
            easy[9].c = 72;
            easy[9].corect = 3;

            easy[10].ec = "64+18";
            easy[10].a = 78;
            easy[10].b = 79;
            easy[10].c = 82;
            easy[10].corect = 3;

            easy[11].ec = "6x9";
            easy[11].a = 69;
            easy[11].b = 36;
            easy[11].c = 54;
            easy[11].corect = 3;

            easy[12].ec = "43-15";
            easy[12].a = 28;
            easy[12].b = 27;
            easy[12].c = 18;
            easy[12].corect = 1;

            easy[13].ec = "32-23";
            easy[13].a = 10;
            easy[13].b = 9;
            easy[13].c = 8;
            easy[13].corect = 2;

            easy[14].ec = "11x11";
            easy[14].a = 131;
            easy[14].b = 123;
            easy[14].c = 121;
            easy[14].corect = 3;

            easy[15].ec = "99-46";
            easy[15].a = 53;
            easy[15].b = 43;
            easy[15].c = 49;
            easy[15].corect = 1;

            easy[16].ec = "20x3+2";
            easy[16].a = 42;
            easy[16].b = 62;
            easy[16].c = 82;
            easy[16].corect = 2;

            easy[17].ec = "8x9";
            easy[17].a = 70;
            easy[17].b = 62;
            easy[17].c = 72;
            easy[17].corect = 3;

            easy[18].ec = "3x6";
            easy[18].a = 15;
            easy[18].b = 18;
            easy[18].c = 24;
            easy[18].corect = 2;

            easy[19].ec = "5x5+5";
            easy[19].a = 30;
            easy[19].b = 20;
            easy[19].c = 35;
            easy[19].corect = 1;

            easy[20].ec = "11+12-13";
            easy[20].a = 10;
            easy[20].b = 9;
            easy[20].c = 12;
            easy[20].corect = 1;

            ///
            mediu[0].ec = "10x10+10-10";
            mediu[0].a = 110;
            mediu[0].b = 100;
            mediu[0].c = 120;
            mediu[0].corect = 2;

            mediu[1].ec = "sin(30°)";
            mediu[1].a = 0.25;
            mediu[1].b = 1;
            mediu[1].c = 0.5;
            mediu[1].corect = 3;

            mediu[2].ec = "cos(60°)";
            mediu[2].a = 0.5;
            mediu[2].b = 1;
            mediu[2].c = 0.25;
            mediu[2].corect = 1;

            mediu[3].ec = "tan(45°)";
            mediu[3].a = 0;
            mediu[3].b = 1;
            mediu[3].c = 0.5;
            mediu[3].corect = 2;

            mediu[4].ec = "log10(1000)";
            mediu[4].a = 2;
            mediu[4].b = 1;
            mediu[4].c = 3;
            mediu[4].corect = 3;

            mediu[5].ec = "e⁰";
            mediu[5].a = 0;
            mediu[5].b = 1;
            mediu[5].c = 2.71;
            mediu[5].corect = 2;

            mediu[6].ec = "20% din 60";
            mediu[6].a = 12;
            mediu[6].b = 18;
            mediu[6].c = 20;
            mediu[6].corect = 1;

            mediu[7].ec = "√324";
            mediu[7].a = 19;
            mediu[7].b = 18;
            mediu[7].c = 16;
            mediu[7].corect = 2;

            mediu[8].ec = "78÷6";
            mediu[8].a = 13;
            mediu[8].b = 14;
            mediu[8].c = 12;
            mediu[8].corect = 3;

            mediu[9].ec = "|4-7|";
            mediu[9].a = 3;
            mediu[9].b = 2;
            mediu[9].c = 4;
            mediu[9].corect = 1;
            
            mediu[10].ec = "18÷6x2";
            mediu[10].a = 1;
            mediu[10].b = 6;
            mediu[10].c = 3;
            mediu[10].corect = 2;

            mediu[11].ec = "(2+3)²";
            mediu[11].a = 10;
            mediu[11].b = 13;
            mediu[11].c = 25;
            mediu[11].corect = 3;

            mediu[12].ec = "(7-2)x(6+1)";
            mediu[12].a = 35;
            mediu[12].b = 30;
            mediu[12].c = 42;
            mediu[12].corect = 1;

            mediu[13].ec = "(2/5)x100";
            mediu[13].a = 50;
            mediu[13].b = 40;
            mediu[13].c = 25;
            mediu[13].corect = 2;

            mediu[14].ec = "(8-3)³";
            mediu[14].a = 64;
            mediu[14].b = 25;
            mediu[14].c = 125;
            mediu[14].corect = 3;

            mediu[15].ec = "4!";
            mediu[15].a = 24;
            mediu[15].b = 12;
            mediu[15].c = 32;
            mediu[15].corect = 1;

            mediu[16].ec = "4⁴";
            mediu[16].a = 64;
            mediu[16].b = 256;
            mediu[16].c = 144;
            mediu[16].corect = 2;

            mediu[17].ec = "ln(1)";
            mediu[17].a = -1;
            mediu[17].b = 1;
            mediu[17].c = 0;
            mediu[17].corect = 3;

            mediu[18].ec = "log3(27)";
            mediu[18].a = 3;
            mediu[18].b = 9;
            mediu[18].c = 6;
            mediu[18].corect = 1;

            mediu[19].ec = "∛64";
            mediu[19].a = 8;
            mediu[19].b = 4;
            mediu[19].c = 6;
            mediu[19].corect = 2;

            mediu[20].ec = "|-7+3-(-5)|";
            mediu[20].a = 2;
            mediu[20].b = 0;
            mediu[20].c = 1;
            mediu[20].corect = 3;

            ///
            
            hard[0].ec = "15²+3×8";
            hard[0].a = 249;
            hard[0].b = 239;
            hard[0].c = 219;
            hard[0].corect = 1;

            hard[1].ec = "√256+∛125";
            hard[1].a = 31;
            hard[1].b = 21;
            hard[1].c = 19;
            hard[1].corect = 2;
            
            hard[2].ec = "sin(150°)";
            hard[2].a = 0.25;
            hard[2].b = 1;
            hard[2].c = 0.5;
            hard[2].corect = 3;

            hard[3].ec = "(4√2)²";
            hard[3].a = 32;
            hard[3].b = 16;
            hard[3].c = 24;
            hard[3].corect = 1;

            hard[4].ec = "12x14";
            hard[4].a = 188;
            hard[4].b = 168;
            hard[4].c = 164;
            hard[4].corect = 2;

            hard[5].ec = "[π]";
            hard[5].a = 2;
            hard[5].b = 4;
            hard[5].c = 3;
            hard[5].corect = 3;

            hard[6].ec = "[-π]";
            hard[6].a = -4;
            hard[6].b = -3;
            hard[6].c = 3;
            hard[6].corect = 1;

            hard[7].ec = "log2(1024)";
            hard[7].a = 12;
            hard[7].b = 10;
            hard[7].c = 8;
            hard[7].corect = 2;           
            
            hard[8].ec = "(log₃81)²";
            hard[8].a = 4;
            hard[8].b = 9;
            hard[8].c = 16;
            hard[8].corect = 3;

            hard[9].ec = "(15-7)x(13+8)";
            hard[9].a = 168;
            hard[9].b = 160;
            hard[9].c = 174;
            hard[9].corect = 1;

            hard[10].ec = "√625x3+5";
            hard[10].a = 45;
            hard[10].b = 50;
            hard[10].c = 55;
            hard[10].corect = 2;

            hard[11].ec = "(√5x√10)²+17";
            hard[11].a = 57;
            hard[11].b = 37;
            hard[11].c = 67;
            hard[11].corect = 3;

            hard[12].ec = "∛27+3÷3";
            hard[12].a = 4;
            hard[12].b = 2;
            hard[12].c = 3;
            hard[12].corect = 1;

            hard[13].ec = "69÷3x4+2";
            hard[13].a = 44;
            hard[13].b = 54;
            hard[13].c = 52;
            hard[13].corect = 2;

            hard[14].ec = "[-e]";
            hard[14].a = -2;
            hard[14].b = -1;
            hard[14].c = -3;
            hard[14].corect = 3;

            hard[15].ec = "{-2,73}";
            hard[15].a = 0.27;
            hard[15].b = 0.73;
            hard[15].c = 0.37;
            hard[15].corect = 1;
            
            hard[16].ec = "[-9/2]";
            hard[16].a = -4;
            hard[16].b = -5;
            hard[16].c = -4.5;
            hard[16].corect = 2;

            hard[17].ec = "1+2+...+20";
            hard[17].a = 200;
            hard[17].b = 190;
            hard[17].c = 210;
            hard[17].corect = 3;

            hard[18].ec = "{-3/9}";
            hard[18].a = 0.67;
            hard[18].b = 0.33;
            hard[18].c = 0.77;
            hard[18].corect = 1;

            hard[19].ec = "(√2x√8)/2²";
            hard[19].a = 2;
            hard[19].b = 1;
            hard[19].c = 4;
            hard[19].corect = 2;

            hard[20].ec = "6÷2(1+2)";
            hard[20].a = 6;
            hard[20].b = 1;
            hard[20].c = 9;
            hard[20].corect = 3;
            
            InitializeComponent();
        }
        
        int num;
        bool apasat = true;
        int c;

        //generare joc
        void start()
        {
            if (Int32.Parse(label3.Text) == 10)
            {
                this.Hide();
                PLAYER1 x = new PLAYER1();
                x.Show();
            }
            else if(Int32.Parse(label4.Text) == 10)
            {
                this.Hide();
                PLAYER2 y = new PLAYER2();
                y.Show();
            }
            label7.Text = " ";
            button1.BackColor = Color.Transparent; ;
            button2.BackColor = Color.Transparent; ;
            button3.BackColor = Color.Transparent; ;
                c++;
                if (c <= 6)
                {
                    Random rnd = new Random();
                    num = rnd.Next(21);
                    while(easy[num].ok==true)
                    {
                        num = rnd.Next(21);
                    }

                    
                    easy[num].ok = true;
                    label5.Text = easy[num].ec;
                    button1.Text = easy[num].a.ToString();
                    button2.Text = easy[num].b.ToString();
                    button3.Text = easy[num].c.ToString();
                 
                    apasat = false;

               /// MessageBox.Show(c.ToString());


                   


                }
                else if (c <= 14)
                {

                    Random rnd = new Random();
                    num = rnd.Next(21);
                    while (mediu[num].ok == true)
                    {
                        num = rnd.Next(21);
                    }


                    mediu[num].ok = true;
                    label5.Text = mediu[num].ec;
                    button1.Text = mediu[num].a.ToString();
                    button2.Text = mediu[num].b.ToString();
                    button3.Text = mediu[num].c.ToString();

                    apasat = false;
            }
                else if (c <= 20)
                {

                    Random rnd = new Random();
                    num = rnd.Next(21);
                    while (hard[num].ok == true)
                    {
                        num = rnd.Next(21);
                    }


                    hard[num].ok = true;
                    label5.Text = hard[num].ec;
                    button1.Text = hard[num].a.ToString();
                    button2.Text = hard[num].b.ToString();
                    button3.Text = hard[num].c.ToString();

                    apasat = false;
            }
           

          
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            pictureBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label6.Visible = true;

            label3.Text = "0";
            label4.Text = "0";
            label5.Text = " ";
            label7.Text = " ";
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            timer1.Start();
        }


        //start joc
        int timeleft = 3,timeleft2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft>1)
            {
                timeleft--;
                label6.Text = timeleft.ToString();
            }
            else if(timeleft==1)
            {
                timeleft--;
                label6.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                pictureBox1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                c = 0;
                for (int i = 0; i <= 20; ++i) easy[i].ok = false;
                for (int i = 0; i <= 20; ++i) mediu[i].ok = false;
                for (int i = 0; i <= 20; ++i) hard[i].ok = false;
                start();
            }
            
        }

        //verif raspuns
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(apasat==false)
            {
                if(c<=6)
                {


                    if (e.KeyCode == Keys.A)
                    {
                        apasat = true;
                        if (easy[num].corect == 1)
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button1.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        else
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button1.BackColor = Color.Red;
                            if (easy[num].corect == 2) button2.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();


                    }
                    else if (e.KeyCode == Keys.S)
                    {
                        apasat = true;
                        if (easy[num].corect == 2)
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        else
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button2.BackColor = Color.Red;
                            if (easy[num].corect == 1) button1.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.D)
                    {
                        apasat = true;
                        if (easy[num].corect == 3)
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        else
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button3.BackColor = Color.Red;
                            if (easy[num].corect == 1) button1.BackColor = Color.Green;
                            else button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.Left)
                    {
                        apasat = true;
                        if (easy[num].corect == 1)
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button1.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        else
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button1.BackColor = Color.Red;
                            if (easy[num].corect == 2) button2.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        apasat = true;
                        if (easy[num].corect == 2)
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        else
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button2.BackColor = Color.Red;
                            if (easy[num].corect == 1) button1.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.Right)
                    {
                        apasat = true;
                        if (easy[num].corect == 3)
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        else
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button3.BackColor = Color.Red;
                            if (easy[num].corect == 1) button1.BackColor = Color.Green;
                            else button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();
                    }
                }
                else if(c<=14)
                {
                    if (e.KeyCode == Keys.A)
                    {
                        apasat = true;
                        if (mediu[num].corect == 1)
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button1.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        else
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button1.BackColor = Color.Red;
                            if (mediu[num].corect == 2) button2.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();


                    }
                    else if (e.KeyCode == Keys.S)
                    {
                        apasat = true;
                        if (mediu[num].corect == 2)
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        else
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button2.BackColor = Color.Red;
                            if (mediu[num].corect == 1) button1.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.D)
                    {
                        apasat = true;
                        if (mediu[num].corect == 3)
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        else
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button3.BackColor = Color.Red;
                            if (mediu[num].corect == 1) button1.BackColor = Color.Green;
                            else button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.Left)
                    {
                        apasat = true;
                        if (mediu[num].corect == 1)
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button1.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        else
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button1.BackColor = Color.Red;
                            if (mediu[num].corect == 2) button2.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        apasat = true;
                        if (mediu[num].corect == 2)
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        else
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button2.BackColor = Color.Red;
                            if (mediu[num].corect == 1) button1.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.Right)
                    {
                        apasat = true;
                        if (mediu[num].corect == 3)
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        else
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button3.BackColor = Color.Red;
                            if (mediu[num].corect == 1) button1.BackColor = Color.Green;
                            else button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();
                    }
                }
                else if(c<=20)
                {
                    if (e.KeyCode == Keys.A)
                    {
                        apasat = true;
                        if (hard[num].corect == 1)
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button1.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        else
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button1.BackColor = Color.Red;
                            if (hard[num].corect == 2) button2.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();


                    }
                    else if (e.KeyCode == Keys.S)
                    {
                        apasat = true;
                        if (hard[num].corect == 2)
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        else
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button2.BackColor = Color.Red;
                            if (hard[num].corect == 1) button1.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.D)
                    {
                        apasat = true;
                        if (hard[num].corect == 3)
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        else
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button3.BackColor = Color.Red;
                            if (hard[num].corect == 1) button1.BackColor = Color.Green;
                            else button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.Left)
                    {
                        apasat = true;
                        if (hard[num].corect == 1)
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button1.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        else
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button1.BackColor = Color.Red;
                            if (hard[num].corect == 2) button2.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        apasat = true;
                        if (hard[num].corect == 2)
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        else
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button2.BackColor = Color.Red;
                            if (hard[num].corect == 1) button1.BackColor = Color.Green;
                            else button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();

                    }
                    else if (e.KeyCode == Keys.Right)
                    {
                        apasat = true;
                        if (hard[num].corect == 3)
                        {
                            label4.Text = (Int32.Parse(label4.Text) + 1).ToString();
                            button3.BackColor = Color.Green;
                            label7.Text = "PLAYER 2 WON";
                        }
                        else
                        {
                            label3.Text = (Int32.Parse(label3.Text) + 1).ToString();
                            button3.BackColor = Color.Red;
                            if (hard[num].corect == 1) button1.BackColor = Color.Green;
                            else button2.BackColor = Color.Green;
                            label7.Text = "PLAYER 1 WON";
                        }
                        timeleft2 = 2;
                        timer2.Start();
                    }
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //timp verif raspuns
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(timeleft2>1)
            {
                timeleft2--;
            }
            else if(timeleft2==1)
            {
                timeleft2--;
                if (Int32.Parse(label3.Text) <= 10 && Int32.Parse(label4.Text) <= 10 && c <= 20) start();
            }
        }
    }
}
