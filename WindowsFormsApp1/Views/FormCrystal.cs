using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using WindowsFormsApp1;

namespace GehaOverFlow.Views
{
	public partial class FormCrystal : Form
	{
		CrystalReport1 cr;
        CrystalReport2 cr2;
		public FormCrystal()
		{
			InitializeComponent();
		}

        private void genBtn_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;

        }

        private void form_load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            cr2 = new CrystalReport2();
            foreach(ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr2.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr2;

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ViewsUtils.SwitchForms(this, new FormHome());

        }
    }
}
