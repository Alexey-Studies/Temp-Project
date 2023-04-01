namespace app
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();// test coment
        }
    }


    class Day
    {
        //создать структуру.
        struct Monday
        {
            public Lesson para1;
            public Lesson para2;
            public Lesson para3;
            public Lesson para4;
            public Lesson para5;
        }
    }
    class Lesson
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public string Type { get; set; }
    }
    class Week : Day
    {
        public bool typeweek { get; set; }
    }
    class Month : Week
    {
        struct September
        {
            public byte kolichestvo; //количество дней в месяце.Заменить на Date.

        }
    }
    class Semestr
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
    class Disciplina
    {
        public string Name
        {
            get; set;
        }
        public string Facultet { get; set; }
        public int Kurs { get; set; }
    }
}
