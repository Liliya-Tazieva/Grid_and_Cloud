using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var client = new MyWebService.CalcServiceSoapClient();
            txtRes.Text = client.Add(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text)).ToString();
        }

        private void ButtunSub_Click(object sender, EventArgs e)
        {
            var client = new MyWebService.CalcServiceSoapClient();
            txtRes.Text = client.Sub(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text)).ToString();
        }

        private void ButtonMul_Click(object sender, EventArgs e)
        {
            var client = new MyWebService.CalcServiceSoapClient();
            txtRes.Text = client.Mul(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text)).ToString();
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            var client = new MyWebService.CalcServiceSoapClient();
            txtRes.Text = client.Div(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text)).ToString();
        }

        private void ButtonMsg_Click(object sender, EventArgs e)
        {
            var client = new MyWebService.CalcServiceSoapClient();
            MessageBox.Show(client.Message(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
