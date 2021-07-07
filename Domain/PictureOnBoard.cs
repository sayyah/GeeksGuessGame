using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class PictureOnBoard
    {
        public Position Position { get; set; }
        public Picture Picture { get; set; }

        readonly Board _board = new Board();
        readonly int _moveFrame;
        public PictureOnBoard(int pictureId, int moveFrame,Position startPosition)
        {
            _moveFrame = moveFrame;
            Position = new Position(startPosition);
            
            SetPicture(pictureId);
        }

        public void Move()
        {
            Position.Top += _moveFrame;
        }

        public void Move(double top,double left)
        {
            Position.Top = top;
            Position.Bottom = top+ Picture.Height;
            Position.Left = left;
            Position.Right = left+ Picture.Width;
        }

        public void SetPicture(int pictureId)
        {
            Picture = _board.Pictures.First(x => x.Id == pictureId);
            Position.Top = _board.StartTopPosition;
        }

       
        
    }
}
