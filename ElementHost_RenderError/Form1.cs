using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementHost_RenderError
{
    public partial class Form1 : Form
    {

        private readonly WorkspaceViewModel _workspace = new WorkspaceViewModel();

        public Form1()
        {
            InitializeComponent();

            elementHost1.Child = new MainControl(){DataContext = _workspace};

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _workspace.Worksheets.Add(new WinformsWorksheetViewModel(new Button(){Text = "WinForms"}));
            _workspace.Worksheets.Add(new WpfWorksheetViewModel(new System.Windows.Controls.Button(){Content = "WPF"}));
            _workspace.Worksheets.Add(new WinformsWorksheetViewModel(new HostFormControl(new System.Windows.Controls.Button() { Content = "WinForms/WPF" })));
        }
    }
}
