using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace dd
{
    public partial class Form1 : Form
    {
        int frame_index = 0;
        String[] pics;
        int sayac = 0;
        Bitmap greyBitmap;

        public Form1()
        {
            InitializeComponent();
            myInit();
        }

        private void myInit()
        {
            format1.Items.Add("4:4:4");
            format1.Items.Add("4:2:2");
            format1.Items.Add("4:2:0");

            timer1.Interval = 50;
            timer1.Tick += new EventHandler(ChangeImage);

            pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image img;
            using (var bmpTemp = new Bitmap(pics[frame1.SelectedIndex]))
            {
                img = new Bitmap(bmpTemp);
            }
            pic.Image = img;
            sayi.Text = pics[frame1.SelectedIndex];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goster_Click(object sender, EventArgs e){

            try {
                sayac = 0;
                frame1.Items.Clear();
                pic.Image = null;
                sayi.Text = null;

                int width = Convert.ToInt32(width1.Text);
                int height = Convert.ToInt32(height1.Text);
                String format = format1.SelectedItem.ToString(); 
                int n_pixels = height * width;

                int y_size = n_pixels;
                int u_size;
                int v_size;

                if (format == "4:2:2"){
                    u_size = n_pixels / 2;
                    v_size = n_pixels / 2;
                }

                else if (format == "4:2:0"){
                    u_size = n_pixels / 4;
                    v_size = n_pixels / 4;
                }
                else{
                    u_size = n_pixels;
                    v_size = n_pixels;
                }

                int index = 0;

                int[] y = new int[y_size];
                int[] u = new int[u_size];
                int[] v = new int[v_size];

                int[,] GREY = new int[height, width];

                greyBitmap = new Bitmap(width, height);
                    
                BinaryReader br;

                String file = dosya_yolu.Text;

                try{
                    br = new BinaryReader(new FileStream(file, FileMode.Open));
                }
                catch (IOException){
                    MessageBox.Show(" Dosya Açılamadı !");
                    return;
                }
                frame_index = 0;

                try{
                    do{
                        for (int i = 0; i < y_size; i++){
                            y[i] = br.ReadByte();
                            index++;
                        }

                        for (int i = 0; i < u_size; i++){
                            u[i] = br.ReadByte();
                            index++;
                        }

                        for (int i = 0; i < v_size; i++){
                            v[i] = br.ReadByte();
                            index++;
                        }


                        index = 0;
                        for (int i = 0; i < height; i++){
                            for (int j = 0; j < width; j++){
                                GREY[i, j] = y[index];
                                index++;
                            }
                        }

                        for (int i = 0; i < height; i++){
                            for (int j = 0; j < width; j++){
                                greyBitmap.SetPixel(j, i, Color.FromArgb(GREY[i, j], GREY[i, j], GREY[i, j]));
                            }
                        }

                        try
                        {
                            greyBitmap.Save("grey_" + frame_index + ".bmp", ImageFormat.Bmp);
                            Console.WriteLine("Frame"+frame_index+" oluşturuldu !");
                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine("error\n" + ex);
                        }
                        
                        frame_index++;
                        frame1.Items.Add(frame_index);

                    }while (br.BaseStream.Position != br.BaseStream.Length);

                    pics = new String[frame_index];

                    for (int i = 0; i < frame_index; i++){
                        pics[i] = "grey_" + i + ".bmp";
                    }
                    
                    timer1.Start();
                    
                    br.Close();   
                }
                catch (IOException d)
                {
                    MessageBox.Show("Görüntü Uygun Formatta Değildir !!");
                }
    
            }
            catch (FormatException a)
            {
                MessageBox.Show("Genişlik ve Yükseklik değerleri yalnızca rakamdan oluşmalıdır !");
            }
            catch (ArgumentException b)
            {
                MessageBox.Show("Dosya Yolu seçiniz !!");
            }
            catch (NullReferenceException c)
            {
                MessageBox.Show("Format Bilgisi Giriniz !");
            }
            
        }
        
        private void dosya_Click(object sender, EventArgs e)
        {
            openFile.Filter = "YUV Dosyası | *.yuv";
            openFile.ShowDialog();
            dosya_yolu.Text = openFile.FileName;
            dosya_yolu.Enabled = false;
        }

        private void ChangeImage(object sender, EventArgs e)
        {
            if (sayac != pics.Length){
                Image img;
                using (var bmpTemp = new Bitmap(pics[sayac]))
                {
                    img = new Bitmap(bmpTemp);
                }
                pic.Image = img;
                sayi.Text = pics[sayac];
                sayac++;
            }
            else
            {
                timer1.Stop();
            }    
        }

        private void width1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
