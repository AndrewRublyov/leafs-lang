namespace LeafS.Lexer
{
    /// <summary>
    ///     Determines token position in source code
    /// </summary>
    public class TokenPosition
    {
        public TokenPosition(int column, int row)
        {
            Column = column;
            Row = row;
        }

        public int Column { get; set; }
        public int Row { get; set; }
    }
}