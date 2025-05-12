namespace BingoGenerator.Core.Structure;
public static class BingoList
{
    public static readonly string[] Sentences = new[]
    {
        "A kinfolk dies in combat",
        "A kinfolk dies during ether runs",
        "A teammate dies in combat",
        "Phantom Kodoki shows up",
        "Hayes dialog",
        "Player punch",
        "Snow",
        "Rain",
        "Thunderstorm",
        "Sunny",
        "Puzzle found",
        "Bonfire found",
        "Player dies",
        "Catch 5 kinfolk",
        "Catch 10 kinfolk",
        "Catch 15 kinfolk",
        "Defeat 5 phantoms",
        "Defeat 5 bandits",
        "Defeat 10 phantoms",
        "Player needs to be underwater",
        "Player needs to be in a cave",
        "Player need to be in a building",
        "Player need to be in a forest",
        "Player need to be in a desert",
        "New character found",
        "5 different types of flora",
        "5 different types of fauna",
        "5 different types of minerals",
        "5 different types of items",
        "Catch a phantom",
        "Screenshot of the fog",
        "Put some Leeks in inventory",
        "Krindid Faytz in the beta/early access",
        "Catch Kodoki",
        "Catch Avieon",
        "Catch Awburn",
        "Deerdog statue found",
        "Evolve to Embear",
        "Evolve to Kainite",
        "Catch Slyphur",
        "Catch Lumala",
        "Catch Mechid",
        "Catch Shovlet",
        "Catch Skulken",
        "Catch Salamurder",
        "Phantom Starter",
        "Catch Golden ice lemur",
        "Catch Coal canary",
        "Carry a bucket",
        "Carry a shovel",
        "Carry a pickaxe",
        "Do the Dance dance revolution",
        "dating simulator with Hayes",
        "dating simulator with Kinfolk",
        "Screenshot of the team",
        "Screenshot of the game",
        "Screenshot of the wild kinfolk",
        "Screenshot of the wild phantoms",
        "Screenshot of the bandits",
        "Screenshot of the flora",
        "Screenshot of the sunset",
        "Buy from Sweets",
        "Buy from Hayes",
        "Mine salt rock"
        // Add more sentences here
    };

    private static readonly List<string> _usedSentences = new();

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
            randomSentence = PickRandomlySentence;
        } while (_usedSentences.Contains(randomSentence));

        _usedSentences.Add(randomSentence);
        return randomSentence;
    }

    public static string PickRandomlySentence
    {
        get
        {
            return Sentences[Random.Shared.Next(Sentences.Length)];
        }
    }
}
