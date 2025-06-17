//cs
using System;
using System.Windows;

namespace DateBookingApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate.HasValue)
            {
                DateTime selectedDate = datePicker.SelectedDate.Value;
                bookingConfirmationTextBlock.Text = $"Забронировано на: {selectedDate.ToShortDateString()}";
            }
            else
            {
                bookingConfirmationTextBlock.Text = "Пожалуйста, выберите дату.";
            }
        }
    }
}
