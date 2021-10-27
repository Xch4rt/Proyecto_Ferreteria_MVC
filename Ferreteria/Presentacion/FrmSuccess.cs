using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmSuccess : Form
    {
        public FrmSuccess(string message, AlertType type)
        {
            InitializeComponent();
            MsjLabel.Text = message;
           switch (type)
           {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen; break;
                case AlertType.info:
                    this.BackColor = Color.Gray; break;
                case AlertType.warning:
                    this.BackColor = Color.Crimson; break;
                case AlertType.error:
                    this.BackColor = Color.FromArgb(255,128,0); break;
           }

        }
        public static void showFormAlert(string message, AlertType type)
        {
            FrmSuccess frm = new FrmSuccess(message, type);
            frm.ShowDialog();
        }

        private void FrmSuccess_Load(object sender, EventArgs e)
        {
            // set position to the left
            this.Top =  60;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
        }

        public enum AlertType
        {
            success, info, warning, error
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                show.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity-=0.05;
            else
                this.Close();
        }
    }
}
