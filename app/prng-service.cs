using System;
using System.IO;


namespace Prng
{
    public class Program
    {
        static void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                wait(1000);
                string file = @"C:\Users\12066\OneDrive\Desktop\assignment_8\app\prng-service.txt";

                string str = file.ReadAllText(file);
                string check = "run";
                if (str.Equals(check))
                {
                    wait(1000);
                    Random rnd = new Random();
                    int rnd_num = rnd.Next(1, 100);
                    string rng_num = rnd_num.ToString();
                    File.WriteAllText(file, rng_num);
                }
            }
        }
    }
}