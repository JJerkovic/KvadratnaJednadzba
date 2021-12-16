using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            display.FillResults();
        }

        private void display_Load(object sender, EventArgs e)
        {

        }
    }
}
