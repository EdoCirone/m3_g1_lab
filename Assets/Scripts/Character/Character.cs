using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{

    public string Name { get; set; }

    public float Hp { get; set; }

    public Character(string Name, float hp)
    {
        this.Name = Name;
        this.Hp = hp;
    }

    public abstract void Attack();

    public abstract void TakeDamage( int dmg);

}
