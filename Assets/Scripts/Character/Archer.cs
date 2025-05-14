using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEditor;
using UnityEngine;

public class Archer : Character
{

    public int damage = 7;
    public int numerofreccie = 2;

    public Archer() : base("Archer", 30)
    {

    }


    public override void Attack()
    {
        for (int i = 0; i < numerofreccie; i++)
        {

            Debug.Log($" ho lanciato la freccia numero {i} e ho fatto {damage} danni");

        }
    }

    public override void TakeDamage( int dmgsub)
    {
        Hp -= dmgsub;

        Debug.Log($"Ho subito {dmgsub} danni, ora la mia vita è {Hp}");

    }


}

