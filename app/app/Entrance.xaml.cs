using System.Windows;

namespace app
{
    /// <summary>
    /// Логика взаимодействия для entrance.xaml
    /// </summary>
    public partial class Entrance : Window
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void Button_enter_Click(object sender, RoutedEventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            Hide();
        }
    }
}