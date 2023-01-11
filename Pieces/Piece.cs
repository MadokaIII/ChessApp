namespace ChessApp.Pieces {

    abstract class Piece {

        public PieceType PieceType { get; }
        protected Color Color { get; }
        protected int[] CurrentPosition { get; set; }
        protected bool IsInitialMove { get; set; }
        protected bool IsCaptured { get; set; }

        protected Piece(PieceType type, Color color, int[] position) {

            PieceType = type;
            Color = color;
            CurrentPosition = position;
            IsInitialMove = true;
            IsCaptured = false;

        }

    }

}