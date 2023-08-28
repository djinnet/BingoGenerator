using BingoGenerator.Core.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGenerator.Core.Services;
public class BingoService
{
    private static BingoCard? _currentCard;

    public string GetCellValue(int row, int col)
    {
        _currentCard ??= GenerateBingoCard();

        if (_currentCard.Cells is null)
            return string.Empty;

        return _currentCard.Cells[row, col];
    }

    public static BingoCard GenerateBingoCard(bool allowDuplicates = false)
    {
        var bingoCard = new BingoCard
        {
            Cells = new string[5, 5]
        };

        // Populate cells with sentences
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                if (row == 2 && col == 2)
                {
                    bingoCard.Cells[row, col] = "FREE";
                }
                else
                {
                    string randomSentence = allowDuplicates ? BingoList.PickRandomlySentence : BingoList.GetRandomUnusedSentence();
                    bingoCard.Cells[row, col] = randomSentence;
                }
            }
        }
        BingoList.Clear(allowDuplicates);

        _currentCard = bingoCard;
        return bingoCard;
    }
}
