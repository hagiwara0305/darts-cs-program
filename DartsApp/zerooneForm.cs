using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartsApp
{
    public partial class zerooneForm : Form
    {
        string joinPlayerNum;

        public string SendData
        {
            set
            {
                joinPlayerNum = value;
                textBox1.Text = joinPlayerNum;
            }
        }

        public zerooneForm()
        {
            InitializeComponent();
            
        }
      

    }
}
