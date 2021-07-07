using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Domain;

namespace Domain
{
    public class Game
    {
        private int _pictureIndex = 1;
        public Game()
        {
            MoveFrame = 3;
            Speed = 10;

            Board = new Board();
            Player = new Player();
            StartPosition = new Position(-100, 0, 360, 440);
            PictureOnBoard = new PictureOnBoard(_pictureIndex, MoveFrame, StartPosition);
        }
        public Board Board { get;}
        public Player Player { get; }
        public PictureOnBoard PictureOnBoard { get;  }
        public Position StartPosition { get; }
        public Position PositionBeforeMouseMove { get; set; }
        public int Speed { get;  }
        public int MoveFrame { get; }

        public bool HavePicture()
        {
            return _pictureIndex <= Board.NumberOfPicture;
        }

        public void NextPicture()
        {
            _pictureIndex++;
            if (_pictureIndex <= Board.NumberOfPicture)
            {
                PictureOnBoard.SetPicture(_pictureIndex);
            }
        }

        public bool Move()
        {
            PictureOnBoard.Move();
            if (Math.Abs(PictureOnBoard.Position.Top - Board.Height) > 1) return false;
            Player.Point -= 5;
            NextPicture();
            return true;

        }

        public void Move(double mouseTopMove, double mouseLeftMove)
        {
           
            PictureOnBoard.Move(mouseTopMove, mouseLeftMove);
        }

        public void SavePicturePositionBeforeMove()
        {
            PositionBeforeMouseMove = new Position(PictureOnBoard.Position);
        }
        private void ResetPositionAfterMouseMove()
        {
            //PictureOnBoard.Position= PositionBeforeMouseMove;
            PictureOnBoard.Move(PositionBeforeMouseMove.Top, PositionBeforeMouseMove.Left);
        }

        public bool InRaceBlock()
        {
            RaceBlock block=null;
            foreach (var raceBlock in Board.RaceBlocks)
            {
                var onRaceBlock = InRage(PictureOnBoard.Position.Left ,raceBlock.Position.Left,40)
                                  && InRage(PictureOnBoard.Position.Right , raceBlock.Position.Right,40) 
                                  && InRage(PictureOnBoard.Position.Top , raceBlock.Position.Top,80) 
                                  && InRage(PictureOnBoard.Position.Bottom , raceBlock.Position.Bottom,80) ;
                if (onRaceBlock)
                {
                    block = raceBlock;
                    break;
                }
            }

            if (block == null)
            {
              ResetPositionAfterMouseMove();
                return false;
            }
            if (PictureOnBoard.Picture.Race == block.RaceType)
            {
                Player.Point += 20;
            }
            else
            {
                Player.Point -= 5;
            }
            NextPicture();
            return true;
        }

        private bool InRage(double picturePosition,double raceBlockPosition, int tolerance)
        {
            var result = picturePosition - raceBlockPosition;
            if (result < 0) result *= -1;
            return result <= tolerance;
        }
    }
}
