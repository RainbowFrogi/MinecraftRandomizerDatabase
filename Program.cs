using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftRandomizerDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("*------------------------------------------------------------------------------------------------------*");
                Console.WriteLine("What block did a grassblock give you? If it didn't give you anything leave it empty!\n");

                Console.WriteLine("All possibilities are: 'blastfurnace', 'crimsonfence', 'lightgreyterracotta', 'dirt', 'acacianfence'.\n");

                Console.WriteLine("Remember to write all the words together and in lowercase letters for it to work");

                string grassblock = Console.ReadLine();

                #region strings
                #region item strings
                string diamond = "";
                string enchant = "";
                string gApple = "";
                string endcity = "";
                string totem = "";
                string pearls = "";
                string iron = "";
                string proChestDrops = "";
                #endregion

                #region potion strings
                string brownMushroom = "";
                string sugar = "";
                string gunpowder = "";
                string glowstone = "";
                string sand = "";
                string oven = "";
                string bottle = "";
                string netherwart = "";
                string spiderEye = "";
                string brewingStand = "";
                string blazeRod = "";
                string cobblestone = "";
                string ghastTear = "";
                string phantomMembrane = "";
                string rabbitFeet = "";
                string melon = "";
                string carrot = "";
                #endregion
                #endregion

                #region if-statements
                if (grassblock == "blastfurnace")
                {
                    #region item strings
                    //Sets values for the strings for this exact use case
                    diamond = "";
                    enchant = "";
                    gApple = "";
                    endcity = "daisy";
                    totem = "";
                    pearls = "";
                    iron = "";
                    proChestDrops = "";
                    #endregion

                    #region potion strings
                    brownMushroom = "";
                    sugar = "";
                    gunpowder = "";
                    glowstone = "";
                    sand = "";
                    oven = "";
                    bottle = "";
                    netherwart = "";
                    spiderEye = "";
                    brewingStand = "";
                    blazeRod = "";
                    cobblestone = "";
                    ghastTear = "";
                    phantomMembrane = "";
                    rabbitFeet = "";
                    melon = "";
                    carrot = "";
                    #endregion

                    PrintInfo();
                }
                else if (grassblock == "crimsonfence")
                {
                    #region item strings
                    //Sets values for the strings for this exact use case
                    diamond = "";
                    enchant = "";
                    gApple = "Seagrass";
                    endcity = "";
                    totem = "";
                    pearls = "";
                    iron = "";
                    proChestDrops = "Diorite and yellow flowers --> wooden button";
                    #endregion

                    #region potion strings
                    brownMushroom = "";
                    sugar = "";
                    gunpowder = "";
                    glowstone = "";
                    sand = "";
                    oven = "";
                    bottle = "";
                    netherwart = "";
                    spiderEye = "";
                    brewingStand = "";
                    blazeRod = "";
                    cobblestone = "";
                    ghastTear = "";
                    phantomMembrane = "";
                    rabbitFeet = "";
                    melon = "";
                    carrot = "";
                    #endregion

                    PrintInfo();
                }
                else if (grassblock == "lightgreyterracotta")
                {
                    #region item strings
                    //Sets values for the strings for this exact use case
                    diamond = "Pine leaves";
                    enchant = "";
                    gApple = "";
                    endcity = "";
                    totem = "";
                    pearls = "";
                    iron = "";
                    proChestDrops = "";
                    #endregion

                    #region potion strings
                    brownMushroom = "";
                    sugar = "";
                    gunpowder = "";
                    glowstone = "";
                    sand = "";
                    oven = "";
                    bottle = "";
                    netherwart = "";
                    spiderEye = "";
                    brewingStand = "";
                    blazeRod = "";
                    cobblestone = "";
                    ghastTear = "";
                    phantomMembrane = "";
                    rabbitFeet = "";
                    melon = "";
                    carrot = "";
                    #endregion

                    PrintInfo();
                }
                else if (grassblock == "dirt")
                {
                    #region item strings
                    //Sets values for the strings for this exact use case
                    diamond = "";
                    enchant = "brown mushroom block";
                    gApple = "";
                    endcity = "kelp --> light grey wool";
                    totem = "";
                    pearls = "";
                    iron = "";
                    proChestDrops = "";
                    #endregion

                    #region potion strings
                    brownMushroom = "";
                    sugar = "";
                    gunpowder = "mushroom varsi";
                    glowstone = "";
                    sand = "";
                    oven = "";
                    bottle = "";
                    netherwart = "";
                    spiderEye = "clay";
                    brewingStand = "";
                    blazeRod = "";
                    cobblestone = "";
                    ghastTear = "";
                    phantomMembrane = "";
                    rabbitFeet = "";
                    melon = "";
                    carrot = "";
                    #endregion

                    PrintInfo();
                }
                else if (grassblock == "acacianfence")
                {
                    #region item strings
                    //Sets values for the strings for this exact use case
                    diamond = "dirtpath";
                    enchant = "";
                    gApple = "";
                    endcity = "";
                    totem = "";
                    pearls = "";
                    iron = "red mushroom blocks";
                    proChestDrops = "";
                    #endregion

                    #region potion strings
                    brownMushroom = "";
                    sugar = "";
                    gunpowder = "";
                    glowstone = "";
                    sand = "";
                    oven = "";
                    bottle = "";
                    netherwart = "";
                    spiderEye = "";
                    brewingStand = "";
                    blazeRod = "";
                    cobblestone = "";
                    ghastTear = "";
                    phantomMembrane = "";
                    rabbitFeet = "";
                    melon = "";
                    carrot = "";
                    #endregion

                    PrintInfo();
                }
                //If grassblock gave you nothing, then check what item dirt gave you
                if (grassblock == "")
                {
                    Console.WriteLine("What item did a dirt give you?\n");
                    Console.WriteLine("All possibilities are: 'zombiehead', 'lilypad', 'obsidian' and 'chestdrop'.");

                    string dirtblock = Console.ReadLine();

                    //Check what dirtblock gave to the user
                    if (dirtblock == "zombiehead")
                    {
                        #region item strings
                        //Sets values for the strings for this exact use case
                        diamond = "";
                        enchant = "";
                        gApple = "";
                        endcity = "daisy";
                        totem = "";
                        pearls = "";
                        iron = "";
                        proChestDrops = "";
                        #endregion

                        #region potion strings
                        brownMushroom = "";
                        sugar = "";
                        gunpowder = "";
                        glowstone = "";
                        sand = "";
                        oven = "";
                        bottle = "";
                        netherwart = "";
                        spiderEye = "";
                        brewingStand = "";
                        blazeRod = "";
                        cobblestone = "";
                        ghastTear = "";
                        phantomMembrane = "";
                        rabbitFeet = "";
                        melon = "";
                        #endregion
                    }
                    else if (dirtblock == "lilypad")
                    {
                        #region item strings
                        //Sets values for the strings for this exact use case
                        diamond = "";
                        enchant = "";
                        gApple = "";
                        endcity = "daisy";
                        totem = "";
                        pearls = "";
                        iron = "";
                        proChestDrops = "";
                        #endregion

                        #region potion strings
                        brownMushroom = "";
                        sugar = "";
                        gunpowder = "";
                        glowstone = "";
                        sand = "";
                        oven = "";
                        bottle = "";
                        netherwart = "";
                        spiderEye = "";
                        brewingStand = "";
                        blazeRod = "";
                        cobblestone = "";
                        ghastTear = "";
                        phantomMembrane = "";
                        rabbitFeet = "";
                        melon = "";
                        #endregion
                    }
                    else if (dirtblock == "obsidian")
                    {
                        #region item strings
                        //Sets values for the strings for this exact use case
                        diamond = "";
                        enchant = "";
                        gApple = "";
                        endcity = "daisy";
                        totem = "";
                        pearls = "";
                        iron = "";
                        proChestDrops = "";
                        #endregion

                        #region potion strings
                        brownMushroom = "";
                        sugar = "";
                        gunpowder = "";
                        glowstone = "";
                        sand = "";
                        oven = "";
                        bottle = "";
                        netherwart = "";
                        spiderEye = "";
                        brewingStand = "";
                        blazeRod = "";
                        cobblestone = "";
                        ghastTear = "";
                        phantomMembrane = "";
                        rabbitFeet = "";
                        melon = "";
                        #endregion
                    }
                    else if (dirtblock == "chestdrop")
                    {
                        #region item strings
                        //Sets values for the strings for this exact use case
                        diamond = "";
                        enchant = "";
                        gApple = "";
                        endcity = "daisy";
                        totem = "";
                        pearls = "";
                        iron = "";
                        proChestDrops = "";
                        #endregion

                        #region potion strings
                        brownMushroom = "";
                        sugar = "";
                        gunpowder = "";
                        glowstone = "";
                        sand = "";
                        oven = "";
                        bottle = "";
                        netherwart = "";
                        spiderEye = "";
                        brewingStand = "";
                        blazeRod = "";
                        cobblestone = "";
                        ghastTear = "";
                        phantomMembrane = "";
                        rabbitFeet = "";
                        melon = "";
                        #endregion
                    }
                }
                //If the user didn't type any of the options, ask them if they want to try again or quit
                else
                {
                    Console.Clear();
                    Console.WriteLine("There doesn't seem to be any data for this block. Please try again, or exit the application!\n");

                    Exit();
                }
                #endregion

                //Prints the info for certain item's if there's data for them
                void PrintInfo()
                {
                    Console.WriteLine("");
                    #region PrintInfo if-statements
                    //Check if there's data for the items and if there is, it will print you how to get them
                    if (diamond != "") Console.WriteLine($"You get diamonds by breaking {diamond}");
                    if (enchant != "") Console.WriteLine($"You get enchant items by breaking {enchant}");
                    if (gApple != "") Console.WriteLine($"You get golden apples by breaking {gApple}");
                    if (endcity != "") Console.WriteLine($"You get endcity by breaking {endcity}");
                    if (totem != "") Console.WriteLine($"You get totems by breaking {totem}");
                    if (pearls != "") Console.WriteLine($"You get pearls by breaking {pearls}");
                    if (iron != "") Console.WriteLine($"You get iron by breaking {iron}");
                    if (proChestDrops != "") Console.WriteLine($"You get chest drops by breaking {proChestDrops}");
                    #endregion

                    PrintPotionInfo();

                    ResetStrings();
                }

                //Prints info of all the potions based on what grassblock and dirt gave you
                void PrintPotionInfo()
                {
                    Console.WriteLine("If you want to get the potion info for this current block, write 'potion', otherwise leave it empty");
                    string ShowPotionInfo = Console.ReadLine();
                    #region if-statements
                    if (ShowPotionInfo == "potion")
                    {
                        if (brownMushroom != "") Console.WriteLine($"You get brown mushrooms by breaking {brownMushroom}");
                        if (sugar != "") Console.WriteLine($"You get sugar by breaking {sugar}");
                        if (gunpowder != "") Console.WriteLine($"You get gunpowder by breaking {gunpowder}");
                        if (glowstone != "") Console.WriteLine($"You get glowstone by breaking {glowstone}");
                        if (sand != "") Console.WriteLine($"You get sand by breaking {sand}");
                        if (oven != "") Console.WriteLine($"You get ovens by breaking {oven}");
                        if (bottle != "") Console.WriteLine($"You get bottles by breaking {bottle}");
                        if (netherwart != "") Console.WriteLine($"You get nether wart by breaking {netherwart}");
                        if (spiderEye != "") Console.WriteLine($"You get spider eye by breaking {spiderEye}");
                        if (brewingStand != "") Console.WriteLine($"You get brewing stands by breaking {brewingStand}");
                        if (blazeRod != "") Console.WriteLine($"You get blaze rods by breaking {blazeRod}");
                        if (cobblestone != "") Console.WriteLine($"You get cobblestone by breaking {cobblestone}");
                        if (ghastTear != "") Console.WriteLine($"You get ghast tears by breaking {ghastTear}");
                        if (phantomMembrane != "") Console.WriteLine($"You get phantom membrane by breaking {phantomMembrane}");
                        if (rabbitFeet != "") Console.WriteLine($"You get rabbit feet by breaking {rabbitFeet}");
                        if (melon != "") Console.WriteLine($"You get melons by breaking {melon}");
                        if (carrot != "") Console.WriteLine($"You get carrot by breaking {carrot}");

                        Exit();
                    }
                    else
                    {
                        Exit();
                    }
                    #endregion
                }

                //Asks the user if they want to quit after any action they've made
                void Exit()
                {
                    Console.WriteLine("Write 'exit' to exit the application or leave it empty to try again!");
                    string exit = Console.ReadLine();

                    //If the user typed "exit" the while loop will stop running and the application ends
                    if (exit == "exit")
                    {
                        isRunning = false;
                    }
                }

                //Empties all the strings for a different use case
                void ResetStrings()
                {
                    #region  item string reset
                    //Empties all the strings for a different use case
                    diamond = "";
                    enchant = "";
                    gApple = "";
                    endcity = "";
                    totem = "";
                    pearls = "";
                    iron = "";
                    proChestDrops = "";
                    #endregion

                    #region potion strings
                    brownMushroom = "";
                    sugar = "";
                    gunpowder = "";
                    glowstone = "";
                    sand = "";
                    oven = "";
                    bottle = "";
                    netherwart = "";
                    spiderEye = "";
                    brewingStand = "";
                    blazeRod = "";
                    cobblestone = "";
                    ghastTear = "";
                    phantomMembrane = "";
                    rabbitFeet = "";
                    melon = "";
                    #endregion
                }
            }
        }
    }
}
