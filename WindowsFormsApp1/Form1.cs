using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FolderforModel;

namespace WindowsFormsApp1
{
    public partial class MainForm_Load : Form
    {
        public static Model1 DB = new Model1();
        List<Motorbike> motorbikes = DB.Motorbike.ToList();
        int AccNumber = 0;
        private void Loading()
        {
            userControlName1.Fill(motorbikes[AccNumber]);
            userControlName2.Fill(motorbikes[AccNumber + 1]);
        }
        public MainForm_Load()
        {
            InitializeComponent();
        }
        
        private void Loading(bool Incr)
        {
            if (Incr == true && motorbikes.Count > AccNumber + 2)
                AccNumber++;
            else if (Incr == false && 0 <= AccNumber - 1)
                AccNumber--;
            else
                return;
            Loading();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true);
        }

        private void userControlName1_Load(object sender, EventArgs e)
        {

        }

        private void userControlName2_Load(object sender, EventArgs e)
        {

        }
    }
}
