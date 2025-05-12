using BingoGenerator.Core.Enums;
using BingoGenerator.Core.Structure;


namespace BingoGenerator.Core.Services;
public class BingoService
{
    /// <summary>
    /// Generate Bingo card
    /// </summary>
    /// <param name="allowDuplicates">If the card should included duplicated</param>
    /// <param name="IncludeFreeSpace">If the user want free space in the center of the board</param>
    /// <param name="bingoVersion">5x5 or 9x3 - default is 5x5</param>
    /// <returns>Nullable bingocard</returns>
    public static BingoCard? GenerateBingoCard(bool allowDuplicates = false, bool IncludeFreeSpace = true, EBingoVersion bingoVersion = EBingoVersion.FiveByFive)
    {

        switch (bingoVersion)
        {
            case EBingoVersion.FiveByFive:
                {
                    return GenerateFiveByFiveCard(allowDuplicates, IncludeFreeSpace);
                }

            case EBingoVersion.NineByThree:
                {
                    return GenerateNineByThree(allowDuplicates, IncludeFreeSpace);
                }

            default:
                return null;
        }
    }

    private static BingoCard GenerateNineByThree(bool allowDuplicates, bool IncludeFreeSpace)
    {
        int rows = 3;
        int cols = 9;
        BingoCard bingoCard = new()
        {
            Cells = new string[rows, cols]
        };

        // Populate cells with sentences
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                bool isFreeSpace = row == 1 && col == 4 && IncludeFreeSpace;

                bingoCard.Cells[row, col] = AddTextToCell(allowDuplicates, isFreeSpace);
            }
        }
        BingoList.Clear(allowDuplicates);

        return bingoCard;
    }

    private static BingoCard GenerateFiveByFiveCard(bool allowDuplicates, bool IncludeFreeSpace)
    {
        int rows = 5;
        int cols = 5;
        BingoCard bingoCard = new()
        {
            Cells = new string[rows, cols]
        };

        // Populate cells with sentences
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                bool isFreeSpace = row == 2 && col == 2 && IncludeFreeSpace;

                bingoCard.Cells[row, col] = AddTextToCell(allowDuplicates, isFreeSpace);
            }
        }
        BingoList.Clear(allowDuplicates);

        return bingoCard;
    }

    private static string AddTextToCell(bool allowDuplicates, bool isFreeSpace)
    {
        if (isFreeSpace)
        {
            return "FREE";
        }
        else
        {
            return allowDuplicates ? BingoList.PickRandomlySentence : BingoList.GetRandomUnusedSentence();
        }
    }
}
