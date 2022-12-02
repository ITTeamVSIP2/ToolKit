using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SupportTools
{
    public partial class Frm_Hello : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Hello()
        {
            InitializeComponent();
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate
            {
                btnStart.PerformClick();
                tmr.Stop();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(3).TotalMilliseconds;
            tmr.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main();
            f.ShowDialog();
            this.Close();
        }
    }
}