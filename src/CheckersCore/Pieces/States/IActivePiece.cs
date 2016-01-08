namespace CheckersCore.Pieces.States
{
    public interface IActivePiece
    {
        void IdentifyPossibleMoves();

        void Die();
    }
}