using Engine;
using System.Media;

namespace AdventureGame
{
    public partial class AdventureGame : Form
    {
        private Player _player;

        public AdventureGame()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house.");
            
            _player = new Player(10, 10, 20, 0, 1);

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();


        }

       
    }
}