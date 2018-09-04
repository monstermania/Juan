using System;

namespace Juan
{
    public class Zombie : Character
    {
        public Zombie() : base("Zombie", 10, 20)
        {
            Ability zombieSpecial = new Ability("Special", 10, 19, 8, new Action(Special));
            Ability vommitShot = new Ability("vommit shot", 6, 7, 4, new Action(VomitShot));
            Ability bite = new Ability("bite", 4, 3, 1, new Action(Bite));
            Ability eatPeople = new Ability("eatPoople", 4, 0, 5, new Action(EatingPoople)); 
            this.abilities = new Ability[] { bite, vommitShot, zombieSpecial, eatPeople };
            setupAbilities();
        }
        //swiftstrike
        //5 dmg - 4 energy
        //1 dmg/3 turns
        public void Bite()
        {
            this.damageTarget(this.abilities[0].damage);
        }

        public void VomitShot()
        {
            this.damageTarget(this.abilities[1].damage);
        }

        public void Special()
        {
            this.damageTarget(this.abilities[2].damage);
        }

        public void EatingPoople()
        {
            this.setHp(this.getHp() + 4);
        }

        //2 dmg/ shuriken
        // option 1 - throw suriken right away
        // option two - hold 1 more suriken for your turn. 
        //You can hold up to 3 shurikens. 
        //shuriken counter for the number of shurikens the you have saved up.

        //special 
        //deals huge amount of damage
        //huge cooldown time
        //applies a de-buff called curse of the dragon
        //curse of the dragon- makes enemy deal 2x less dmg for 3 turns.

        // all comments are work in progresses
    }
}
