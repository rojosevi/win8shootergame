using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MonoGame.Framework;
using Windows.ApplicationModel.Activation;


namespace win8shootergame
{
    /// <summary>
    /// The root page used to display the game.
    /// </summary>
    public sealed partial class GamePage : SwapChainBackgroundPanel
    {
        readonly Game1 _game;

        public GamePage(LaunchActivatedEventArgs args)
        {
            this.InitializeComponent();

            // Create the game.
            _game = XamlGame<Game1>.Create("test", Window.Current.CoreWindow, this);
        }
    }
}
