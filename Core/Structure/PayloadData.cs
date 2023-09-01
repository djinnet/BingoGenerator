namespace BingoGenerator.Core.Structure;

public class PayloadData
{
    public PayloadData(string data)
    {
        Data = data;
    }
    public string? Data { get; set; } = string.Empty;
}
