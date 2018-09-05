using System;

namespace Juan
{
    public class stormtrooper : Character
    {
        public stormtrooper() : base("stormtrooper", 10, 20)
        {
            Ability aimBot= new Ability("aimbot", 10, 19, 8, new Action(StormtrooperSpecial));
            Ability pistolWhip = new Ability("pistolWhip", 6, 7, 4, new Action(PistolWhip));
            Ability pewPew = new Ability("pewpewBlast", 3, 4, 1, new Action(pewPewBlast));
            Ability healingMelee = new Ability("bioticSlap", 4, 0, 5, new Action(healingSlap));
            this.abilities = new Ability[] { pewPew, pistolWhip, aimBot, healingMelee };
            setupAbilities();
        }

        public void pewPewBlast()
        {
            this.damageTarget(this.abilities[0].damage);
        }

        public void PistolWhip()
        {
            this.damageTarget(this.abilities[1].damage);
        }

        public void StormtrooperSpecial()
        {
            this.damageTarget(this.abilities[2].damage);
        }

        public void healingSlap()
        {
            this.setHp(this.getHp() + 4);
        }
    }

}
