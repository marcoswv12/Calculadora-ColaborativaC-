using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;

namespace CalculadoraApp
{
    public partial class HistoryWindow : Window
    {
        public HistoryWindow()
        {
            InitializeComponent();
        }

        public void SetHistory(List<string> history)
        {
            lstHistory.ItemsSource = history;
        }

        private void Close_Click(object? sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
