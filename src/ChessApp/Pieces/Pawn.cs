namespace ChessApp.Pieces {

    class Pawn : Piece {

        public Pawn(Color color, int[] position) : base("Pawn", color, position) {

            CurrentPosition = position;
            IsFirstMove = true;
            IsCaptured = false;

        }

    }

}