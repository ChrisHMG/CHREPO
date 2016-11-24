using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpPlan.Framework;

namespace SpPlan
{
    public partial class Form1 : Form
    {
        private DataProvider _dp = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\PRIVAT\SpPlan";
            openFileDialog1.FileName = "";
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.Multiselect = false;
            openFileDialog1.DefaultExt = "spd";
            openFileDialog1.Filter = "Speiseplan Datendatei (*.spd)|*.spd|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _dp = new DataProvider(openFileDialog1.FileName);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
