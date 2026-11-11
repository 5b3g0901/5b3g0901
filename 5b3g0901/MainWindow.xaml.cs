using System.Windows;

namespace _5b3g0901
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyDocumentViewer viewer = new MyDocumentViewer();
            viewer.Show();
        }
    }
}