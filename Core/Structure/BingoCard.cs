namespace BingoGenerator.Core.Structure;
public class BingoCard
{
    public string[,]? Cells { get; set; }

    public int Rows
    {
        get
        {
            if (Cells == null)
                return 0;
            return Cells.GetLength(0);
        }
    }

    public int Columns
    {
        get
        {
            if (Cells == null)
                return 0;
            return Cells.GetLength(1);
        }
    }

    public string GetCellValue(int row, int col)
    {
        if (Cells is null)
            return string.Empty;

        return Cells[row, col];
    }
}
