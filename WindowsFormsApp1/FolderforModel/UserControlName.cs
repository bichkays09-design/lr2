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

namespace WindowsFormsApp1.FolderforModel
{
    public partial class UserControlName : UserControl
    {
        public UserControlName()
        {
            InitializeComponent();
        }
        public void Fill(Motorbike motorbike)
        {
            labelID.Text = motorbike.ID.ToString();
            labelModel.Text = motorbike.Model.ToString();
            labelBrand.Text = motorbike.Brand.ToString();
            labelPrice.Text = motorbike.Price.ToString();
            labelHorsepower.Text = motorbike.Horsepower.ToString();
            labelMileage.Text = motorbike.Mileage.ToString();
            pictureBox1.Image = Image.FromFile($@"Pictures\{motorbike.Picture}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlName_Load(object sender, EventArgs e)
        {

        }
    }
}
