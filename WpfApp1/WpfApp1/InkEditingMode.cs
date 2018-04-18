using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    class InkEditingMode : INotifyPropertyChanged
    {
        private InkCanvasEditingMode _editingModes;
        public InkCanvasEditingMode editingMode
        {
            get
            {
                return this._editingModes;
            }
            set
            {
                _editingModes = value;
                raiseEventProppertyChanged("editingMode");
            }
        }

        public void raiseEventProppertyChanged(string mode)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(mode));
        }

        public InkEditingMode()
        {
            this.editingMode = InkCanvasEditingMode.Ink;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
