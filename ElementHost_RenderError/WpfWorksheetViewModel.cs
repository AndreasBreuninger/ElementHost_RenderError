using System.Windows.Controls;

namespace ElementHost_RenderError
{
    public class WpfWorksheetViewModel : WorksheetViewModelBase
    {
        public ContentControl Form { get; set; }

        public WpfWorksheetViewModel(ContentControl form)
        {
            Form = form;
        }
    }
}
