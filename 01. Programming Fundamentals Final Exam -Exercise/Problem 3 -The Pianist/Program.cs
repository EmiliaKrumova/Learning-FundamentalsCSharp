namespace Problem_3__The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string[]> pieces = new Dictionary<string, string[]>();
            AddPiecesInDict(n, pieces);
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string realCommand = commandArgs[0];
                if (realCommand == "Add")
                {
                    AddPiece(pieces, commandArgs);

                }
                else if (realCommand == "Remove")
                {
                    RemovePiece(pieces, commandArgs);

                }
                else if (realCommand == "ChangeKey")
                {
                    ChangeKeyOfPiece(pieces, commandArgs);

                }
            }
            foreach (var piece in pieces)
            {

                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }

        }

        private static void AddPiecesInDict(int n, Dictionary<string, string[]> pieces)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = input[0];
                string composer = input[1];
                string gama = input[2];
                pieces[piece] = new string[2];
                pieces[piece][0] = composer;
                pieces[piece][1] = gama;

            }
        }

        private static void ChangeKeyOfPiece(Dictionary<string, string[]> pieces, string[] commandArgs)
        {
            string piece = commandArgs[1];
            if (pieces.ContainsKey(piece))
            {
                string newGamma = commandArgs[2];
                pieces[piece][1] = newGamma;
                Console.WriteLine($"Changed the key of {piece} to {newGamma}!");

            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void RemovePiece(Dictionary<string, string[]> pieces, string[] commandArgs)
        {
            string piece = commandArgs[1];
            if (pieces.ContainsKey(piece))
            {
                pieces.Remove(piece);
                Console.WriteLine($"Successfully removed {piece}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void AddPiece(Dictionary<string, string[]> pieces, string[] commandArgs)
        {
            string piece = commandArgs[1];
            if (!pieces.ContainsKey(piece))
            {
                pieces[piece] = new string[2];
                string composer = commandArgs[2];
                pieces[piece][0] = composer;
                string gama = commandArgs[3];
                pieces[piece][1] = gama;
                Console.WriteLine($"{piece} by {composer} in {gama} added to the collection!");
            }
            else
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }
        }
    }
}