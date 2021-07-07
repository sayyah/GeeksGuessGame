using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

using Domain;

namespace GuessGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Guess : Window
    {
        private UIElement _dragElement = null;
        private Point _offset;
        private Image _personImage;
        private bool _onMouseMove = false;
        private readonly DispatcherTimer _dispatcherTimer;
        private  Game _game;

        public Guess()
        {
            InitializeComponent();

            _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            
            StartNewGame();

            _dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, _game.Speed);
        }

        #region Mouse

        private void CanvasMain_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            _game.SavePicturePositionBeforeMove();
            _onMouseMove = true;
            _dragElement = sender as UIElement;
            _offset = e.GetPosition(Board);
            _offset.X = Canvas.GetLeft(_dragElement);
            _offset.Y = Canvas.GetTop(_dragElement);
            Board.CaptureMouse();
        }

        private void CanvasMain_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            //_personImage = null;
            if (_game.InRaceBlock())
            {
                SetPicture();
            }
            _onMouseMove = false;
            _dragElement = null;
            Board.ReleaseMouseCapture();
        }

        private void CanvasMain_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (_dragElement == null) return;

            var position = e.GetPosition(sender as IInputElement);
            //_windowHeight = position.Y;
            _game.Move(position.Y, position.X);
            Canvas.SetTop(_dragElement, position.Y);
            Canvas.SetLeft(_dragElement, position.X);
        }

        #endregion

        #region Timer

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Move();
            CommandManager.InvalidateRequerySuggested();
        }

        #endregion

        #region Sub

        private void StartNewGame()
        {
            _game = new Game();
            SetPicture();
            lblEnd.Visibility = Visibility.Hidden;
            btnPlayAgain.Visibility = Visibility.Hidden;
            _dispatcherTimer.Start();
        }
        private void SetPicture()
        {
            Board.Children.Remove(_personImage);
            LblPoint.Content = _game.Player.Point;
            if (!_game.HavePicture())
            {
                lblEnd.Content = $"The end!{Environment.NewLine}your point is {_game.Player.Point}.";
                lblEnd.Visibility = Visibility.Visible;
                btnPlayAgain.Visibility = Visibility.Visible;
                _dispatcherTimer.Stop();
                return;
            }
            _personImage = new Image
            {
                Source = new BitmapImage(
                    new Uri(_game.PictureOnBoard.Picture.Path)),
                Height = _game.PictureOnBoard.Picture.Height,
                Width = _game.PictureOnBoard.Picture.Width
            };
            _personImage.PreviewMouseDown += CanvasMain_PreviewMouseDown;
            Canvas.SetTop(_personImage, _game.PictureOnBoard.Position.Top);
            Canvas.SetLeft(_personImage, _game.StartPosition.Left);
            Board.Children.Add(_personImage);
            
        }

        private void Move()
        {
            if (_game.Move())
            {
                SetPicture();
            }
            if (_onMouseMove) return;
            Canvas.SetTop(_personImage, _game.PictureOnBoard.Position.Top);
            Canvas.SetLeft(_personImage, _game.StartPosition.Left);
        }

        #endregion

        #region Button

        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            StartNewGame();
        }

        #endregion
    }

}
