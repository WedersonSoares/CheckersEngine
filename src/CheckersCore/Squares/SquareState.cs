namespace CheckersCore.Squares
{
    public abstract class SquareState
    {
        public Square UpperRight { get; set; }
        public Square UpperLeft { get; set; }
        public Square BottomRight { get; set; }
        public Square BottomLeft { get; set; }
    }
}