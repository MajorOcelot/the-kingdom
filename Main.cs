// The Kingdom: The Text-based RPG

/* ------ TODO ------ */
// Finish the Blind Man encounter
// Create friendly NPCs
// Create enemies/bosses
// Create Armor, Race, Gender, and Age parameters to modify damage/standing with certain people
// Decide what towns/locations/shops are going to exist
// Come up with town/location/shop names

using Newtonsoft.Json;
using TheKingdom;

Game();

#region Game Main
static void Game()
{
    ConsoleInitialization();
    IntroText();

    PlayerCharacter playerCharacter = BuildCharacter();

    SaveGame(playerCharacter);

    TheTower(playerCharacter);

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

#region Save/Load Game
static void SaveGame(PlayerCharacter player)
{
    string directoryPath = @"C:\TheKingdom";
    Directory.CreateDirectory("TheKingdom");

    if (Directory.Exists(directoryPath))
    {
        Console.WriteLine("Game directory already exists. A new one will not be created.");
    }

    string gameSaveData = JsonConvert.SerializeObject(player);

    Console.WriteLine(gameSaveData);

    try
    {
        File.WriteAllText(directoryPath, gameSaveData);
        Console.WriteLine("Your game has been saved.");
    }
    catch
    {
        Console.WriteLine("There was an error saving your file. Please try again.");
    }

    Console.ReadKey();
}

//static void LoadGame()
//{

//}

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
                      "The only things you own are a sword, a shield, some medical supplies and the armor on your back.");

    // Initial encounter with Soluna
    Console.WriteLine("\nA melancholic voice starts glimmering in your ears causing slight tears to swell in your eyes.\n");

    Soluna("You....\nYou are not like the those who have come before...\nListen well....\n");
}
#endregion

#region Get Player Information
static string GetPlayerName()
{
    while (true)
    {
        Soluna("What do you call yourself?");
        string? playerName = Console.ReadLine();

        if (!string.IsNullOrEmpty(playerName)) { return playerName; }
        else { continue; }
    }
}

static string GetPlayerRace()
{
    while (true)
    {
        Soluna("\nWhat race are you?");

        Console.WriteLine("1. Human\n" +
                          "2. Elf\n" +
                          "3. Dwarf\n" +
                          "4. Fairy\n");

        string? playerRace = Console.ReadLine();

        if (!string.IsNullOrEmpty(playerRace)) { return playerRace; }
        else { continue; }
    }
}

static string GetPlayerClass()
{
    while (true)
    {
        Soluna("\nWhat class are you?");
        Console.WriteLine("1. Warrior\n" +
                          "2. Paladin\n" +
                          "3. Mage\n" +
                          "4. Monk\n" +
                          "5. Priest\n" +
                          "6. Shaman\n");

        string? playerClass = Console.ReadLine();

        if (!string.IsNullOrEmpty(playerClass)) { return playerClass; }
        else { continue; }
    }
}

static string GetPlayerGender()
{
    while (true)
    {
        Soluna("\nWhat is your gender?");
        string? playerGender = Console.ReadLine();

        if (!string.IsNullOrEmpty(playerGender)) { return playerGender; }
        else { continue; }
    }
}

static int GetPlayerAge()
{
    while (true)
    {
        Soluna("\nWhat is your age?");
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
        string? answer = Console.ReadLine();

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

                Soluna($"\nVery well, {pName}. Let's see what color your heart is...\n");

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

#region Dialogue Methods
static void UserAction(string action)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(action);
    Console.ForegroundColor = ConsoleColor.Black;
}

static void Soluna(string dialogue)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(dialogue);
    Console.ForegroundColor = ConsoleColor.Black;
}
#endregion

#region The Tower
static void TheTower(PlayerCharacter player)
{
    Console.Clear();
    Console.WriteLine("After what feels like an eternity, you manage to open your eyes and raise your head.\n\n" +
                      "The pain is gone and all you can hear is the crackling coming from your torch, its flame dancing with the wind.\n");

    Console.WriteLine("'That cannot be natural...', you think to yourself.\n" +
                      "You look into the distance and see a silouhette of a tower.\n");

    TowerIntro(player);
}
#endregion

#region Tower Logic
static void TowerIntro (PlayerCharacter player)
{
    Console.WriteLine("What would you like to do?\n");

    Console.WriteLine("1. Move forward and start approaching the tower.\n" +
                      "2. Check yourself for injuries.\n" +
                      "3. Take some time for sustenance.\n");

    int response = Convert.ToInt32(Console.ReadLine());

    if (response == 1) { TowerEntranceHub(); }

    else if (response == 2) 
    { 
        UserAction("\nYou notice there is a small gash in your armor, but there are no signs of injury.\n");
        TowerIntro(player);
    }
    else if (response == 3)
    {
        if (player.PlayerHealth < 100 && player.PlayerMana < 100)
        {
            UserAction("\nYou fish a beef pasty out of your pack and begin to eat it. You gained 25 health and 5 mana.");
            player.PlayerHealth += 25;
            player.PlayerMana += 5;

            Console.WriteLine($"\nYou now have {player.PlayerHealth} health and {player.PlayerMana} mana.\n");

            TowerIntro(player);
        }
        else 
        { 
            Console.WriteLine("\nYou have already replenished your health and mana enough to survive.\n");
            TowerIntro(player);
        }
    }
    else 
    { 
        Console.WriteLine("Please choose a valid option.");
        TowerIntro(player);
    }
}

static void TowerEntranceHub()
{
    UserAction("\nYou begin walking towards the tower, looking for any sign of movement.\n");

    // FINISH THE FUCKING TOWER ENTRANCE HUB METHOD
}

//static void BlindMan()
//{

//}
#endregion