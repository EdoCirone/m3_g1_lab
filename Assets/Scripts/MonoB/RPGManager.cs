using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Character> PartyMember = new List<Character>();

        PartyMember.Add(new Archer());
        PartyMember.Add(new Warrior());
        PartyMember.Add(new Mage());

        foreach (Character character in PartyMember)
        {
            Debug.Log($"Sono {character.Name} e ho {character.Hp} di vita ");
            character.Attack();
            character.TakeDamage(UnityEngine.Random.Range(1, 20));

        }



    }

}
