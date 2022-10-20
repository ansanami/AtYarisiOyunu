using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }
        int birinciatsoluzaklık, ikinciatsoluzaklık, ucuncuatsoluzaklık;

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsoluzaklık = pictureBox1.Left;
            ikinciatsoluzaklık = pictureBox2.Left;
            ucuncuatsoluzaklık = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int bitisuzaklıgı = textBox5.Left;
            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;
            pictureBox1.Left += rastgele.Next(0,15);
            pictureBox2.Left += rastgele.Next(0,15);
            pictureBox3.Left += rastgele.Next(0,15);
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label1.Text = "bir numaralı at ınanılmaz atak yaptı";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label1.Text = "uc numaralı at on safta";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label1.Text = "iki numaralı at liderligi kaptı";
            }
            if (birinciatgenislik + pictureBox1.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("birinci at yaarısı kazandı");
            }
            if (ikinciatgenislik+ pictureBox2.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("ucuncu at yaarısı kazandı");
            }
            if (ucuncuatgenislik + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("ıkıncı at yaarısı kazandı");
            }
        }

        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
