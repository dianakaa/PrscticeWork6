using System.Windows;

namespace PrscticeWork6
{
    public partial class MainWindow : Window
    {
        public List<Game> Games { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Games = new List<Game>
            {
                new Game { Name = "Ведьмак 3", Genre = "Action", Year = 2015, Rating = 4.8 },
                new Game { Name = "GTA V", Genre = "Action", Year = 2013, Rating = 4.5 },
                new Game { Name = "Valorant", Genre = "Shooter", Year = 2020, Rating = 4.7 },
                new Game { Name = "Genshin Impact", Genre = "MMO RPG", Year = 2020, Rating = 4.5 },
                new Game { Name = "Dota 2", Genre = "kakashka", Year = 2010, Rating = -2 }
            };

            gameList.ItemsSource = Games;
        }

        private void gameList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (gameList.SelectedItem is Game selectedGame)
            {
                nameTextBox.Text = selectedGame.Name;
                genreTextBox.Text = selectedGame.Genre;
                yearTextBox.Text = selectedGame.Year.ToString();
                ratingTextBox.Text = selectedGame.Rating.ToString();
            }
        }
        
    }
}
