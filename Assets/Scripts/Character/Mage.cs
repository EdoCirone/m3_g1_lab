using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{

    int damage = 12;

    public Mage() : base("Mage", 60)
    {

    }

    public override void Attack()
    {
        Debug.Log($"Ho lanciato uno spell e ho fatto {damage} danni");
    }

    public override void TakeDamage(int dmgsub)
    {
        Hp -= dmgsub;
        Debug.Log($"Ho subito {dmgsub} danni, ora la mia vita è {Hp}");
    }

}
