using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Caculate_Click(object sender, EventArgs e)
        {
            float _xFrom;
            float _xTo;
            float _xPlus;
            int _nFrom;
            int _nTo;
            int _nPlus;
            _xFrom = (float) Convert.ToDouble(xFrom.Text.ToString());
            _xTo = (float) Convert.ToDouble(xTo.Text.ToString());
            _xPlus = (float)Convert.ToDouble(xJump.Text.ToString());
            _nFrom = Convert.ToInt32(nFrom.Text.ToString());
            _nTo = Convert.ToInt32(nTo.Text.ToString());
            _nPlus = Convert.ToInt32(nJump.Text.ToString());
            List<DataList> dt = new List<DataList>();
            for (float x = _xFrom; x <= _xTo; x+=_xPlus)
            {
                for (int n = _nFrom; n <= _nTo; n+=_nPlus)
                {
                    DataList a = new DataList();
                    a._x = x;
                    a._n = n;
                    a._multiplication = n*x;
                    float sum = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        sum += x;
                    }
                    a._summation = sum;
                    a._equal=a._multiplication - a._summation;
                    dt.Add(a);
                }
            }
            
            Result.DataSource = dt;
            Result.Columns[0].HeaderText = "X";
            Result.Columns[1].HeaderText = "N";
            Result.Columns[2].HeaderText = "N*X";
            Result.Columns[3].HeaderText = "X+X+...+X";
            Result.Columns[4].HeaderText = "N*X - (X+X+...+X)";
            Result.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


    }
}
