using System;

namespace Juan
{

    //TODO:
    ///----
    ///make effects for turnns.
    ///finish abilitiews for characters
    ///make the dylan character
    ///recharge energy
    /// make so u cant pick the sam eguy OR if u are going to pick the same guy it can t be in the same instance of the character in the static characters list maybe time to go not static
    class Program
    {
        public Character[] characters = new Character[2];
        public  Character p1;
        public  Character p2;
        int turnsPast = 0;

        // 

        static void Main(string[] args)
        {

            //string n, int e, int hp

            //  SetupCharacters();

            Program OverallProgram = new Program();
            OverallProgram.overallProgram();
        }

        public void overallProgram()
        {
            Character genji = new Genji();
            Character zombie = new Zombie();
            Character stormtrooper = new stormtrooper();


            characters = new Character[] { genji, zombie, stormtrooper };


            StartupScreen();     // Done!

            pickPlayerOne();

            pickPlayerTwo();

            setTarget();

            battle();

            end();

        }

        //static private void SetupCharacters()
        // {                                                   // energyLevel - maxHp //cost - damage - cooldown
        // setUpGenji();
        //  setUpZombie();
        //setUpDylan();
        //  }

        //static private void setUpGenji()
        //{
        //    //Setup Genji                                  
        //    Ability genjiSpecial = new Ability("Special", 9, 17, 6, new Action(test));
        //    Ability shurikens = new Ability("shurikens", 3, 2, 1, new Action(test));
        //    Ability swiftstrike = new Ability("swiftStrike", 4, 5, 2, new Action(test));
        //    Character genji = new Character("Genji", 10, 20, new Ability[] { swiftstrike, shurikens, genjiSpecial });

        //    characters[0] = genji;//sets spot number 0 or index 0 to genji also make sure to use index 0 not spit number 0.

        //}

        //static private void setUpZombie()
        //{
        //    //Setup Zombie


        //    characters[1] = zombie;
        //}




         private void StartupScreen()
        {
            rightCenterText("<===================CrappyPokemon==================>");
            rightCenterText("<==================================================>");//title/credits
            rightCenterText("<==============Made by: Zeeshan Asad ==============>");
            rightCenterText("<====Additonal people that helped me make this ====>");
            rightCenterText("<========My Dad, Bret, Dylan, and Fabricio=========>");
            rightCenterText("<==================================================>");
            rightCenterText("<*><*><*><*><*><press enter to start><*><*><*><*><*>");

            String startup = Console.ReadLine();
            if (startup != null)
            {
                Console.Clear();//BOOM! Console clear on to the next scren 
            }
        }
        
         private void rightCenterText(string Juany)
        {
            // centers title screen
            string a = Juany;
            Console.SetCursorPosition((Console.WindowWidth - a.Length) / 2, Console.CursorTop);
            Console.WriteLine(a);
        }

         private void home()
        {

        }

         private void ListAbilities(string character)
        {
            //int charIndex = 0;
            switch (character.ToLower())
            {
                case "genji":
                    characters[0].printAbilities();
                    //charIndex = 0;
                    break;
                case "zombie":
                    characters[1].printAbilities();
                    //charIndex = 1;
                    break;
                case "stormtrooper":
                    characters[2].printAbilities();
                    //charIndex = 2;
                    break;
                default:
                    break;
            }

        }


         private void pickPlayerOne()
        {
            Console.WriteLine("Player 1 - Pick your hero!");
            Console.WriteLine("Choices~: zombie, genji, stormtrooper");
            Console.WriteLine("Note: please type hero name EXACTLY as shown above.");
            String p1Choice = Console.ReadLine();
            if (heroValid(p1Choice))
            {
                Console.Clear();
                //print abilities
                ListAbilities(p1Choice);
                //confirm your choice
                p1 = heroConfirm(p1Choice) ? GetCharacter(p1Choice) : null;
                //p1.target = p2;
            }
            else
            {
                pickPlayerOne();
            }
            Console.Clear();
        }




