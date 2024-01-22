using Syncfusion.Blazor.ImageEditor;

namespace Flo3BlazorDev.Components.Pages.image
{
    public partial class MediaManager
    {
        SfImageEditor ImageEditor;
        private List<ImageEditorToolbarItemModel> customToolbarItem = new List<ImageEditorToolbarItemModel>()
    {
        new ImageEditorToolbarItemModel { Name = "Crop" },
        new ImageEditorToolbarItemModel { Name = "Reset" },
        new ImageEditorToolbarItemModel { Name = "Confirm" }
    };

      
        private void OnSelectionResizeStart(SelectionChangeEventArgs args)
        {
            if (args.CurrentSelectionSettings.Type == "Custom")
            {
                args.CurrentSelectionSettings.Height = 200;
            }
        }
    }
}
