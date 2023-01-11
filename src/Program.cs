using ChessApp.Pieces;

class Program {

    public static void Main(string[] args) {

        int[] pos = { 3, 4 };
        Pawn pawn = new Pawn(Color.BLACK, pos);
        Console.WriteLine(pawn.PieceType);

    }

}
