namespace ChessApp.Pieces {

    abstract class Piece {

        public string PieceType { get; }
        protected Color Color { get; }
        protected int[] CurrentPosition { get; set; }
        protected bool IsFirstMove { get; set; }
        protected bool IsCaptured { get; set; }

        protected Piece(string type, Color color, int[] position) {

            PieceType = type;
            Color = color;
            CurrentPosition = position;
            IsFirstMove = true;
            IsCaptured = false;

        }

    }

}