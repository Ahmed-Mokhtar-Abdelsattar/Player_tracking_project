using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_and_write_image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// variables difenitions
        /// </summary>
        int xCoordinate;
        int yCoordinate;


        int BadCode;
        int x_object = 10, y_object = 10;
        int x_player_01, y_player_01, x_player_02, y_player_02, x_player_03, y_player_03;
        bool get_lost = false;
        int x, y, z;
        int z1, No_of_Images = 40;
        //int Row;
        //int frame = 0, Movie_Length = 10;// 10 frames
        int x_tempo, y_tempo, shift, C;
        int a, r, g, b;
        //int x_Fun, y_Fun;
        int x_rec, y_rec, y_rec1;
        int Right_Image_Rectification_Factor, Left_Image_Rectification_Factor;
        int Cut_from_uper_Right, Cut_from_uper_Left;
        int No_of_Rows_Right, No_of_Rows_Left;
        int x1, x2, y1, y2;
        int X1_R, Y1_R, X2_R, Y2_R, X1_L, Y1_L, X2_L, Y2_L;



        double x_temp, y_temp, y_temp1, oper1, oper2, oper3, oper4, oper5, oper6, m;
        int calctemp;
        double slope_R, slope_L;
        // double slope_R = 0.00028, slope_L = 0.00028;
        int x_shift_L, y_shift_L, x_shift_R, y_shift_R;
        int widthFun_R, heightFun_R, widthFun_L, heightFun_L, width_Stetch, height_Stetch;
        int width_R, height_R, width_L, height_L;


        int Rectification_Factor_Horizontal_Step_1 = 270, Rectification_Factor_Horizontal_Step_2 = 1, Rectification_Factor_vertical = 1;
        int Scale_Factor_H = 1;
        int Scale_Factor_W = 1;
        int Trim_C_From_Right = 600, Trim_C_From_Left = 0, Trim_R_From_Left = 0, Trim_L_From_Right = 7;
        /*
        //START REMOVED: for the sake of traching
        string Folder_Path = @"F:\Programming\Sharm 2019\13- 2019 Player Class\image sequence\Output\";
        string File_Name = "Stetched_Img-";
        string File_Name_counter = "2";
        string check;

        string Folder_Path_R = @"F:\Programming\Sharm 2019\13- 2019 Player Class\image sequence\Input\Camera 2 input\";
        string File_Name_counT_R;
        string Folder_Path_L = @"F:\Programming\Sharm 2019\13- 2019 Player Class\image sequence\Input\Camera 1 input\";
        string File_Name_counT_L;
        string finename_R = "Canera2-";
        string finename_L = "Canera1-";
        //string Folder_Path = Folder_Path + File_Name;
        //END REMOVED: for the sake of traching
        */

        //START ADDED: for the sake of traching
        string Folder_Path = @"H:\Image Processing\C# Trials\Pixel Level\Images Test\";
        string File_Name = "TEST-";
        string File_Name_counter = "2";
        string check;

        string Folder_Path_R = @"H:\Image Processing\C# Trials\Pixel Level\Images Test\";
        string File_Name_counT_R;
        //string Folder_Path_L = @"F:\Programming\Sharm 2019\13- 2019 Player Class\Image Test\";
        //string File_Name_counT_L;
        string finename_R = "Right";
        //string finename_L = "Canera1-";
        //END ADDED: for the sake of traching

        double d = 0.142857143;

        //slope_R = 0.0007;// 0; //0.0007
        //slope_L = 0;// -0.00028;// 0.00040;
        //Right_Image_Rectification_Factor = 30;       Left_Image_Rectification_Factor = 23;


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Text = "10";
            //String.Format("X: {0}; Y: {1}", e.X, e.Y);
             xCoordinate = e.X;
             yCoordinate = e.Y;
            textBox1.Text = String.Format("X: {0}; Y: {1}", e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int BadCode;
            int x_object = 10, y_object = 10;
            bool get_lost = true;
            int x, y, z;
            int z1  , No_of_Images = 40 ;
            //int Row;
            //int frame = 0, Movie_Length = 10;// 10 frames
            int x_tempo, y_tempo, shift, C;
            int a, r, g, b;
            //int x_Fun, y_Fun;
            int x_rec, y_rec, y_rec1;
            int Right_Image_Rectification_Factor, Left_Image_Rectification_Factor;
            int Cut_from_uper_Right, Cut_from_uper_Left;
            int No_of_Rows_Right, No_of_Rows_Left;
            int x1, x2, y1, y2;
            int X1_R ,Y1_R , X2_R , Y2_R , X1_L,Y1_L, X2_L, Y2_L;
            double x_temp, y_temp, y_temp1, oper1, oper2, oper3, oper4, oper5, oper6, m;
            int calctemp;
            double slope_R, slope_L;
            // double slope_R = 0.00028, slope_L = 0.00028;
            int x_shift_L, y_shift_L, x_shift_R, y_shift_R;
            int widthFun_R, heightFun_R, widthFun_L, heightFun_L, width_Stetch, height_Stetch;
            int width_R, height_R, width_L, height_L;


            int Rectification_Factor_Horizontal_Step_1 = 270, Rectification_Factor_Horizontal_Step_2 = 1, Rectification_Factor_vertical = 1;
            int Scale_Factor_H = 1;
            int Scale_Factor_W = 1;
            int Trim_C_From_Right = 600, Trim_C_From_Left = 0, Trim_R_From_Left = 0, Trim_L_From_Right = 7;
            /*
            //START REMOVED: for the sake of traching
            string Folder_Path = @"F:\Programming\Sharm 2019\13- 2019 Player Class\image sequence\Output\";
            string File_Name = "Stetched_Img-";
            string File_Name_counter = "2";
            string check;

            string Folder_Path_R = @"F:\Programming\Sharm 2019\13- 2019 Player Class\image sequence\Input\Camera 2 input\";
            string File_Name_counT_R;
            string Folder_Path_L = @"F:\Programming\Sharm 2019\13- 2019 Player Class\image sequence\Input\Camera 1 input\";
            string File_Name_counT_L;
            string finename_R = "Canera2-";
            string finename_L = "Canera1-";
            //string Folder_Path = Folder_Path + File_Name;
            //END REMOVED: for the sake of traching
            */

            //START ADDED: for the sake of traching

            string Folder_Path = @"H:\Image Processing\C# Trials\Pixel Level\Images Test\";
            string File_Name = "TEST-";
            string File_Name_counter = "2";
            string check;

            string Folder_Path_R = @"H:\Image Processing\C# Trials\Pixel Level\Images Test\";
            string File_Name_counT_R;
            //string Folder_Path_L = @"F:\Programming\Sharm 2019\13- 2019 Player Class\Image Test\";
            //string File_Name_counT_L;
            //string finename_R = "Right00";
            //string finename_L = "Canera1-";
            //END ADDED: for the sake of traching

            double d = 0.142857143;

            slope_R = 0.0007;// 0; //0.0007
            slope_L = 0;// -0.00028;// 0.00040;
            Right_Image_Rectification_Factor = 30;       Left_Image_Rectification_Factor = 23;
            /////////////////////////////////////////////////////////////////////////////////

            //pictureBox1.Image = Image.FromFile(@"H:\Image Processing\C# Trials\Pixel Level\Images Test\Right0001.png");

            File_Name_counT_R = "Right0001.png";
            //File_Name_counT_R = "Right0001.png";

            check = Folder_Path_R + File_Name_counT_R;
  
           Bitmap Img_R = new Bitmap("H:\\Image Processing\\C# Trials\\Pixel Level\\Images Test\\Right0001.png");
            

            width_R = Img_R.Width;  // Wadi Degla 640
            height_R = Img_R.Height;// Wadi Degla 480
                                    // width_L = Img_L.Width;  // Wadi Degla 640
                                    //height_L = Img_L.Height;// Wadi Degla 480
            int new_width_R = width_R - 200;
            int newheight_R = height_R - 100;
            Bitmap Img_Test = new Bitmap(new_width_R, newheight_R);
            No_of_Images = 1; // to be solved later
            z = 0;
            int[,,] Red_R = new int[new_width_R, newheight_R, No_of_Images];
            int[,,] Grn_R = new int[new_width_R, newheight_R, No_of_Images];
            int[,,] Blu_R = new int[new_width_R, newheight_R, No_of_Images];

            int[,,] Red_T = new int[new_width_R, newheight_R, No_of_Images];
            int[,,] Grn_T = new int[new_width_R, newheight_R, No_of_Images];
            int[,,] Blu_T = new int[new_width_R, newheight_R, No_of_Images];

            //Right Picture pixel matrix filling
            for (y = 200; y < newheight_R; y++)
            {
                for (x = 0; x < new_width_R; x++)
                {
                    // get pixel value
                    Color p = Img_R.GetPixel(x, y);

                    // extract ARGB value from p
                    a = p.A;
                    r = p.R;
                    g = p.G;
                    b = p.B;

                    Red_R[x, y, z] = r;
                    Grn_R[x, y, z] = g;
                    Blu_R[x, y, z] = b;

                    // set new ARGB Value in pixel
                    //bmpMan.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            ///////////////////////////////////////////////////////////////////////////////
            //Added for tracking
            //TEST Picture pixel matrix filling
            for (y = 200; y < newheight_R; y++)
            {
                for (x = 0; x < new_width_R; x++)
                {
                    // get pixel value
                    Color p = Img_R.GetPixel(x, y);

                    // extract ARGB value from p
                    a = p.A;
                    r = p.R;
                    g = p.G;
                    b = p.B;

                    Red_T[x, y, z] = r;
                    Grn_T[x, y, z] = g;
                    Blu_T[x, y, z] = b;

                    // set new ARGB Value in pixel
                    Img_Test.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }




            pictureBox1.Image = Img_Test;
            
            
            /*

                Img_R.Dispose();
            Img_L.Dispose();
           // Img_C.Dispose();
            Img_Stetch.Dispose();

    */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4545";
            //for (BadCode = 0; BadCode < 265; BadCode++) // to reduce matrix dimension
            for (BadCode = 0; BadCode < 40; BadCode++) // to reduce matrix dimension       
            {
                //z1 = BadCode + 637;
                z1 = BadCode + 1;
                No_of_Images = 1;
                for (z = 0; z < No_of_Images; z++)
                {
                    File_Name_counT_R = finename_R + z1.ToString("0000") + ".png";
                    
                    check = Folder_Path_R + File_Name_counT_R;
                    //z1++;

                    //read image
                    Bitmap Img_R = new Bitmap(Folder_Path_R + File_Name_counT_R);

                    width_R = Img_R.Width ;  // Wadi Degla 640
                    height_R = Img_R.Height;// Wadi Degla 480
                                                  // width_L = Img_L.Width;  // Wadi Degla 640
                                                  //height_L = Img_L.Height;// Wadi Degla 480
                    int new_width_R = width_R - 100;
                    int newheight_R = height_R - 100;
                    Bitmap Img_Test = new Bitmap(new_width_R, newheight_R);

                    int[,,] Red_R = new int[new_width_R, newheight_R, No_of_Images];
                    int[,,] Grn_R = new int[new_width_R, newheight_R, No_of_Images];
                    int[,,] Blu_R = new int[new_width_R, newheight_R, No_of_Images];

                    int[,,] Red_T = new int[new_width_R, newheight_R, No_of_Images];
                    int[,,] Grn_T = new int[new_width_R, newheight_R, No_of_Images];
                    int[,,] Blu_T = new int[new_width_R, newheight_R, No_of_Images];

                    //Right Picture pixel matrix filling
                    for (y = 0; y < newheight_R; y++)
                    {
                        for (x = 0; x < new_width_R; x++)
                        {
                            // get pixel value
                            Color p = Img_R.GetPixel(x, y);

                            // extract ARGB value from p
                            a = p.A;
                            r = p.R;
                            g = p.G;
                            b = p.B;

                            Red_R[x, y, z] = r;
                            Grn_R[x, y, z] = g;
                            Blu_R[x, y, z] = b;

                            // set new ARGB Value in pixel
                            //bmpMan.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                        }
                    }
                    ///////////////////////////////////////////////////////////////////////////////
                    //Added for tracking
                    //TEST Picture pixel matrix filling
                    for (y = 0; y < newheight_R; y++)
                    {
                        for (x = 0; x < new_width_R; x++)
                        {
                            // get pixel value
                            Color p = Img_R.GetPixel(x, y);

                            // extract ARGB value from p
                            a = p.A;
                            r = p.R;
                            g = p.G;
                            b = p.B;

                            Red_T[x, y, z] = r;
                            Grn_T[x, y, z] = g;
                            Blu_T[x, y, z] = b;

                            // set new ARGB Value in pixel
                            Img_Test.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                        }
                    }
                    /////////////////////////////////////////////////////////////////////////////////////////
                    /////////////////////////////////////////////////////////////////////////////////////////
                    //xCoordinate
                    //yCoordinate
                    x_object = 20;
                    y_object = 20;
                    if (z1 == 1 || get_lost == true)
                    {
                        // for (y = 0; y < newheight_R / 2; y = y + 10)
                        for (y = -y_object; y < y_object; y++)
                        {
                            //  for (x = 0; x < new_width_R / 2; x = x + 10)
                            for (x = -x_object; x < x_object; x++)
                            {
                                //if (Red_T[x, y, z] < 50)
                                //{
                                   //if (xCoordinate != 0)
                                   //if(rad_Player01.Checked == true)
                                    //{
                                        //x_object = xCoordinate;
                                        //y_object = yCoordinate;
                                        if (Red_T[(x_player_01 + x), (y_player_01 + y), z] < 50)
                                        {
                                            x_player_01 = x_player_01 + x;
                                            y_player_01 = y_player_01 + y;
                                        }
                                    //}
                                   // else if(rad_Player02.Checked == true)
                                   // {
                                        //x_object = xCoordinate;
                                        //y_object = yCoordinate;
                                        if (Red_T[(x_player_02 + x), (y_player_02 + y), z] < 50)
                                        {
                                            x_player_02 = x_player_02 + x;
                                            y_player_02 = y_player_02 + y;
                                        }
                                        if (Red_T[(x_player_03 + x), (y_player_03 + y), z] < 50)
                                        {
                                            x_player_03 = x_player_03 + x;
                                            y_player_03 = y_player_03 + y;
                                        }
                                // else
                                // {
                                //x_object = x;
                                //y_object = y;
                                // }
                                //}
                            }
                        }
                        get_lost = false;
                    }
                    else if (z1 != 1)
                    {
                        //y = y_object - 1;
                        //x = x_object - 1;

                        // for (y = y_object - 20; y < y_object + 20; y++)
                        for (y = -y_object; y < y_object ; y++)
                        {

                            // for (x = x_object - 20; x < x_object + 20; x++)
                            for (x = -x_object; x < x_object; x++)
                            {
                               //if (Red_T[x, y, z] < 50)
                                {
                                    //if (xCoordinate != 0)
                                    //if (rad_Player01.Checked == true)
                                    {
                                        //x_object = xCoordinate;
                                        //y_object = yCoordinate;
                                        if (Red_T[(x_player_01 + x), (y_player_01 + y), z] < 50)
                                        {
                                            x_player_01 = x_player_01 + x;
                                            y_player_01 = y_player_01 + y;
                                        }
                                    }
                                    //else if (rad_Player02.Checked == true)
                                    {
                                        //x_object = xCoordinate;
                                        //y_object = yCoordinate;
                                        if (Red_T[(x_player_02 + x), (y_player_02 + y), z] < 50)
                                        {
                                            x_player_02 = x_player_02 + x;
                                            y_player_02 = y_player_02 + y;
                                        }
                                    }
                                        if (Red_T[(x_player_03 + x), (y_player_03 + y), z] < 50)
                                        {
                                            x_player_03 = x_player_03 + x;
                                            y_player_03 = y_player_03 + y;
                                        }
                                    //else
                                    {
                                        //x_object = x;
                                        //y_object = y;
                                    }
                                }
                            }
                        }
                    }

                    /////////////////////////////////////////////////////////////////////////////////////////
                    //Draw a rictangle for tracking
                    /*
                    Graphics gr = CreateGraphics();
                    Pen selPen = new Pen(Color.Red);
                    gr.DrawRectangle(selPen, 10, 10, 50, 50);
                    gr.Dispose();
                    */
                    /////////////////////////////////////////////////////////////////////////////////////////
                    /////////////////////////////////////////////////////////////////////////////////////////
                    //Draw a Marker for tracking
                    // y = y_object - 5;  //for ofsit trimming
                    // x = x_object - 5;

                    //for (y = y_object - 5; y < y_object + 5; y++)
                    for (y = y_player_01 - 5; y < y_player_01 + 5; y++)
                    {
                        //  for (x = x_object - 5; x < x_object + 5; x++)
                        for (x = x_player_01 - 5; x < x_player_01 + 5; x++)
                        {
                            // Red_T[x, y, z] = 255;
                            //Grn_T[x, y, z] = 0;
                            //Blu_T[x, y, z] = 0;
                            Img_Test.SetPixel(x, y, Color.FromArgb(255, 255, 0, 0));
                        }
                    }
                    for (y = y_player_02 - 5; y < y_player_02 + 5; y++)
                    {
                        for (x = x_player_02 - 5; x < x_player_02 + 5; x++)
                        {
                            Img_Test.SetPixel(x, y, Color.FromArgb(255, 255, 0, 0));
                        }
                    }
                    for (y = y_player_03 - 5; y < y_player_03 + 5; y++)
                    {
                        for (x = x_player_03 - 5; x < x_player_03 + 5; x++)
                        {
                            Img_Test.SetPixel(x, y, Color.FromArgb(255, 255, 0, 0));
                        }
                    }
                    //Update
                    /*
                    if (xCoordinate != 0)
                    {
                        x_object = xCoordinate;
                        y_object = yCoordinate;
                    }
                    else
                    {
                        x_object = x;
                        y_object = y;
                    }
                    */
                    /////////////////////////////////////////////////////////////////////////////////////////



                    //START ADDED

                    //END ADDED
                    //File_Name_counter = File_Name + Convert.ToString(z1) + ".png";
                    File_Name_counter = File_Name + z1.ToString("0000") + ".png";
                    check = Folder_Path + File_Name_counter;
                    //Img_Stetch.Save(Folder_Path + File_Name_counter);
                    Img_Test.Save(Folder_Path + File_Name_counter);
                    z1++;
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //load image in in picturebox2
                    pictureBox1.Image = Img_Test;

                   // int tempwidth = bmp_Fun_R.Width;
                   // int temphieght = bmp_Fun_R.Height;

                    //write image
                    //Img_Test.Save(@"H:\Image Processing\C# Trials\Pixel Level\Images Test\o.png");

                }// Img_No
            }


        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Text = "10";
            //String.Format("X: {0}; Y: {1}", e.X, e.Y);
            int xCoordinate = e.X;
            int yCoordinate = e.Y;
            textBox1.Text = "4545";// String.Format("X: {0}; Y: {1}", e.X, e.Y);
        }

        private void PictureBox3_mouseClick(object sender, MouseEventArgs e)
        {
            Text = "10";
            //String.Format("X: {0}; Y: {1}", e.X, e.Y);
            int xCoordinate = e.X;
            int yCoordinate = e.Y;
            textBox1.Text = String.Format("X: {0}; Y: {1}", e.X, e.Y);
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            get_lost = true;
           // if (chkBx_Correction.Checked == true)
            {
                /////////////////////////////////////////////////////////////////
                if (rad_Player01.Checked == true)
                {
                    textBox1.Text = "Player 01";
                    x_player_01 = xCoordinate;
                    y_player_01 = yCoordinate;

                }
                /////////////////////////////////////////////////////////////////
                else if (rad_Player02.Checked == true)
                {
                    textBox1.Text = "Player 02";
                    x_player_02 = xCoordinate;
                    y_player_02 = yCoordinate;
                }
                /////////////////////////////////////////////////////////////////
                if (rad_Player03.Checked == true)
                {
                    textBox1.Text = "Player 03";
                    x_player_03 = xCoordinate;
                    y_player_03 = yCoordinate;

                }
                /////////////////////////////////////////////////////////////////
            }

        }

    }

}
