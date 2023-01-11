namespace ChessApp.Pieces {

    class Pawn : Piece {

        public Pawn(Color color, int[] position) : base(PieceType.PAWN, color, position) {

            CurrentPosition = position;
            IsInitialMove = true;
            IsCaptured = false;

        }

    }

}