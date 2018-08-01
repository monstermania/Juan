﻿using System;
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

        //like a function that allows us to fill a value
        public Character()
        {
            maxEnergy = 10;
            energy = maxEnergy;
            maxHP = 20;
            HP = maxHP;
            name = "ERROR 404";
            abilities = new Ability[] { new Ability(), new Ability(), new Ability(), new Ability() };
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
    }
}