         private bool heroConfirm(string character)
        {

           Console.WriteLine("Are you sure you want to choose " + character + "? y/n");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "y")
            {
                Console.Clear();
                return true;
            }
            else {
                return false;
            }
        }



         private void pickPlayerTwo()
        {
            Console.WriteLine("Player 2 - Pick your hero!");
            Console.WriteLine("Choices~: zombie, genji, stormtrooper");

            String p2Choice = Console.ReadLine();
            if (heroValid(p2Choice))
            {
                Console.Clear();
                ListAbilities(p2Choice);
                p2 = heroConfirm(p2Choice) ? GetCharacter(p2Choice) : null; // if condition ? (value returned if true) : (value returned if false);
                //p2.target = p1;
            }
            else
            {
                pickPlayerTwo();
            }
            Console.Clear();
        }
        


         private bool heroValid(string p1)
        {
            p1 = p1.ToLower();
            if (p1 == "zombie" || p1 == "genji" || p1 == "stormtrooper")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please pick a valid hero. Press enter key to continue.");
                Console.ReadLine();
                return false;
            }
        }



         Character GetCharacter(string name)
        {
            foreach(Character c in characters){
                if(c.name.ToLower() == name)
                {
                    return c;
                }
            }

            return null;
        }



         private void battle()
        {

            bool p1Turn = true;

            while (true)
            {
                Console.Clear();
                if (p1Turn)
                {
                    Console.WriteLine("Player 1 turn");
                    listHealthEnergy();
                    ListAbilities(p1.name);//prints out the abilitys on the console
                    Console.WriteLine("please enter the number that matches the ability, to choose the ability.");
                    int p1AbilityResponse = Int32.Parse(validateAbilityInput());
                    //to convert a stirn to an integer you have to write the integer int bob for example then an equal sign and then write Int32.Parse(Console.ReadLine)

                    Ability ability = p1.abilities[p1AbilityResponse - 1];  //save the chosen ability
                    ability.useAbility();    //use the ability
                    p1.setEnergy(p1.getEnergy() + 3);
                }


                else
                {
                    Console.WriteLine("player 2 turn");
                    listHealthEnergy();
                    ListAbilities(p2.name);
                    Console.WriteLine("please enter the number that matches the ability, to choose the ability.");
                    int p2AbilityResponse = Int32.Parse(validateAbilityInput());

                    //to convert a stirn to an integer you have to write the integer int bob for example then an equal sign and then write Int32.Parse(Console.ReadLine)
                    Ability ability = p2.abilities[p2AbilityResponse - 1];  //save the chosen ability

                    if()
                    {

                    }


                    ability.useAbility();    //use the ability
                    p2.setEnergy(p2.getEnergy() + 3);
                }

                //Console.ReadLine();
                p1Turn = !p1Turn;
                turnsPast++;
                
            }
        }
        //if()
        //{
       // 
        //}


         public void listHealthEnergy()
        { 
            Console.WriteLine("Turn Counter : "     + turnsPast);
            Console.WriteLine("Player One Health: " + p1.HP);
            Console.WriteLine("Player One Energy: " + p1.energy);
            Console.WriteLine("<--------------------------------->");
            Console.WriteLine("Player Two Health: " + p2.HP);
            Console.WriteLine("Player Two Energy: " + p2.energy);
        }



         private string validateAbilityInput()
        {
            string userinput = Console.ReadLine();

            if (userinput == "1" || userinput == "2" || userinput == "3" || userinput == "4")
            {
                return userinput;
            }
            else
            {
                Console.WriteLine("Don't hate on recursion type the ability right");
                return validateAbilityInput();
            }

        }



         private void setTarget()
        {
            p1.target = p2;
            p2.target = p1;
        }
        

        // static memory and dynamic memory or stac and heap diffrent most of the program should be in dynamic memory. but static memory has a few uses such as math classes and other utility classes.

         private void end()
        {

        }
    }
}