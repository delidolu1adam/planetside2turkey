using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;

namespace PlanetSide2TR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kanalaAboneOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/delidolu1adam");
        }

        private void bağışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/tradeoffer/new/?partner=300906550&token=M0za1HAx");
        }

        private void yamaKurulumRehberiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=JLbI10iuvj4&t=3s");
        }

        private void hataBildirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/delidolu1adam");
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://steamcommunity.com/sharedfiles/filedetails/?id=1167914249");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("http://www.aser24.com/serhat/ps2/en_us_data.dat", @"Locale\\en_us_data.dat");
            client.DownloadFile("http://www.aser24.com/serhat/ps2/en_us_data.dir", @"Locale\\en_us_data.dir");
            client.DownloadFile("http://www.aser24.com/serhat/ps2/Geo-Md.ttf", @"Locale\\Geo-Md.ttf");
            Thread.Sleep(0x7d0);
            string text = "Türkçe dil dosyaları başarıyla güncellendi!";
            string caption = "Türkçe dil dosyalarını güncelle";
            MessageBoxButtons oK = MessageBoxButtons.OK;
            MessageBox.Show(text, caption, oK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = this.label2.Text + @"\Locale\en_us_data.dat";
            string str2 = this.label2.Text + @"\Locale\en_us_data.dir";
            string str3 = this.label2.Text + @"\Locale\Geo-Md.ttf";
            string str4 = this.textBox1.Text + @"\Locale\en_us_data.dat";
            string str5 = this.textBox1.Text + @"\Locale\en_us_data.dir";
            string str6 = this.textBox1.Text + @"\UI\Resource\Fonts\Geo-Md.ttf";
            try
            {
                File.Copy(Path.Combine(new string[] { str }), Path.Combine(new string[] { str4 }), true);
                this.progressBar1.PerformStep();
                File.Copy(Path.Combine(new string[] { str2 }), Path.Combine(new string[] { str5 }), true);
                this.progressBar1.PerformStep();
                File.Copy(Path.Combine(new string[] { str3 }), Path.Combine(new string[] { str6 }), true);
                this.progressBar1.PerformStep();
                this.button4.Visible = true;
                this.label1.Visible = true;
            }
            catch (Exception)
            {
                string text = "Lütfen, Aşağıdaki adımları eksiksiz yaptığınızdan emin olun!\n\n" + "1: Oyunun kurulu olduğu dizini (doğru) seçtiğinizden emin olun!\n" + "2: Türkçe dil dosyalarının Locale klasörü içinde mevcut olduğundan emin olun!\n\n" + "Locale klasör içeriği: en_us_data.dat, en_us_data.dir, Geo-Md.ttf";
                string caption = "Bilinmeyen Hata!";
                MessageBoxButtons oK = MessageBoxButtons.OK;
                MessageBox.Show(text, caption, oK);
            }
        }


      


        private void Form1_Load(object sender, EventArgs e)
        {
            new Process { StartInfo = { FileName = "steam://rungameid/218230" } }.Start();
            this.label2.Text = Application.StartupPath;
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 218230");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
