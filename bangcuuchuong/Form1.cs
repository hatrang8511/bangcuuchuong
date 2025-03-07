using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bangcuuchuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int so =Int32.Parse(nudBangCuuChuong.Value.ToString());

            for (int i = 1; i < 11; i++)
            {
                //lblKQ.Text + = so.ToString() +"\n";
                lblKQ.Text += so + "x" + i + "=" + so * i + Environment.NewLine;

                lsbKQ.Items.Add(so + "x" + "=" + so *i + Environment.NewLine);

            }








            
        }
    }
}
