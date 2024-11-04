using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartConference.Components
{
    public partial class Widget : UserControl
    {
        public event EventHandler OnSelect = null;
        public Widget()
        {
            InitializeComponent();
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public enum categories { Comida, Bebidas, Goolocinas}
        //public categories Category {}
        //public string Title {}
        //public string cost { get ; set; }
        //public Image Icon { }


    }
}
