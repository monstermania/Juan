using System;
using System.Collections.Generic;
using System.Text;

namespace Juan
{

    public class Character
    {
        public string name;
        public int maxEnergy;
        public int energy;
        public int HP;
        public int maxHP;
        public Ability[] abilities = new Ability[4];
        public Character target; //this is a property
        public List<Effect> effects = new List<Effect>();
       


        //like a function that allows us to fill a value
        public Character()
        {
            maxEnergy = 10;
            energy = maxEnergy;
            maxHP = 20;
            HP = maxHP;
            name = "ERROR 404";
            abilities = new Ability[] { new Ability(), new Ability(), new Ability(), new Ability() };
            setupAbilities();
        }

        public Character(string n, int e, int hp)
        {
            maxEnergy = energy = e;
            maxHP = HP = hp;
            name = n;
        }

        public Character(string n, int e, int hp, Ability[] ab)
        {
            maxEnergy = energy = e;
            maxHP = HP = hp;
            name = n;
            abilities = ab;
            setupAbilities();
        }

        public void printAbilities()
        {
            foreach (Ability ability in abilities)
            {
                Console.WriteLine(ability.name);
                Console.WriteLine("\tCost: " + ability.cost);
                Console.WriteLine("\tDamage: " + ability.damage);
                Console.WriteLine("\tCooldown: " + ability.cooldown + " turns\n");
            }
        }

        public void setupAbilities()
        {
            foreach(Ability ability in abilities)
            {
                ability.self = this;
            }
        }

        public void setTarget(Character p1)
        {
            target = p1;
        } 

        public Character getTarget()
        {
            return target;
        }

        static private void test()
        {
            Console.WriteLine("BARF");
        }

        public void damageTarget(int dmg)
        {
            this.target.damage(dmg);
        }

        public void damage(int dmg)
        {
            this.HP -= dmg;
            if(this.HP <= 0)
            {
                //you got dead
                Console.WriteLine("YOU GOT DEAD IDIOT");
                System.Environment.Exit(1);
            }
        }
    }
}
