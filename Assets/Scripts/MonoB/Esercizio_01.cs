using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Proiettile> ammo = new List<Proiettile>();

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0) { ammo.Add(new Freccia()); }

            else { ammo.Add(new Palla_Magica()); }

        }

        foreach (var spd in ammo)
        {
            spd.Lancia();
        }

    }
}
