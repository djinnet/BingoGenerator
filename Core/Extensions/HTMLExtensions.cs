using BingoGenerator.Core.Services;

namespace BingoGenerator.Core.Extensions;

public static class HTMLExtensions
{
    public static bool IsDebug(this BingoService bingoService)
    {
#if DEBUG
        return true;
#else
      return false;
#endif
    }
}
