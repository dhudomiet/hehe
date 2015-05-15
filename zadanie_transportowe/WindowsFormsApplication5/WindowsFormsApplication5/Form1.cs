using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] tab1 = new int[3, 3];//głowna
            int[] tab2 = new int[3];//odbiorcy
            int[] tab3 = new int[3];//dostawcy
            int[,] tab4 = new int[3, 3];
            int[,] tab7 = new int[3, 3];
            string line = string.Empty;
            int[] tab5 = new int[3];//xi
            int[] tab6 = new int[3];//bi

            tab2[0] = int.Parse(textBox4.Text);
            tab2[1] = int.Parse(textBox8.Text);
            tab2[2] = int.Parse(textBox12.Text);

            tab3[0] = int.Parse(textBox1.Text);
            tab3[1] = int.Parse(textBox2.Text);
            tab3[2] = int.Parse(textBox3.Text);

            tab1[0, 0] = int.Parse(textBox5.Text);
            tab1[0, 1] = int.Parse(textBox6.Text);
            tab1[0, 2] = int.Parse(textBox7.Text);
            tab1[1, 0] = int.Parse(textBox9.Text);
            tab1[1, 1] = int.Parse(textBox10.Text);
            tab1[1, 2] = int.Parse(textBox11.Text);
            tab1[2, 0] = int.Parse(textBox13.Text);
            tab1[2, 1] = int.Parse(textBox14.Text);
            tab1[2, 2] = int.Parse(textBox15.Text);

            textBox25.Text = "";
            textBox24.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox21.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
            textBox38.Text = "";
            textBox37.Text = "";
            textBox36.Text = "";
            textBox35.Text = "";
            textBox34.Text = "";
            textBox33.Text = "";
            textBox32.Text = "";


            textBox28.Text = "";
            textBox27.Text = "";
            textBox26.Text = "";
            textBox31.Text = "";
            textBox30.Text = "";
            textBox29.Text = "";
            textBox42.Text = "";
            textBox41.Text = "";

            
            int z = tab3[0] + tab3[1] + tab3[2];
            textBox42.AppendText(z + "");
            
           
            int zc = tab2[0] + tab2[1] + tab2[2];
            textBox41.AppendText(zc + "");

            for (int p = 0; p <= 2; p++)
            {
                for (int q = 0; q <= 2; q++)
                {
                    tab4[p, q] = 0;
                }
            }
            int wart = 0;
            for (int t = 0; t < 20; t++)
            {
                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (tab1[j, i] == t && tab2[j] != 0)
                        {
                            wart = tab2[j] - tab3[i];
                            if (wart >= 0)
                            {
                                tab4[j, i] = tab3[i];
                                tab2[j] = tab2[j] - tab3[i];
                                tab3[i] = 0;
                            }
                            if (wart < 0)
                            {
                                tab4[j, i] = tab2[j];
                                tab3[i] = tab3[i] - tab2[j];
                                tab2[j] = 0;
                            }
                        }
                    }
                }
            }
            //---------------------------------
            tab5[0] = 0;
            if (tab4[0, 0] != 0)
            {
                tab6[0] = tab1[0, 0] - tab5[0];

            }
            if (tab4[1, 0] != 0)
            {
                tab6[1] = tab1[1, 0] - tab5[0];

            }
            if (tab4[2, 0] != 0)
            {
                tab6[2] = tab1[2, 0] - tab5[0];

            }
            //-----------------------------------

            if (tab4[0, 1] != 0 && tab6[0] != 0)
            {
                tab5[1] = tab1[0, 1] - tab6[0];


            }
            if (tab4[1, 1] != 0 && tab6[1] != 0)
            {
                tab5[1] = tab1[1, 1] - tab6[1];


            }
            if (tab4[2, 1] != 0 && tab6[2] != 0)
            {
                tab5[1] = tab1[2, 1] - tab6[2];


            }
            
            //-----------------------------------
            if (tab4[0, 1] != 0 && tab5[1] != 0)
            {
                tab6[0] = tab1[0, 1] - tab5[1];

            }
            if (tab4[1, 1] != 0 && tab5[1] != 0)
            {
                tab6[1] = tab1[1, 1] - tab5[1];


            }
            if (tab4[2, 1] != 0 && tab5[1] != 0)
            {
                tab6[2] = tab1[2, 1] - tab5[1];


            }
            //-----------....................
            if (tab4[0, 2] != 0 && tab6[0] != 0)
            {
                tab5[2] = tab1[0, 2] - tab6[0];


            }
            if (tab4[1, 2] != 0 && tab6[1] != 0)
            {
                tab5[2] = tab1[1, 2] - tab6[1];


            }
            if (tab4[2, 2] != 0 && tab6[2] != 0)
            {
                tab5[2] = tab1[2, 2] - tab6[2];


            }
            //-----------------------------------------------------------------
            if (tab4[0, 2] != 0 && tab5[2] != 0)
            {
                tab6[0] = tab1[0, 2] - tab5[2];

            }
            if (tab4[1, 2] != 0 && tab5[2] != 0)
            {
                tab6[1] = tab1[1, 2] - tab5[2];


            }
            if (tab4[2, 2] != 0 && tab5[2] != 0)
            {
                tab6[2] = tab1[2, 2] - tab5[2];


            }
            //--------
            if (tab4[0, 1] != 0 && tab6[0] != 0)
            {
                tab5[1] = tab1[0, 1] - tab6[0];


            }
            if (tab4[1, 1] != 0 && tab6[1] != 0)
            {
                tab5[1] = tab1[1, 1] - tab6[1];


            }
            if (tab4[2, 1] != 0 && tab6[2] != 0)
            {
                tab5[1] = tab1[2, 1] - tab6[2];


            }
            //-----------
            if (tab4[0, 1] != 0 && tab5[1] != 0)
            {
                tab6[0] = tab1[0, 1] - tab5[1];

            }
            if (tab4[1, 1] != 0 && tab5[1] != 0)
            {
                tab6[1] = tab1[1, 1] - tab5[1];


            }
            if (tab4[2, 1] != 0 && tab5[1] != 0)
            {
                tab6[2] = tab1[2, 1] - tab5[1];
            }
            //--------------------------------------
         
            textBox25.AppendText(tab4[0, 0] + "");
            textBox24.AppendText(tab4[0, 1] + "");
            textBox23.AppendText(tab4[0, 2] + "");
            textBox22.AppendText(tab4[1, 0] + "");
            textBox21.AppendText(tab4[1, 1] + "");
            textBox20.AppendText(tab4[1, 2] + "");
            textBox19.AppendText(tab4[2, 0] + "");
            textBox18.AppendText(tab4[2, 1] + "");
            textBox17.AppendText(tab4[2, 2] + "");



            textBox28.AppendText(tab5[0] + "");
            textBox27.AppendText(tab5[1] + "");
            textBox26.AppendText(tab5[2] + "");
            textBox31.AppendText(tab6[0] + "");
            textBox30.AppendText(tab6[1] + "");
            textBox29.AppendText(tab6[2] + "");

            //------------------------------- 
            for (int g = 0; g <= 2; g++)
            {
                for (int f = 0; f <= 2; f++)
                {
                    if (tab4[f, g] == 0)
                    {
                        tab7[f, g] = tab1[f, g] - tab5[g] - tab6[f];
                    }

                }
            }

            textBox40.AppendText(tab7[0, 0] + "");
            textBox39.AppendText(tab7[0, 1] + "");
            textBox38.AppendText(tab7[0, 2] + "");
            textBox37.AppendText(tab7[1, 0] + "");
            textBox36.AppendText(tab7[1, 1] + "");
            textBox35.AppendText(tab7[1, 2] + "");
            textBox34.AppendText(tab7[2, 0] + "");
            textBox33.AppendText(tab7[2, 1] + "");
            textBox32.AppendText(tab7[2, 2] + "");

            
            

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox42.Text = "";
            textBox41.Text = "";
            textBox25.Text = "";
            textBox24.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox21.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
            textBox38.Text = "";
            textBox37.Text = "";
            textBox36.Text = "";
            textBox35.Text = "";
            textBox34.Text = "";
            textBox33.Text = "";
            textBox32.Text = "";


            textBox28.Text = "";
            textBox27.Text = "";
            textBox26.Text = "";
            textBox31.Text = "";
            textBox30.Text = "";
            textBox29.Text = "";
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[,] tab1 = new int[3, 3];//głowna
            int[] tab2 = new int[3];//odbiorcy
            int[] tab3 = new int[3];//dostawcy
            int[,] tab4 = new int[3, 3];
            int[,] tab7 = new int[3, 3];
            string line = string.Empty;
            int[] tab5 = new int[3];//xi
            int[] tab6 = new int[3];//bi
            int blok = 0;


            tab5[1] = 0;
            tab5[2] = 0;
            tab5[0] = 0;
            tab6[0] = 0;
            tab6[1] = 0;
            tab6[2] = 0;
            tab1[0, 0] = int.Parse(textBox5.Text);
            tab1[0, 1] = int.Parse(textBox6.Text);
            tab1[0, 2] = int.Parse(textBox7.Text);
            tab1[1, 0] = int.Parse(textBox9.Text);
            tab1[1, 1] = int.Parse(textBox10.Text);
            tab1[1, 2] = int.Parse(textBox11.Text);
            tab1[2, 0] = int.Parse(textBox13.Text);
            tab1[2, 1] = int.Parse(textBox14.Text);
            tab1[2, 2] = int.Parse(textBox15.Text);

            tab7[0, 0] = int.Parse(textBox40.Text);
            tab7[0, 1] = int.Parse(textBox39.Text);
            tab7[0, 2] = int.Parse(textBox38.Text);
            tab7[1, 0] = int.Parse(textBox37.Text);
            tab7[1, 1] = int.Parse(textBox36.Text);
            tab7[1, 2] = int.Parse(textBox35.Text);
            tab7[2, 0] = int.Parse(textBox34.Text);
            tab7[2, 1] = int.Parse(textBox33.Text);
            tab7[2, 2] = int.Parse(textBox32.Text);

            tab4[0, 0] = int.Parse(textBox25.Text);
            tab4[0, 1] = int.Parse(textBox24.Text);
            tab4[0, 2] = int.Parse(textBox23.Text);
            tab4[1, 0] = int.Parse(textBox22.Text);
            tab4[1, 1] = int.Parse(textBox21.Text);
            tab4[1, 2] = int.Parse(textBox20.Text);
            tab4[2, 0] = int.Parse(textBox19.Text);
            tab4[2, 1] = int.Parse(textBox18.Text);
            tab4[2, 2] = int.Parse(textBox17.Text);

            textBox25.Text="";
            textBox24.Text="";
            textBox23.Text="";
            textBox22.Text="";
            textBox21.Text="";
            textBox20.Text="";
            textBox19.Text="";
            textBox18.Text="";
            textBox17.Text="";
            textBox40.Text="";
            textBox39.Text="";
            textBox38.Text="";
            textBox37.Text="";
            textBox36.Text="";
            textBox35.Text="";
            textBox34.Text="";
            textBox33.Text="";
            textBox32.Text="";


            textBox28.Text="";
            textBox27.Text="";
            textBox26.Text="";
            textBox31.Text="";
            textBox30.Text="";
            textBox29.Text = "";

            for (int d = -10; d < 0; d++)
            {
                if (tab7[0, 0] == d && blok == 0)//0,0
                {


                    if (tab7[0, 1] == 0 && tab7[1, 0] == 0 && tab7[1, 1] == 0 && blok == 0)//1,1
                    {
                        if (tab4[0, 1] > tab4[1, 0])
                        {
                            tab4[0, 0] = tab4[1, 0];
                            tab4[0, 1] = tab4[0, 1] - tab4[1, 0];
                            tab4[1, 1] = tab4[1, 1] + tab4[1, 0];
                            tab4[1, 0] = 0;

                            tab7[0, 0] = 0;
                        }
                        if (tab4[0, 1] < tab4[1, 0])
                        {
                            tab4[0, 0] = tab4[0, 1];
                            tab4[1, 0] = tab4[1, 0] - tab4[0, 1];
                            tab4[1, 1] = tab4[1, 1] + tab4[0, 1]; ;
                            tab4[0, 1] = 0;

                            tab7[0, 0] = 0;
                        }


                        blok = 1;
                    }
                    if (tab7[0, 1] == 0 && tab7[2, 0] == 0 && tab7[2, 1] == 0 && blok == 0)//2,1
                    {
                        if (tab4[0, 1] > tab4[2, 0])
                        {
                            tab4[0, 0] = tab4[2, 0];
                            tab4[0, 1] = tab4[0, 1] - tab4[2, 0];
                            tab4[2, 1] = tab4[2, 1] + tab4[2, 0];
                            tab4[2, 0] = 0;

                            tab7[0, 0] = 0;
                        }
                        if (tab4[0, 1] < tab4[2, 0])
                        {
                            tab4[0, 0] = tab4[0, 1];
                            tab4[2, 0] = tab4[2, 0] - tab4[0, 1];
                            tab4[2, 1] = tab4[2, 1] + tab4[0, 1]; ;
                            tab4[0, 1] = 0;

                            tab7[0, 0] = 0;
                        }

                        blok = 1;
                    }
                    if (tab7[0, 2] == 0 && tab7[1, 0] == 0 && tab7[1, 2] == 0 && blok == 0)//1,2
                    {
                        if (tab4[0, 2] > tab4[1, 0])
                        {
                            tab4[0, 0] = tab4[1, 0];
                            tab4[0, 2] = tab4[0, 2] - tab4[1, 0];
                            tab4[2, 1] = tab4[2, 1] + tab4[1, 0];
                            tab4[1, 0] = 0;

                            tab7[0, 0] = 0;
                        }
                        if (tab4[0, 1] < tab4[2, 0])
                        {
                            tab4[0, 0] = tab4[0, 1];
                            tab4[2, 0] = tab4[2, 0] - tab4[0, 1];
                            tab4[2, 1] = tab4[2, 1] + tab4[0, 1]; ;
                            tab4[0, 1] = 0;

                            tab7[0, 0] = 0;
                        }

                        blok = 1;
                    }
                    if (tab7[0, 2] == 0 && tab7[2, 0] == 0 && tab7[2, 2] == 0 && blok == 0)//2,2
                    {
                        if (tab4[0, 2] > tab4[2, 0])
                        {
                            tab4[0, 0] = tab4[2, 0];
                            tab4[0, 2] = tab4[0, 2] - tab4[2, 0];
                            tab4[2, 2] = tab4[2, 2] + tab4[2, 0];
                            tab4[2, 0] = 0;

                            tab7[0, 0] = 0;
                        }
                        if (tab4[0, 2] < tab4[2, 0])
                        {
                            tab4[0, 0] = tab4[0, 2];
                            tab4[2, 0] = tab4[2, 0] - tab4[0, 2];
                            tab4[2, 2] = tab4[2, 2] + tab4[0, 2]; ;
                            tab4[0, 2] = 0;

                            tab7[0, 0] = 0;
                        }

                        blok = 1;
                    }
                    

                }
                if (tab7[0, 1] == d && blok == 0)//0,1
                {
                    if (tab7[0, 0] == 0 && tab7[1, 0] == 0 && tab7[1, 1] == 0 && blok == 0)//1,0
                    {

                        blok = 1;
                        if (tab4[0, 0] > tab4[1, 1])
                        {
                            tab4[0, 1] = tab4[1, 1];
                            tab4[0, 0] = tab4[0, 0] - tab4[1, 1];
                            tab4[1, 0] = tab4[1, 0] + tab4[1, 1];
                            tab4[1, 1] = 0;

                            tab7[0, 1] = 0;
                        }
                        if (tab4[0, 0] < tab4[1, 0])
                        {
                            tab4[0, 1] = tab4[0, 0];
                            tab4[1, 0] = tab4[1, 0] + tab4[0, 0];
                            tab4[1, 1] = tab4[1, 1] - tab4[0, 0]; ;
                            tab4[0, 0] = 0;

                            tab7[0, 1] = 0;
                        }
                    }
                    if (tab7[1, 1] == 0 && tab7[1, 2] == 0 && tab7[0, 2] == 0 && blok == 0)//1,2
                    {
                        if (tab4[0, 2] > tab4[1, 1])
                        {
                            tab4[0, 1] = tab4[1, 1];
                            tab4[0, 2] = tab4[0, 2] - tab4[1, 1];
                            tab4[1, 2] = tab4[1, 2] + tab4[1, 1];
                            tab4[1, 1] = 0;

                            tab7[0, 1] = 0;
                        }
                        if (tab4[0, 2] < tab4[1, 1])
                        {
                            tab4[0, 1] = tab4[0, 2];
                            tab4[1, 1] = tab4[1, 1] - tab4[0, 2];
                            tab4[1, 2] = tab4[1, 2] + tab4[0, 2]; ;
                            tab4[0, 2] = 0;

                            tab7[0, 1] = 0;
                        }

                        blok = 1;
                    }
                    if (tab7[0, 0] == 0 && tab7[2, 0] == 0 && tab7[2, 1] == 0 && blok == 0)//2,1
                    {
                        if (tab4[0, 0] > tab4[2, 1])
                        {
                            tab4[0, 1] = tab4[2, 1];
                            tab4[0, 0] = tab4[0, 0] - tab4[2, 1];
                            tab4[2, 0] = tab4[2, 0] + tab4[2, 1];
                            tab4[2, 1] = 0;

                            tab7[0, 1] = 0;
                        }
                        if (tab4[0, 0] < tab4[2, 1])
                        {
                            tab4[0, 1] = tab4[0, 0];
                            tab4[2, 1] = tab4[2, 1] - tab4[0, 0];
                            tab4[2, 0] = tab4[2, 0] + tab4[0, 0]; ;
                            tab4[0, 0] = 0;

                            tab7[0, 1] = 0;
                        }

                        blok = 1;
                    }
                    if (tab7[0, 2] == 0 && tab7[2, 1] == 0 && tab7[2, 2] == 0 && blok == 0)//2,2
                    {
                        if (tab4[0, 2] > tab4[2, 1])
                        {
                            tab4[0, 1] = tab4[2, 1];
                            tab4[0, 2] = tab4[0, 2] - tab4[2, 1];
                            tab4[2, 2] = tab4[2, 2] + tab4[2, 1];
                            tab4[2, 1] = 0;

                            tab7[0, 1] = 0;
                        }
                        if (tab4[0, 2] < tab4[2, 1])
                        {
                            tab4[0, 1] = tab4[0, 2];
                            tab4[2, 1] = tab4[2, 1] - tab4[0, 2];
                            tab4[2, 2] = tab4[2, 2] + tab4[0, 2]; ;
                            tab4[0, 2] = 0;

                            tab7[0, 1] = 0;
                        }

                        blok = 1;
                    }
                    

                }
                if (tab7[0, 2] == d && blok == 0)//0,2
                {
                    if (tab7[0, 0] == 0 && tab7[1, 0] == 0 && tab7[1, 2] == 0 && blok == 0)//1,0
                    {
                        if (tab4[0, 0] > tab4[1, 2])
                        {
                            tab4[0, 2] = tab4[1, 2];
                            tab4[0, 0] = tab4[0, 0] - tab4[1, 2];
                            tab4[1, 0] = tab4[1, 0] + tab4[1, 2];
                            tab4[1, 2] = 0;

                            tab7[0, 2] = 0;
                        }
                        if (tab4[0, 0] < tab4[1, 2])
                        {
                            tab4[0, 2] = tab4[0, 0];
                            tab4[1, 2] = tab4[1, 2] - tab4[0, 0];
                            tab4[1, 0] = tab4[1, 0] + tab4[0, 0]; ;
                            tab4[0, 0] = 0;

                            tab7[0, 2] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 1] == 0 && tab7[1, 1] == 0 && tab7[1, 2] == 0 && blok == 0)//1,1
                    {
                        if (tab4[0, 1] > tab4[1, 2])
                        {
                            tab4[0, 2] = tab4[1, 2];
                            tab4[0, 1] = tab4[0, 1] - tab4[1, 2];
                            tab4[1, 1] = tab4[1, 1] + tab4[1, 2];
                            tab4[1, 2] = 0;

                            tab7[0, 2] = 0;
                        }
                        if (tab4[0, 1] < tab4[1, 2])
                        {
                            tab4[0, 2] = tab4[0, 1];
                            tab4[1, 2] = tab4[1, 2] - tab4[0, 1];
                            tab4[1, 1] = tab4[1, 1] + tab4[0, 1]; ;
                            tab4[0, 1] = 0;

                            tab7[0, 2] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 1] == 0 && tab7[2, 1] == 0 && tab7[2, 2] == 0 && blok == 0)//2,1
                    {
                        if (tab4[0, 1] > tab4[2, 2])
                        {
                            tab4[0, 2] = tab4[2, 2];
                            tab4[0, 1] = tab4[0, 1] - tab4[2, 2];
                            tab4[2, 1] = tab4[2, 1] + tab4[2, 2];
                            tab4[2, 2] = 0;

                            tab7[0, 2] = 0;
                        }
                        if (tab4[0, 1] < tab4[2, 2])
                        {
                            tab4[0, 2] = tab4[0, 1];
                            tab4[2, 2] = tab4[2, 2] - tab4[0, 1];
                            tab4[2, 1] = tab4[2, 1] + tab4[0, 1];
                            tab4[0, 1] = 0;

                            tab7[0, 2] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 0] == 0 && tab7[2, 0] == 0 && tab7[2, 2] == 0 && blok == 0)//2,0
                    {
                        if (tab4[0, 0] > tab4[2, 2])
                        {
                            tab4[0, 2] = tab4[2, 2];
                            tab4[0, 0] = tab4[0, 0] - tab4[2, 2];
                            tab4[2, 0] = tab4[2, 0] + tab4[2, 2];
                            tab4[2, 2] = 0;

                            tab7[0, 2] = 0;
                        }
                        if (tab4[0, 0] < tab4[2, 2])
                        {
                            tab4[0, 2] = tab4[0, 0];
                            tab4[2, 2] = tab4[2, 2] - tab4[0, 0];
                            tab4[2, 0] = tab4[2, 0] + tab4[0, 0];
                            tab4[0, 0] = 0;

                            tab7[0, 2] = 0;
                        }
                        blok = 1;
                    }
                    

                }

                if (tab7[2, 0] == d && blok == 0)//2,0
                {
                    if (tab7[0, 0] == 0 && tab7[0, 1] == 0 && tab7[2, 1] == 0 && blok == 0)//0,1
                    {
                        if (tab4[0, 0] > tab4[2, 1])
                        {
                            tab4[2, 0] = tab4[2, 1];
                            tab4[0, 0] = tab4[0, 0] - tab4[2, 1];
                            tab4[0, 1] = tab4[0, 1] + tab4[2, 1];
                            tab4[2, 1] = 0;

                            tab7[2, 0] = 0;
                        }
                        if (tab4[0, 0] < tab4[2, 1])
                        {
                            tab4[2, 0] = tab4[0, 0];
                            tab4[2, 1] = tab4[2, 1] - tab4[0, 0];
                            tab4[0, 1] = tab4[0, 1] + tab4[0, 0];
                            tab4[0, 0] = 0;

                            tab7[2, 0] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[1, 0] == 0 && tab7[1, 1] == 0 && tab7[2, 1] == 0 && blok == 0)//1,1
                    {
                        if (tab4[1, 0] > tab4[2, 1])
                        {
                            tab4[2, 0] = tab4[2, 1];
                            tab4[1, 0] = tab4[1, 0] - tab4[2, 1];
                            tab4[1, 1] = tab4[1, 1] + tab4[2, 1];
                            tab4[2, 1] = 0;

                            tab7[2, 0] = 0;
                        }
                        if (tab4[1, 0] < tab4[2, 1])
                        {
                            tab4[2, 0] = tab4[1, 0];
                            tab4[2, 1] = tab4[2, 1] - tab4[1, 0];
                            tab4[1, 1] = tab4[1, 1] + tab4[1, 0];
                            tab4[1, 0] = 0;

                            tab7[2, 0] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[1, 0] == 0 && tab7[1, 2] == 0 && tab7[2, 2] == 0 && blok == 0)//1,2
                    {
                        if (tab4[1, 0] > tab4[2, 2])
                        {
                            tab4[2, 0] = tab4[2, 2];
                            tab4[1, 0] = tab4[1, 0] - tab4[2, 2];
                            tab4[1, 2] = tab4[1, 2] + tab4[2, 2];
                            tab4[2, 2] = 0;

                            tab7[2, 0] = 0;
                        }
                        if (tab4[1, 0] < tab4[2, 2])
                        {
                            tab4[2, 0] = tab4[1, 0];
                            tab4[2, 2] = tab4[2, 2] - tab4[1, 0];
                            tab4[1, 2] = tab4[1, 2] + tab4[1, 0];
                            tab4[1, 0] = 0;

                            tab7[2, 0] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 0] == 0 && tab7[0, 2] == 0 && tab7[2, 2] == 0 && blok == 0)//0,2
                    {
                        if (tab4[0, 0] > tab4[2, 2])
                        {
                            tab4[2, 0] = tab4[2, 2];
                            tab4[0, 0] = tab4[0, 0] - tab4[2, 2];
                            tab4[0, 2] = tab4[0, 2] + tab4[2, 2];
                            tab4[2, 2] = 0;

                            tab7[2, 0] = 0;
                        }
                        if (tab4[0, 0] < tab4[2, 2])
                        {
                            tab4[2, 0] = tab4[0, 0];
                            tab4[2, 2] = tab4[2, 2] - tab4[0, 0];
                            tab4[0, 2] = tab4[0, 2] + tab4[0, 0];
                            tab4[1, 0] = 0;

                            tab7[2, 0] = 0;
                        }
                        blok = 1;
                    }
                    
                }
                if (tab7[2, 0] == d && blok == 0)//2,1
                {
                    if (tab7[2, 0] == 0 && tab7[1, 0] == 0 && tab7[1, 1] == 0 && blok == 0)//1,0
                    {
                        if (tab4[1, 1] > tab4[2, 0])
                        {
                            tab4[2, 1] = tab4[2, 0];
                            tab4[1, 1] = tab4[1, 1] - tab4[2, 0];
                            tab4[1, 0] = tab4[1, 0] + tab4[2, 0];
                            tab4[2, 0] = 0;

                            tab7[2, 1] = 0;
                        }
                        if (tab4[1, 1] < tab4[2, 0])
                        {
                            tab4[2, 1] = tab4[1, 1];
                            tab4[2, 0] = tab4[2, 0] - tab4[1, 1];
                            tab4[1, 0] = tab4[1, 0] + tab4[1, 1];
                            tab4[1, 1] = 0;

                            tab7[2, 1] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[2, 0] == 0 && tab7[0, 0] == 0 && tab7[0, 1] == 0 && blok == 0)//0,0
                    {
                        if (tab4[0, 1] > tab4[2, 0])
                        {
                            tab4[2, 1] = tab4[2, 0];
                            tab4[0, 1] = tab4[0, 1] - tab4[2, 0];
                            tab4[0, 0] = tab4[0, 0] + tab4[2, 0];
                            tab4[2, 0] = 0;

                            tab7[2, 1] = 0;
                        }
                        if (tab4[0, 1] < tab4[2, 0])
                        {
                            tab4[2, 1] = tab4[0, 1];
                            tab4[2, 0] = tab4[2, 0] - tab4[0, 1];
                            tab4[0, 0] = tab4[0, 0] + tab4[0, 1];
                            tab4[0, 1] = 0;

                            tab7[2, 1] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[1, 1] == 0 && tab7[1, 2] == 0 && tab7[2, 2] == 0 && blok == 0)//1,2
                    {
                        if (tab4[1, 1] > tab4[2, 2])
                        {
                            tab4[2, 1] = tab4[2, 2];
                            tab4[1, 1] = tab4[1, 1] - tab4[2, 2];
                            tab4[0, 2] = tab4[0, 2] + tab4[2, 2];
                            tab4[2, 2] = 0;

                            tab7[2, 1] = 0;
                        }
                        if (tab4[1, 1] < tab4[2, 2])
                        {
                            tab4[2, 1] = tab4[1, 1];
                            tab4[2, 2] = tab4[2, 2] - tab4[1, 1];
                            tab4[0, 2] = tab4[0, 2] + tab4[1, 1];
                            tab4[1, 1] = 0;

                            tab7[2, 1] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 1] == 0 && tab7[0, 2] == 0 && tab7[2, 2] == 0 && blok == 0)//0,2
                    {
                        if (tab4[0, 1] > tab4[2, 2])
                        {
                            tab4[2, 1] = tab4[2, 2];
                            tab4[0, 1] = tab4[0, 1] - tab4[2, 2];
                            tab4[0, 2] = tab4[0, 2] + tab4[2, 2];
                            tab4[2, 2] = 0;

                            tab7[2, 1] = 0;
                        }
                        if (tab4[0, 1] < tab4[2, 2])
                        {
                            tab4[2, 1] = tab4[0, 1];
                            tab4[2, 2] = tab4[2, 2] - tab4[0, 1];
                            tab4[0, 2] = tab4[0, 2] + tab4[0, 1];
                            tab4[0, 1] = 0;

                            tab7[2, 1] = 0;
                        }
                        blok = 1;
                    }
                   
                }

                if (tab7[2, 2] == d && blok == 0)//2,2
                {


                    if (tab7[2, 1] == 0 && tab7[1, 1] == 0 && tab7[1, 2] == 0 && blok == 0)//1,1
                    {
                        if (tab4[1, 2] > tab4[2, 1])
                        {
                            tab4[2, 2] = tab4[2, 1];
                            tab4[1, 2] = tab4[1, 2] - tab4[2, 1];
                            tab4[1, 1] = tab4[1, 1] + tab4[2, 1];
                            tab4[2, 1] = 0;

                            tab7[2, 2] = 0;
                        }
                        if (tab4[1, 2] < tab4[2, 1])
                        {
                            tab4[2, 2] = tab4[1, 2];
                            tab4[2, 1] = tab4[2, 1] - tab4[1, 2];
                            tab4[1, 1] = tab4[1, 1] + tab4[1, 2];
                            tab4[1, 2] = 0;

                            tab7[2, 2] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[1, 0] == 0 && tab7[2, 0] == 0 && tab7[1, 2] == 0 && blok == 0)//0,1
                    {
                        if (tab4[1, 2] > tab4[2, 0])
                        {
                            tab4[2, 2] = tab4[2, 0];
                            tab4[1, 2] = tab4[1, 2] - tab4[2, 0];
                            tab4[1, 0] = tab4[1, 0] + tab4[2, 0];
                            tab4[2, 0] = 0;

                            tab7[2, 2] = 0;
                        }
                        if (tab4[1, 2] < tab4[2, 0])
                        {
                            tab4[2, 2] = tab4[1, 2];
                            tab4[2, 0] = tab4[2, 0] - tab4[1, 2];
                            tab4[1, 0] = tab4[1, 0] + tab4[1, 2];
                            tab4[1, 2] = 0;

                            tab7[2, 2] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 1] == 0 && tab7[2, 1] == 0 && tab7[0, 2] == 0 && blok == 0)//0,1
                    {
                        if (tab4[0, 2] > tab4[2, 1])
                        {
                            tab4[2, 2] = tab4[2, 1];
                            tab4[0, 2] = tab4[0, 2] - tab4[2, 1];
                            tab4[0, 1] = tab4[0, 1] + tab4[2, 1];
                            tab4[2, 1] = 0;

                            tab7[2, 2] = 0;
                        }
                        if (tab4[0, 2] < tab4[2, 1])
                        {
                            tab4[2, 2] = tab4[0, 2];
                            tab4[2, 1] = tab4[2, 1] - tab4[0, 2];
                            tab4[0, 1] = tab4[0, 1] + tab4[0, 2];
                            tab4[0, 2] = 0;

                            tab7[2, 2] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 0] == 0 && tab7[2, 0] == 0 && tab7[0, 2] == 0 && blok == 0)//0,0
                    {
                        if (tab4[0, 2] > tab4[2, 0])
                        {
                            tab4[2, 2] = tab4[2, 0];
                            tab4[0, 2] = tab4[0, 2] - tab4[2, 0];
                            tab4[0, 0] = tab4[0, 0] + tab4[2, 0];
                            tab4[2, 0] = 0;

                            tab7[2, 2] = 0;
                        }
                        if (tab4[0, 2] < tab4[2, 0])
                        {
                            tab4[2, 2] = tab4[0, 2];
                            tab4[2, 0] = tab4[2, 0] - tab4[0, 2];
                            tab4[0, 0] = tab4[0, 0] + tab4[0, 2];
                            tab4[0, 2] = 0;

                            tab7[2, 2] = 0;
                        }
                        blok = 1;
                    }
                    

                }
                if (tab7[1, 0] == d && blok == 0)//1,0
                {


                    if (tab7[0, 0] == 0 && tab7[0, 1] == 0 && tab7[1, 1] == 0 && blok == 0)//0,1
                    {
                        if (tab4[0, 0] > tab4[1, 1])
                        {
                            tab4[1, 0] = tab4[1, 1];
                            tab4[0, 0] = tab4[0, 0] - tab4[1, 1];
                            tab4[0, 1] = tab4[0, 1] + tab4[1, 1];
                            tab4[1, 1] = 0;

                            tab7[1, 0] = 0;
                        }
                        if (tab4[0, 0] < tab4[1, 1])
                        {
                            tab4[1, 0] = tab4[0, 0];
                            tab4[1, 1] = tab4[1, 1] - tab4[0, 0];
                            tab4[0, 1] = tab4[0, 1] + tab4[0, 0];
                            tab4[0, 0] = 0;

                            tab7[1, 0] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 0] == 0 && tab7[0, 2] == 0 && tab7[1, 2] == 0 && blok == 0)//0,2
                    {
                        if (tab4[0, 0] > tab4[1, 2])
                        {
                            tab4[1, 0] = tab4[1, 2];
                            tab4[0, 0] = tab4[0, 0] - tab4[1, 2];
                            tab4[0, 2] = tab4[0, 2] + tab4[1, 2];
                            tab4[1, 2] = 0;

                            tab7[1, 0] = 0;
                        }
                        if (tab4[0, 0] < tab4[1, 2])
                        {
                            tab4[1, 0] = tab4[0, 0];
                            tab4[1, 2] = tab4[1, 2] - tab4[0, 0];
                            tab4[0, 2] = tab4[0, 2] + tab4[0, 0];
                            tab4[0, 0] = 0;

                            tab7[1, 0] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[1, 1] == 0 && tab7[2, 1] == 0 && tab7[2, 0] == 0 && blok == 0)//2,1
                    {
                        if (tab4[1, 1] > tab4[2, 0])
                        {
                            tab4[1, 0] = tab4[2, 0];
                            tab4[1, 1] = tab4[1, 1] - tab4[2, 0];
                            tab4[2, 1] = tab4[2, 1] + tab4[2, 0];
                            tab4[2, 0] = 0;

                            tab7[1, 0] = 0;
                        }
                        if (tab4[1, 1] < tab4[2, 0])
                        {
                            tab4[1, 0] = tab4[1, 1];
                            tab4[2, 0] = tab4[2, 0] - tab4[1, 1];
                            tab4[2, 1] = tab4[2, 1] + tab4[1, 1];
                            tab4[1, 1] = 0;

                            tab7[1, 0] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[1, 2] == 0 && tab7[2, 0] == 0 && tab7[2, 2] == 0 && blok == 0)//2,2
                    {
                        if (tab4[1, 2] > tab4[2, 0])
                        {
                            tab4[1, 0] = tab4[2, 0];
                            tab4[1, 2] = tab4[1, 2] - tab4[2, 0];
                            tab4[2, 2] = tab4[2, 2] + tab4[2, 0];
                            tab4[2, 0] = 0;

                            tab7[1, 0] = 0;
                        }
                        if (tab4[1, 2] < tab4[2, 0])
                        {
                            tab4[1, 0] = tab4[1, 2];
                            tab4[2, 0] = tab4[2, 0] - tab4[1, 2];
                            tab4[2, 2] = tab4[2, 2] + tab4[1, 2];
                            tab4[1, 2] = 0;

                            tab7[1, 0] = 0;
                        }
                        blok = 1;
                    }
                   

                }

                if (tab7[1, 1] == d && blok == 0)//1,1
                {
                    if (tab7[0, 0] == 0 && tab7[0, 1] == 0 && tab7[1, 0] == 0 && blok == 0)//0,0
                    {
                        if (tab4[0, 1] > tab4[1, 0])
                        {
                            tab4[1, 1] = tab4[1, 0];
                            tab4[0, 1] = tab4[0, 1] - tab4[1, 0];
                            tab4[0, 0] = tab4[0, 0] + tab4[1, 0];
                            tab4[1, 0] = 0;

                            tab7[1, 1] = 0;
                        }
                        if (tab4[0, 1] < tab4[1, 0])
                        {
                            tab4[1, 1] = tab4[0, 1];
                            tab4[1, 0] = tab4[1, 0] - tab4[0, 1];
                            tab4[0, 0] = tab4[0, 0] + tab4[0, 1];
                            tab4[0, 1] = 0;

                            tab7[1, 1] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 1] == 0 && tab7[0, 2] == 0 && tab7[1, 2] == 0 && blok == 0)//0,2
                    {
                        if (tab4[0, 1] > tab4[1, 2])
                        {
                            tab4[1, 1] = tab4[1, 2];
                            tab4[0, 1] = tab4[0, 1] - tab4[1, 2];
                            tab4[0, 2] = tab4[0, 2] + tab4[1, 2];
                            tab4[1, 2] = 0;

                            tab7[1, 1] = 0;
                        }
                        if (tab4[0, 1] < tab4[1, 2])
                        {
                            tab4[1, 1] = tab4[0, 1];
                            tab4[1, 2] = tab4[1, 2] - tab4[0, 1];
                            tab4[0, 2] = tab4[0, 2] + tab4[0, 1];
                            tab4[0, 1] = 0;

                            tab7[1, 1] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[1, 0] == 0 && tab7[2, 0] == 0 && tab7[2, 1] == 0 && blok == 0)//2,0
                    {
                        if (tab4[1, 0] > tab4[2, 1])
                        {
                            tab4[1, 1] = tab4[2, 1];
                            tab4[1, 0] = tab4[1, 0] - tab4[2, 1];
                            tab4[2, 0] = tab4[2, 0] + tab4[2, 1];
                            tab4[2, 1] = 0;

                            tab7[1, 1] = 0;
                        }
                        if (tab4[1, 0] < tab4[2, 1])
                        {
                            tab4[1, 1] = tab4[1, 0];
                            tab4[2, 1] = tab4[2, 1] - tab4[1, 0];
                            tab4[2, 0] = tab4[2, 0] + tab4[1, 0];
                            tab4[1, 0] = 0;

                            tab7[1, 1] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[2, 1] == 0 && tab7[1, 2] == 0 && tab7[2, 2] == 0 && blok == 0)//2,2
                    {
                        if (tab4[1, 2] > tab4[2, 1])
                        {
                            tab4[1, 1] = tab4[2, 1];
                            tab4[1, 2] = tab4[1, 2] - tab4[2, 1];
                            tab4[2, 2] = tab4[2, 2] + tab4[2, 1];
                            tab4[2, 1] = 0;

                            tab7[1, 1] = 0;
                        }
                        if (tab4[1, 2] < tab4[2, 1])
                        {
                            tab4[1, 1] = tab4[1, 2];
                            tab4[2, 1] = tab4[2, 1] - tab4[1, 2];
                            tab4[2, 2] = tab4[2, 2] + tab4[1, 2];
                            tab4[1, 2] = 0;

                            tab7[1, 1] = 0;
                        }
                        blok = 1;
                    }
                    
                }

                if (tab7[1, 2] == d && blok == 0)//1,2
                {
                    if (tab7[0, 0] == 0 && tab7[1, 0] == 0 && tab7[0, 2] == 0 && blok == 0)//0,0
                    {
                        if (tab4[0, 2] > tab4[1, 0])
                        {
                            tab4[1, 2] = tab4[1, 0];
                            tab4[0, 2] = tab4[0, 2] - tab4[1, 0];
                            tab4[0, 0] = tab4[0, 0] + tab4[1, 0];
                            tab4[1, 0] = 0;

                            tab7[1, 2] = 0;
                        }
                        if (tab4[0, 2] < tab4[1, 0])
                        {
                            tab4[1, 2] = tab4[0, 2];
                            tab4[1, 0] = tab4[1, 0] - tab4[0, 2];
                            tab4[0, 0] = tab4[0, 0] + tab4[0, 2];
                            tab4[0, 2] = 0;

                            tab7[1, 2] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[1, 0] == 0 && tab7[2, 0] == 0 && tab7[2, 2] == 0 && blok == 0)//2,1
                    {
                        if (tab4[1, 0] > tab4[2, 2])
                        {
                            tab4[1, 2] = tab4[2, 2];
                            tab4[1, 0] = tab4[1, 0] - tab4[2, 2];
                            tab4[2, 0] = tab4[2, 0] + tab4[2, 2];
                            tab4[2, 2] = 0;

                            tab7[1, 2] = 0;
                        }
                        if (tab4[1, 0] < tab4[2, 2])
                        {
                            tab4[1, 2] = tab4[1, 0];
                            tab4[2, 2] = tab4[2, 2] - tab4[1, 0];
                            tab4[2, 0] = tab4[2, 0] + tab4[1, 0];
                            tab4[1, 0] = 0;

                            tab7[1, 2] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 2] == 0 && tab7[0, 1] == 0 && tab7[1, 1] == 0 && blok == 0)//1,2
                    {
                        if (tab4[0, 2] > tab4[1, 1])
                        {
                            tab4[1, 2] = tab4[1, 1];
                            tab4[0, 2] = tab4[0, 2] - tab4[1, 1];
                            tab4[0, 1] = tab4[0, 1] + tab4[1, 1];
                            tab4[1, 1] = 0;

                            tab7[1, 2] = 0;
                        }
                        if (tab4[0, 2] < tab4[1, 1])
                        {
                            tab4[1, 2] = tab4[0, 2];
                            tab4[1, 1] = tab4[1, 1] - tab4[0, 2];
                            tab4[0, 1] = tab4[0, 1] + tab4[0, 2];
                            tab4[0, 2] = 0;

                            tab7[1, 2] = 0;
                        }
                        blok = 1;
                    }
                    if (tab7[0, 2] == 0 && tab7[2, 0] == 0 && tab7[2, 2] == 0 && blok == 0)//2,2
                    {
                        if (tab4[2, 2] > tab4[1, 1])
                        {
                            tab4[1, 2] = tab4[1, 1];
                            tab4[2, 2] = tab4[2, 2] - tab4[1, 1];
                            tab4[2, 1] = tab4[2, 1] + tab4[1, 1];
                            tab4[1, 1] = 0;

                            tab7[1, 2] = 0;
                        }
                        if (tab4[2, 2] < tab4[1, 1])
                        {
                            tab4[1, 2] = tab4[2, 2];
                            tab4[1, 1] = tab4[1, 1] - tab4[2, 2];
                            tab4[2, 1] = tab4[2, 1] + tab4[2, 2];
                            tab4[2, 2] = 0;

                            tab7[1, 2] = 0;
                        }
                        blok = 1;
                    }
                    
                }
            }

            tab5[0] = 0;
            if (tab4[0, 0] != 0)
            {
                tab6[0] = tab1[0, 0] - tab5[0];

            }
            if (tab4[1, 0] != 0)
            {
                tab6[1] = tab1[1, 0] - tab5[0];

            }
            if (tab4[2, 0] != 0)
            {
                tab6[2] = tab1[2, 0] - tab5[0];

            }
            //-----------------------------------

            if (tab4[0, 1] != 0 && tab6[0] != 0)
            {
                tab5[1] = tab1[0, 1] - tab6[0];


            }
            if (tab4[1, 1] != 0 && tab6[1] != 0)
            {
                tab5[1] = tab1[1, 1] - tab6[1];


            }
            if (tab4[2, 1] != 0 && tab6[2] != 0)
            {
                tab5[1] = tab1[2, 1] - tab6[2];


            }

            //-----------------------------------
            if (tab4[0, 1] != 0 && tab5[1] != 0)
            {
                tab6[0] = tab1[0, 1] - tab5[1];

            }
            if (tab4[1, 1] != 0 && tab5[1] != 0)
            {
                tab6[1] = tab1[1, 1] - tab5[1];


            }
            if (tab4[2, 1] != 0 && tab5[1] != 0)
            {
                tab6[2] = tab1[2, 1] - tab5[1];


            }
            //-----------....................
            if (tab4[0, 2] != 0 && tab6[0] != 0)
            {
                tab5[2] = tab1[0, 2] - tab6[0];


            }
            if (tab4[1, 2] != 0 && tab6[1] != 0)
            {
                tab5[2] = tab1[1, 2] - tab6[1];


            }
            if (tab4[2, 2] != 0 && tab6[2] != 0)
            {
                tab5[2] = tab1[2, 2] - tab6[2];


            }
            //-----------------------------------------------------------------
            if (tab4[0, 2] != 0 && tab5[2] != 0)
            {
                tab6[0] = tab1[0, 2] - tab5[2];

            }
            if (tab4[1, 2] != 0 && tab5[2] != 0)
            {
                tab6[1] = tab1[1, 2] - tab5[2];


            }
            if (tab4[2, 2] != 0 && tab5[2] != 0)
            {
                tab6[2] = tab1[2, 2] - tab5[2];


            }
            //--------
            if (tab4[0, 1] != 0 && tab6[0] != 0)
            {
                tab5[1] = tab1[0, 1] - tab6[0];


            }
            if (tab4[1, 1] != 0 && tab6[1] != 0)
            {
                tab5[1] = tab1[1, 1] - tab6[1];


            }
            if (tab4[2, 1] != 0 && tab6[2] != 0)
            {
                tab5[1] = tab1[2, 1] - tab6[2];


            }
            if (tab4[0, 1] != 0 && tab5[1] != 0)
            {
                tab6[0] = tab1[0, 1] - tab5[1];

            }
            if (tab4[1, 1] != 0 && tab5[1] != 0)
            {
                tab6[1] = tab1[1, 1] - tab5[1];


            }
            if (tab4[2, 1] != 0 && tab5[1] != 0)
            {
                tab6[2] = tab1[2, 1] - tab5[1];
            }
            for (int g = 0; g <= 2; g++)
            {
                for (int f = 0; f <= 2; f++)
                {
                    if (tab4[g, f] == 0)
                    {
                        tab7[g, f] = tab1[g, f] - tab5[f] - tab6[g];
                        
                    }

                }
            }
           
            textBox25.AppendText(tab4[0, 0] + "");
            textBox24.AppendText(tab4[0, 1] + "");
            textBox23.AppendText(tab4[0, 2] + "");
            textBox22.AppendText(tab4[1, 0] + "");
            textBox21.AppendText(tab4[1, 1] + "");
            textBox20.AppendText(tab4[1, 2] + "");
            textBox19.AppendText(tab4[2, 0] + "");
            textBox18.AppendText(tab4[2, 1] + "");
            textBox17.AppendText(tab4[2, 2] + "");

            textBox40.AppendText(tab7[0, 0] + "");
            textBox39.AppendText(tab7[0, 1] + "");
            textBox38.AppendText(tab7[0, 2] + "");
            textBox37.AppendText(tab7[1, 0] + "");
            textBox36.AppendText(tab7[1, 1] + "");
            textBox35.AppendText(tab7[1, 2] + "");
            textBox34.AppendText(tab7[2, 0] + "");
            textBox33.AppendText(tab7[2, 1] + "");
            textBox32.AppendText(tab7[2, 2] + "");


            textBox28.AppendText(tab5[0] + "");
            textBox27.AppendText(tab5[1] + "");
            textBox26.AppendText(tab5[2] + "");
            textBox31.AppendText(tab6[0] + "");
            textBox30.AppendText(tab6[1] + "");
            textBox29.AppendText(tab6[2] + "");


        }
    }
}
