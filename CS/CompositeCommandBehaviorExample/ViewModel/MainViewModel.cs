using System;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Collections.Generic;

namespace CompositeCommandBehaviorExample.ViewModel {
    public class MainViewModel : ViewModelBase {
        protected MainViewModel() { }
        public static MainViewModel Create() {
            return ViewModelSource.Create(() => new MainViewModel());
        }
        
        public virtual string Text { get; set; }
        public virtual string SavedText { get; set; }
        bool IsSaved { get { return SavedText == Text; } }
        protected IMessageBoxService MessageService { get { return GetService<IMessageBoxService>(); } }

        public void Save() {
            SavedText = Text;
        }
        public bool CanSave() {
            return !IsSaved;
        }
        public void Close() {
            if(!IsSaved && MessageService.ShowMessage("Are you sure to close unsaved document", "Warning", MessageButton.YesNo) == MessageResult.No)
                return;
            Text = String.Empty;
            SavedText = String.Empty;
        }
        public bool CanClose() {
            return !String.IsNullOrEmpty(Text);
        }
    }
}
