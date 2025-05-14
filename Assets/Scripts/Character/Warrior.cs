using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{

    public int damage = 10;

    public Warrior() : base("Warrior", 100)
    {
 
    }

    public override void Attack()
    {
        Debug.Log($"Ho attaccato e ho fatto {damage} danni ");
    }

    public override void TakeDamage(int dmgsub)
    {
        Hp -= dmgsub;

        Debug.Log($"Ho subito {dmgsub} danni, ora la mia vita è {Hp}");

    }

}
