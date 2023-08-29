namespace BingoGenerator.Core.Structure;
public static class BingoList
{
    public static readonly string[] Sentences = new[]
    {
        "A kinfolk dies",
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
        "Kodoki onesie",
        "New Active Ability reveal",
        "New Passive Ability reveal",
        "New Item reveal",
        "A unknown kinfolk's type reveal",
        "Avieon",
        "Awburn",
        "Embear",
        "Galvolant",
        "Gladias",
        "Kahstrix",
        "Kainite",
        "Kubikro",
        "Lumala",
        "Mechid",
        "Nyazen",
        "Shovlet",
        "Skulken",
        "Bashful Strider",
        "Hull Piercer",
        "Salamurder",
        "Legendary kinfolk reveal",
        "Starter reveal",
        "New world building reveal",
        "Beta release date",
        "Bees- not the bees!",
        "Dark soul combat",
        "Mario karts combat",
        "Another free space?",
        "Kinfolk equipment reveal",
        "Crossover reveal",
        "Players are necromancers",
        "Players are druids",
        "The dice hits 20",
        "Rob made an appearence in the video",
        "Golden ice lemur reveal",
        "Coal canary reveal",
        "Bucket reveal"
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
