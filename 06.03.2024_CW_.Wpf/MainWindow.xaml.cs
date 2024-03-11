using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _06._03._2024_CW_.Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //tb1.Text = "button pressd";
            
            Left.Width = new GridLength(this.Width);
            Center.Width = new GridLength(0);
            Right.Width = new GridLength(0);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Left.Width = new GridLength(0);
            Center.Width = new GridLength(this.Width);
            Right.Width = new GridLength(0);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Left.Width = new GridLength(0);
            Center.Width = new GridLength(0);
            Right.Width = new GridLength(this.Width);
        }

        private Reservation reservation = new Reservation();
        private void Reservate_Button(object sender, RoutedEventArgs e)
        {
            reservation.name = reservationName.Text;
            reservation.date = reservationDate.Text;
            reservation.table = reservationTable.Text;
        }
    }

    class Reservation
    {
        public string name {  get; set; }

        public string date { get; set; }

        public string table { get; set; }

        public Reservation()
        {

        }

        public Reservation(string name, string date, string table)
        {
            this.name = name;
            this.date = date;
            this.table = table;
        }
    }
}
