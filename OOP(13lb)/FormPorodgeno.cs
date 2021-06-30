using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_13lb_
{
    public partial class FormPorodgeno : FormBase
    {
        public FormPorodgeno(): base()
        {
            InitializeComponent();
        }
        protected override void  formRez()

        { base.formRez();
            string s = Rez.Text;
            if (s != " ")
                s += " " ;
            s += " ( " + ((int)((double)(DateTime.Now - ДатаНародження.Value).Days / 365.25)).ToString() + " Років" + ')';
            Rez.Text = s;
        }

        private void FormPorodgeno_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            formRez();
        }
    }
}
