using System;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace CompositeCommandBehaviorExample.ViewModel {
    public class MainViewModel : ViewModelBase {
        
        public virtual string Text { get; set; }
        public virtual string SavedText { get; set; }
        bool IsSaved { get { return SavedText == Text; } }
        protected IMessageBoxService MessageService { get { return GetService<IMessageBoxService>(); } }
        [Command]
        public void Save() {
            SavedText = Text;
        }
        public bool CanSave() {
            return !IsSaved;
        }
        [Command]
        public void Close() {
            if(!IsSaved && MessageService.ShowMessage("Do you want to close the document and lost unsaved changes?", "Warning", MessageButton.YesNo) == MessageResult.No)
                return;
            Text = String.Empty;
            SavedText = String.Empty;
        }
        public bool CanClose() {
            return !String.IsNullOrEmpty(Text);
        }
    }
}
