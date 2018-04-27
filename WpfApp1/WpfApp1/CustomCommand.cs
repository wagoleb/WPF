using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomCommandNM
{
    public static class CustomCommand
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand(
            "App Exit",
            "Exit",
            typeof(CustomCommand),
            new InputGestureCollection()
            { new KeyGesture(Key.Q, ModifierKeys.Control) }
            );
    }
}
