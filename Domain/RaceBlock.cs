using static Domain.Race;

namespace Domain
{
    public class RaceBlock
    {
        public RaceBlock(RaceType raceType, int gridRow, int gridColumn, int section, int top, int left, int height = 100, int width = 100)
        {
            RaceType = raceType;
            GridRow = gridRow;
            GridColumn = gridColumn;
            Section = section;

            Position = new Position(top, top + height,left, left + width);
        }


        public RaceType RaceType { get; set; }
        public int GridRow { get; set; }
        public int GridColumn { get; set; }
        public int Section { get; set; }
        public Position Position { get; set; }
    }
}