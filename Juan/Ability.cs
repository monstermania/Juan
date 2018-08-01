using System;
using System.Collections.Generic;
using System.Text;

namespace Juan
{
    public class Ability
    {
        public string name;
        public int cost;
        public int cooldown;
        public int damage;
        public Action executeTheAbility;

        //Constructor
        public Ability()
        {
            name = "ability";
            cost = 1;
            cooldown = 0;
            damage = 1;
        }

        //string n, int e, int hp
        public Ability(string n, int nrg, int dmg, int cd, Action exec)
        {
            // paramater is liek a battery that allows the class variable (name) for example to serve its purpose in the main function
            name = n;
            cost = nrg;
            damage = dmg;
            cooldown = cd;
            executeTheAbility = exec;
        }


    }
}