using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace SQL_Input_Formatter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Take each line in the textbox, trim it, comma-delimit it, surround by parenthesis for pasting in "IN (...)" query
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFormatInQuery_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder fullString = new StringBuilder();
            string[] lines = txtInQueryItems.Text.Split(Environment.NewLine);

            // Start string w/ open parenthesis for the query
            fullString.Append('(');

            for (int i = 0; i < lines.Count(); i++)
            {
                

                // Surround string with single quotes, add a comma...
                fullString.Append('\'' + lines[i].Trim() + '\'' + ',');

                // If it's the last string, remove the comma
                if (i == lines.Count() - 1)
                    fullString.Remove(fullString.Length - 1, 1);
            }

            // Add closing parenthesis
            fullString.Append(')');

            // Put full text in clipboard
            Clipboard.SetText(fullString.ToString());
        }



        private void btnClearInQuery_Click(object sender, RoutedEventArgs e)
        {
            txtInQueryItems.Clear();
        }

        private void btnFormatInsertQuery_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder fullString = new StringBuilder();
            string[] lines = txtInsertQueryItems.Text.Split(Environment.NewLine);


            for (int i = 0; i < lines.Count(); i++)
            {
                // Surround EACH string with parenthesis, and separate those w/ commas
                fullString.Append("(\'" + lines[i].Trim() + "\'),");

                // If it's the last string, remove the comma
                if (i == lines.Count() - 1)
                    fullString.Remove(fullString.Length - 1, 1);
            }

            // Put full text in clipboard
            Clipboard.SetText(fullString.ToString());
        }

        private void btnClearInsertQuery_Click(object sender, RoutedEventArgs e)
        {
            txtInsertQueryItems.Clear();
        }
    }
}
