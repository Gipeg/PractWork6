using System.Collections.ObjectModel;
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
using Task2;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Game> Games { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
        public Game SelectedGame { get; set; }

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
                new Game { Name= "ULTRAKILL", price = 880, Category = Categories[0], Discount = 20},
                new Game { Name= "Iron of Heart IV", price = 4000, Category= Categories[1], Discount = 30},
                new Game { Name= "Black desert", price= 857, Category= Categories[2], Discount = 10}
            };
            DataContext = this;
        }
    }
}