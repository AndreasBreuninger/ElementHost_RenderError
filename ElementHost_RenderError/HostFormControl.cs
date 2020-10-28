using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ElementHost_RenderError
{
    public partial class HostFormControl : UserControl
    {
        public HostFormControl(FrameworkElement control)
        {
            InitializeComponent();

            elementHost1.Child = control;
        }
    }
}
