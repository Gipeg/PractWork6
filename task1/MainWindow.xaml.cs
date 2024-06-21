using System.Collections.ObjectModel;
using System.Windows;

namespace task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Game> Games { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Categories = new ObservableCollection<Category>
            {
            new Category { Name = "Шутер" },
            new Category { Name = "Стратегия" },
            new Category { Name = "MMO-RPG" }
            };

            Games = new ObservableCollection<Game>
            {
                new Game { Name= "ULTRAKILL", price = 880, Category = Categories[0]},
                new Game { Name= "StarCraft2", price = 0, Category= Categories[1]},
                new Game { Name= "WarCraft", price= 0, Category= Categories[2]}
            };
            DataContext = this;
        }
    }
}