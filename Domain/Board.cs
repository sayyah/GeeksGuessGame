using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Board
    {
        public Board()
        {
            Height = 500;
            Width = 800;

            NumberOfPicture = 10;
            StartTopPosition = -100;

            RaceBlocks = new List<RaceBlock>();
            RaceBlocks.Add(new RaceBlock(Race.RaceType.Japanese, 0, 0, 1, 0, 0));
            RaceBlocks.Add(new RaceBlock(Race.RaceType.Thai, 0, 2, 3, 0, 700));
            RaceBlocks.Add(new RaceBlock(Race.RaceType.Chinese, 2, 0, 7, 400, 0));
            RaceBlocks.Add(new RaceBlock(Race.RaceType.Korean, 2, 2, 9, 400, 700));

            Pictures = new List<Picture>
            {
                new Picture(1, Race.RaceType.Thai, "pack://application:,,,/GuessGame;component/Pictures/Thai-001.jpg"),
                new Picture(2, Race.RaceType.Chinese, "pack://application:,,,/GuessGame;component/Pictures/Chinese-001.jpg"),
                new Picture(3, Race.RaceType.Japanese, "pack://application:,,,/GuessGame;component/Pictures/Japanese-001.jpg"),
                new Picture(4, Race.RaceType.Korean, "pack://application:,,,/GuessGame;component/Pictures/Korean-001.jpg"),
                new Picture(5, Race.RaceType.Chinese, "pack://application:,,,/GuessGame;component/Pictures/Chinese-002.jpg"),
                new Picture(6, Race.RaceType.Thai, "pack://application:,,,/GuessGame;component/Pictures/Thai-002.jpg"),
                new Picture(7, Race.RaceType.Korean, "pack://application:,,,/GuessGame;component/Pictures/Korean-002.jpg"),
                new Picture(8, Race.RaceType.Japanese, "pack://application:,,,/GuessGame;component/Pictures/Japanese-002.jpg"),
                new Picture(9, Race.RaceType.Korean, "pack://application:,,,/GuessGame;component/Pictures/Korean-003.jpg"),
                new Picture(10, Race.RaceType.Thai, "pack://application:,,,/GuessGame;component/Pictures/Thai-003.jpg")
            };
        }
        public IList<RaceBlock> RaceBlocks { get; set; }
        public IList<Picture> Pictures { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double NumberOfPicture { get; set; }
        public double StartTopPosition { get; set; }
    }
}
