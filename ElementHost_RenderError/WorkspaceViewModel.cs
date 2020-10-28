using System.Collections.ObjectModel;

namespace ElementHost_RenderError
{
    public class WorkspaceViewModel : ViewModelBase
    {
        public WorkspaceViewModel()
        {
            Worksheets = new ObservableCollection<WorksheetViewModelBase>();
        }

        public ObservableCollection<WorksheetViewModelBase> Worksheets { get; }
    }

}
