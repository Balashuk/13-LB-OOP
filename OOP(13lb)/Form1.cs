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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }
        protected virtual void formRez()
        {
            string s;
            s = PrizvFo.Text;
            if (NameFo.Text != " ")
            {
                if (s != " ")
                    s += " ";
                s += NameFo.Text;
            }
            if (FNameFo.Text != " ")
            {
                if (s != " ")
                    s += " ";
                s += FNameFo.Text;
            }
            Rez.Text = s;
        }
        
        private void PrizvFo_TextChanged(object sender, EventArgs e)
        {
            formRez();
        }

        private void NameFo_TextChanged(object sender, EventArgs e)
        {
            formRez();
        }

        private void FNameFo_TextChanged(object sender, EventArgs e)
        {
             formRez();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            formRez();
        }

        private void Rez_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
