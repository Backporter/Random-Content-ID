using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Content_ID
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private static Random random = new Random();
        public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        public int GenerateRandomCUSA()
        {
            int _min = 10000;
            int _max = 99999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            ///UP1003-CUSA05333_00-SKYRIMHDFULLGAME
            textBox1.Text = "UP" + GenerateRandomNo().ToString() + "-CUSA" + GenerateRandomCUSA().ToString() + "_00-" + RandomString(16);
        }
    }
}
