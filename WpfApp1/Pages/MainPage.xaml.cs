using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public Document _document = new Document();

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            _document.Number = Int32.Parse(tbxDocumentNumber.Text);
            _document.Date = (DateTime)tbxDocumentDate.SelectedDate;
            _document.Type = cbxDocumentType.Text;

            dp1.Visibility = Visibility.Hidden;
            dp2.Visibility = Visibility.Visible;

            //MainWindow._BaseFrame.Source = new Uri("Pages/Page2.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            _document.FileName = tbxFileName.Text;
        }
    }
}
