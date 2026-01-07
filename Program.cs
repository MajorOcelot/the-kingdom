// The Kingdom: The Text-based RPG

using TheKingdom;

Game();

#region Game Main
static void Game()
{
    ConsoleInitialization();
    IntroText();

    PlayerCharacter playerCharacter = BuildCharacter();

    Console.ReadKey();
}
#endregion

#region Console Initialization
static void ConsoleInitialization()
{
    Console.Title = "The Kingdom: The Text-based RPG";

    Console.BackgroundColor = ConsoleColor.Gray;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;
}
#endregion

#region Game Intro Text
static void IntroText()
{
    // Intro text graphic/art
    Console.WriteLine("###############################################");
    Console.WriteLine("####                                       ####");
    Console.WriteLine("####    The Kingdom: The Text-based RPG    ####");
    Console.WriteLine("####                                       ####");
    Console.WriteLine("###############################################");

    // Initial adventure description
    Console.WriteLine("\nYou are an adventurer traveling to a distant mountainous region formally known as 'The Kingdom'.\n");
    Console.WriteLine("The true name of this Kingdom is unknown.\n\n" +
                      "Various tales of debauchery and the insipid practices performed by their government have spread across the globe.\n");
    Console.WriteLine("You have no wealth.\n" +
                      "You have no status.\n\n" +
                      "The only things you own are a sword, a knife, some medical supplies and the clothes on your back.");

    // Initial encounter with Soluna
    Console.WriteLine("\nA melancholic voice starts glimmering in your ears causing slight tears to swell in your eyes.\n");

    SolunaSpeech("You....\nYou are not like the those who have come before...\nListen well....\n");
}
#endregion

#region Get Player Information
static string GetPlayerName()
{
    while (true)
    {
        SolunaSpeech("What do you call yourself?");
        string playerName = Console.ReadLine();

        if (!string.IsNullOrEmpty(playerName)) { return playerName; }
        else { continue; }
    }
}

static string GetPlayerRace()
{
    while (true)
    {
        SolunaSpeech("\nWhat race are you?");

        Console.WriteLine("1. Human\n" +
                          "2. Elf\n" +
                          "3. Dwarf\n" +
                          "4. Fairy\n");

        string playerRace = Console.ReadLine();

        if (!string.IsNullOrEmpty(playerRace)) { return playerRace; }
        else { continue; }
    }
}

static string GetPlayerClass()
{
    while (true)
    {
        SolunaSpeech("\nWhat class are you?");
        Console.WriteLine("1. Warrior\n" +
                          "2. Paladin\n" +
                          "3. Mage\n" +
                          "4. Monk\n" +
                          "5. Priest\n" +
                          "6. Shaman\n");

        string playerClass = Console.ReadLine();

        if (!string.IsNullOrEmpty(playerClass)) { return playerClass; }
        else { continue; }
    }
}

static string GetPlayerGender()
{
    while (true)
    {
        SolunaSpeech("\nWhat is your gender?");
        string playerGender = Console.ReadLine();

        if (!string.IsNullOrEmpty(playerGender)) { return playerGender; }
        else { continue; }
    }
}

static int GetPlayerAge()
{
    while (true)
    {
        SolunaSpeech("\nWhat is your age?");
        int playerAge = Convert.ToInt32(Console.ReadLine());

        if (int.IsPositive(playerAge)) { return playerAge; }
        else { continue; }
    }
}
#endregion

#region Build Character
static PlayerCharacter BuildCharacter()
{
    while (true)
    {
        string pName = GetPlayerName();
        string pRace = GetPlayerRace();
        string pClass = GetPlayerClass();
        string pGender = GetPlayerGender();
        int pAge = GetPlayerAge();

        Console.WriteLine($"\n### Character Information ###\n" +
                          $"Name:\t\t {pName}\n" +
                          $"Race:\t\t {pRace}\n" +
                          $"Class:\t\t {pClass}\n" +
                          $"Gender:\t\t {pGender}\n" +
                          $"Age:\t\t {pAge}\n");

        Console.WriteLine("Is this who you really are?");
        string answer = Console.ReadLine();

        if (!string.IsNullOrEmpty(answer))
        {
            if (answer == "Yes")
            {
                PlayerCharacter playerCharacter = new PlayerCharacter();

                playerCharacter.PlayerName = pName;
                playerCharacter.PlayerRace = pRace;
                playerCharacter.PlayerClass = pClass;
                playerCharacter.PlayerGender = pGender;
                playerCharacter.PlayerAge = pAge;

                Console.WriteLine($"\nVery well, {pName}. Let's see what color your heart is...\n");

                return playerCharacter;
            }
            else
            {
                continue;
            }
        }
    }
}
#endregion

#region Character Speech Methods
static void SolunaSpeech(string dialogue)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(dialogue);
    Console.ForegroundColor = ConsoleColor.Black;
}
#endregion