using System;

namespace Juan
{
    public class Genji : Character
    {
        public Genji() : base("Genji", 10, 20)
        {
            Ability genjiSpecial = new Ability("Special", 9, 17, 6, new Action(GenjiSpecial));
            Ability shurikens = new Ability("shurikens", 3, 2, 1, new Action(Shurikens));
            Ability swiftstrike = new Ability("swiftStrike", 4, 5, 2, new Action(SwiftStrike));
            Ability cyberneticHealing = new Ability("cybernetic healing", 3, 0, 4, new Action(cyberHeals));
            // work in progress!! - blueprints- cybernetic healing - heals 5 hp 
            this.abilities = new Ability[] { swiftstrike, shurikens, genjiSpecial, cyberneticHealing };
            setupAbilities();
        }

        //swiftstrike
        //5 dmg - 4 energy
        //1 dmg/3 turns
        public void SwiftStrike()
        {
            this.damageTarget(this.abilities[0].damage);
        }

        public void Shurikens()
        {//finish me!!
            this.damageTarget(this.abilities[1].damage);
        }

        public void GenjiSpecial()
        {
            this.damageTarget(this.abilities[2].damage);
        }

        public void cyberHeals()
        {
            this.setHp(this.getHp() + 3);
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
