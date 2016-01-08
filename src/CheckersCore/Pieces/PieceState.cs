using CheckersCore.Movements;

namespace CheckersCore.Pieces
{
    public abstract class PieceState
    {
        public Direction AllowedDirection { get; set; }
    }
}