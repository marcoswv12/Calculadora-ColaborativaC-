using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;

namespace CalculadoraApp
{
    public partial class MainWindow : Window
    {
        private string currentInput = "";
        private float? lastValue = null;
        private char? lastOperation = null;
        private List<string> history = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object? sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                string content = btn.Content.ToString();

                // Permitir apenas um ponto decimal
                if (content == "." && currentInput.Contains("."))
                    return;

                currentInput += content;
                txtDisplay.Text = currentInput;
            }
        }

        private void Operation_Click(object? sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (float.TryParse(currentInput, out float num))
                {
                    if (lastValue == null)
                    {
                        lastValue = num;
                    }
                    else if (lastOperation != null)
                    {
                        lastValue = Calculate(lastValue.Value, num, lastOperation.Value);
                        txtDisplay.Text = lastValue.ToString();
                    }
                }

                currentInput = "";

                char op = btn.Content.ToString()[0];
                if (op == '√')
                {
                    if (lastValue != null)
                    {
                        float resultado = (float)Math.Sqrt(lastValue.Value);
                        AddToHistory($"√{lastValue} = {resultado}");
                        lastValue = resultado;
                        txtDisplay.Text = lastValue.ToString();
                    }
                }
                else
                {
                    lastOperation = op;
                }
            }
        }

        private void Equals_Click(object? sender, RoutedEventArgs e)
        {
            if (lastValue != null && lastOperation != null && float.TryParse(currentInput, out float num))
            {
                float resultado = Calculate(lastValue.Value, num, lastOperation.Value);
                AddToHistory($"{lastValue} {lastOperation} {num} = {resultado}");
                lastValue = resultado;
                txtDisplay.Text = lastValue.ToString();
                currentInput = "";
                lastOperation = null;
            }
        }

        private void Clear_Click(object? sender, RoutedEventArgs e)
        {
            currentInput = "";
            lastValue = null;
            lastOperation = null;
            txtDisplay.Text = "";
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            var historyWindow = new HistoryWindow();
            historyWindow.SetHistory(history);
            historyWindow.Show();
        }

        private void AddToHistory(string operation)
        {
            if (history.Count >= 10)
                history.RemoveAt(0);

            history.Add(operation);
        }

        private float Calculate(float a, float b, char op)
        {
            return op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => b != 0 ? a / b : 0,
                _ => 0
            };
        }
    }
}
