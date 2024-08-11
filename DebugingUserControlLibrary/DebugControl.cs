using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugingUserControlLibrary
{
    public partial class DebugControl : UserControl
    {
        private string demoStringValue = null;
        [Browsable(true)]
        public string DemoString
        {
            get
            {
                return this.demoStringValue;
            }
            set
            {
                demoStringValue = value;
            }
        }
        public DebugControl()
        {
            InitializeComponent();
        }
    }
}
