namespace CheckersCore.Movements
{
    public abstract class Move
    {
        private MoveState MoveState { get; set; }

        public abstract void Execute();

        public abstract void Undo();
    }
}