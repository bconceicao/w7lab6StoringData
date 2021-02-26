using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week5_PersonClassinWindows;

namespace Midterm245
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PersonV2 temp = new PersonV2();
            


            temp.FName = textFName.Text;
            temp.MName = textMName.Text;
            temp.LName = textLName.Text;
            temp.Street1 = textStreet1.Text;
            temp.Street2 = textStreet2.Text;
            temp.City = textCity.Text;
            temp.State = textState.Text;
            temp.Zip = textZipCode.Text;
            temp.Email = textEmail.Text;
            temp.Phone = textPhone.Text;
            temp.InstagramURL = textInstagramURL.Text;
            temp.Cellphone = textCellphone.Text;



            lblFeedback.Text = temp.AddARecord();



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
   
}
