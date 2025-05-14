using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Freccia : Proiettile
{
    public Freccia() { spd = 7; }

    public override void Lancia()
    {
        Debug.Log($" ho lanciato una Freccia con velocità {spd}");
    }

    
}
