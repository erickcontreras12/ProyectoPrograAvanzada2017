using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograAvanzada
{
    public partial class MLey : Form
    {
        public MLey()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SLeyes vim8 = new SLeyes();
            vim8.Show();
            this.Hide();
        }
    }
}
