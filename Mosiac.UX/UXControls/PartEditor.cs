using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class PartEditor : UserControl
    {
        public PartEditor()
        {
            InitializeComponent();
        }

        private void DrawList()
        {
            ListView lv = this.listView1;
            lv.View = View.Details;
            
            lv.Columns.Add("Property");
        }
    }
}
