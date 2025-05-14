using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palla_Magica : Proiettile
{ 
    public Palla_Magica() { spd = 2f; }

    public override void Lancia()
    {
      Debug.Log ($" hai lanciato una palla di fuoco a velocità {spd}");
    }
}
