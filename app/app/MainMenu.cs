using System;
using System.Windows.Forms;

namespace app
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            Hide();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Entrance entrance = new Entrance();
            entrance.Show();
            Hide();
        }
    }
}
