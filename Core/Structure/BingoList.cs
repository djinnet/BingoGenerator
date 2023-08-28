namespace BingoGenerator.Core.Structure;
public static class BingoList
{
    public static readonly string[] Sentences = new[]
    {
        "Awburn dies",
        "A garage",
        "Kodoki spinning right-around",
        "Andrew gets promoted to community cultivator of chaos",
        "Deerdog",
        "KF steals pikachu",
        "Snow",
        "Dancing kinfolk",
        "Underwater",
        "Publisher reveal",
        "New kinfolk reveal",
        "New character reveal",
        "5 different types of flora",
        "KF rebrands to gacha game",
        "Slyphur",
        "Djinnet makes weird software again",
        "jumping all over the world",
        "KF delayed again",
        "Phantom reveal",
        "The fog",
        "Hello darkness my old friend",
        "Neev steals... I mean ''borrowed'' stuff again",
        "meme reveal",
        "Balance changes",
        "Community got fooled. Well done.",
        "Leeks",
        "Rickroll",
        "Krindid Faytz",
        "Kodoki onesie"
        // Add more sentences here
    };

    private static List<string> _usedSentences = new List<string>();

    public static void Clear(bool allowDuplicates)
    {
        if (!allowDuplicates)
        {
            _usedSentences.Clear(); // Clear used sentences for the next card
        }
    }

    public static string GetRandomUnusedSentence()
    {
        if (_usedSentences.Count == Sentences.Length)
        {
            // All sentences have been used, reset the list
            _usedSentences.Clear();
        }

        string randomSentence;
        do
        {
            randomSentence = Sentences[new Random().Next(Sentences.Length)];
        } while (_usedSentences.Contains(randomSentence));

        _usedSentences.Add(randomSentence);
        return randomSentence;
    }

    public static string PickRandomlySentence
    {
        get
        {
            var random = new Random();
            return Sentences[random.Next(Sentences.Length)];
        }
    }
}
