using System;
using System.Windows;
using Xceed.Wpf.Toolkit;
using utauPlugin;

namespace LengthRandomizer
{
    public partial class MainWindow : Window
    {
        private UtauPlugin utauPlugin;
        string[] args = Environment.GetCommandLineArgs();
        public MainWindow()
        {
            InitializeComponent();
            utauPlugin = new UtauPlugin(args[1]);
            utauPlugin.Input();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            foreach (Note note in utauPlugin.note)
            {
                // do something

                //note.SetLength(note.GetLength() + rand.Next(0 - (int)this.amount.Value, (int)this.amount.Value));
            }
            utauPlugin.Output();
            Close();
        }
    }
}
