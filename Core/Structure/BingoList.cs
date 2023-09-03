namespace BingoGenerator.Core.Structure;
public static class BingoList
{
    public static readonly string[] Sentences = new[]
    {
        "A kinfolk dies",
        "A garage",
        "Kodoki spinning right-around",
        "Andrew gets promoted to community cultivator of chaos",
        "KF steals pikachu",
        "Snow",
        "Rain",
        "Thunderstorm",
        "Sunny",
        "Puzzle reveal",
        "Town reveal",
        "Death",
        "Sadness",
        "Sad music",
        "Epic music",
        "Hype music",
        "Silent music",
        "Dancing kinfolk",
        "Underwater",
        "Publisher reveal",
        "New kinfolk reveal",
        "New character reveal",
        "5 different types of flora",
        "KF rebrands to gacha game",
        "jumping all over the world",
        "KF delayed again",
        "Phantom reveal",
        "The fog",
        "Hello darkness my old friend",
        "Neev revealed to be a dog",
        "Meme reveal",
        "Balance changes",
        "Leeks",
        "Rickroll",
        "Krindid Faytz",
        "onesie with kinfolk theme",
        "New Active Ability reveal",
        "New Passive Ability reveal",
        "New Item reveal",
        "unknown kinfolk's type reveal",
        "Kodoki",
        "Avieon",
        "Awburn",
        "Deerdog",
        "Embear",
        "Galvolant",
        "Gladias",
        "Kahstrix",
        "Kainite",
        "Slyphur",
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
        "Rob made an appearence in the video",
        "Golden ice lemur reveal",
        "Coal canary reveal",
        "Bucket reveal",
        "Ynku is talking about Kubikro again",
        "Dance dance revolution reveal",
        "Hitman reveal",
        "Better Quality of Life game mechanics",
        "New game mechanics reveal",
        "Guild game mechanics reveal",
        "Mentor game mechanics reveal",
        "Map reveal",
        "Bork reveal",
        "Community makes memes of direct in discord",
        "Game Boy Advance release reveal",
        "''Are we the baddies?''",
        "Kindred fates has become dating simulator"
        // Add more sentences here
    };

    public static readonly string[] WeirdSentences = new[]
    {
        "Players are necromancers",
        "Players are druids",
        "The dice hits 20",
        "Community got fooled. Well done.",
        "Djinnet makes weird software again",
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
