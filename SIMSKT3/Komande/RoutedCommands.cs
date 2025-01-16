using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SIMSKT3.Komande
{
    public static class RoutedCommands
    {
        public static readonly RoutedUICommand LogIn = new RoutedUICommand(
            "Log in",
            "LogIN",
            typeof(RoutedCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.L, ModifierKeys.Control),
                new KeyGesture(Key.L, ModifierKeys.Alt | ModifierKeys.Control)
            }
            );

        public static readonly RoutedUICommand CreateAnamnesis = new RoutedUICommand(
           "Create Anamnesis",
           "CreateAnamnesis",
           typeof(RoutedCommands),
           new InputGestureCollection()
           {
                new KeyGesture(Key.B, ModifierKeys.Control),
                new KeyGesture(Key.B, ModifierKeys.Alt | ModifierKeys.Control)
           }
           );

        public static readonly RoutedUICommand UpdateAnamnesis = new RoutedUICommand(
           "Update Anamnesis",
           "UpdateAnamnesis",
           typeof(RoutedCommands),
           new InputGestureCollection()
           {
                new KeyGesture(Key.U, ModifierKeys.Control),
                new KeyGesture(Key.U, ModifierKeys.Alt | ModifierKeys.Control)
           }
           );

        public static readonly RoutedUICommand ClearFields = new RoutedUICommand(
           "Clear Fields",
           "ClearFields",
           typeof(RoutedCommands),
           new InputGestureCollection()
           {
                new KeyGesture(Key.D, ModifierKeys.Control),
                new KeyGesture(Key.D, ModifierKeys.Alt | ModifierKeys.Control)
           }
           );

        public static readonly RoutedUICommand SeeAll = new RoutedUICommand(
           "See All",
           "SeeAll",
           typeof(RoutedCommands),
           new InputGestureCollection()
           {
                new KeyGesture(Key.W, ModifierKeys.Control),
                new KeyGesture(Key.W, ModifierKeys.Alt | ModifierKeys.Control)
           }
           );

        public static readonly RoutedUICommand SeeOne = new RoutedUICommand(
           "See One",
           "SeeOne",
           typeof(RoutedCommands),
           new InputGestureCollection()
           {
                new KeyGesture(Key.O, ModifierKeys.Control),
                new KeyGesture(Key.O, ModifierKeys.Alt | ModifierKeys.Control)
           }
           );

        public static readonly RoutedUICommand UpdateMedication = new RoutedUICommand(
           "Update Medication",
           "UpdateMedication",
           typeof(RoutedCommands),
           new InputGestureCollection()
           {
                new KeyGesture(Key.U, ModifierKeys.Control),
                new KeyGesture(Key.U, ModifierKeys.Alt | ModifierKeys.Control)
           }
           );

        public static readonly RoutedUICommand Accept = new RoutedUICommand(
           "Accept",
           "Accept",
           typeof(RoutedCommands),
           new InputGestureCollection()
           {
                new KeyGesture(Key.F, ModifierKeys.Control),
                new KeyGesture(Key.F, ModifierKeys.Alt | ModifierKeys.Control)
           }
           );

        public static readonly RoutedUICommand Decline = new RoutedUICommand(
           "Decline",
           "Decline",
           typeof(RoutedCommands),
           new InputGestureCollection()
           {
                new KeyGesture(Key.R, ModifierKeys.Control),
                new KeyGesture(Key.R, ModifierKeys.Alt | ModifierKeys.Control)
           }
           );

        public static readonly RoutedUICommand Confirm = new RoutedUICommand(
           "Confirm",
           "Confirm",
           typeof(RoutedCommands),
           new InputGestureCollection()
           {
                new KeyGesture(Key.P, ModifierKeys.Control),
                new KeyGesture(Key.P, ModifierKeys.Alt | ModifierKeys.Control)
           }
           );
    }
}
