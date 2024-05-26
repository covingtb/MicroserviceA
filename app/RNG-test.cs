using System;
using System.IO;


namespace Test
{
    public static class Program
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
            string file = @"C:\Users\12066\OneDrive\Desktop\assignment_8\app\prng-service.txt";

            string rng_start = "run";
            file.WriteAllText(file, rng_start);

            wait(5000);

            // Read all the content in txt file 
            // and display the contents
            string rng_num = File.ReadAllText(file);
            Console.WriteLine(str);

        }
    }
}
