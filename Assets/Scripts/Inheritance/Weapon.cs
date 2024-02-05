using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon //does not work with monobehavior
{
    private string weaponName;  //private wont be seen outside this class, including children
    private int weaponStrength;  // protected will be seen by anything within the class including children

    protected string WeaponName { get => weaponName; set => weaponName = value; }
    protected int WeaponStrength { get => weaponStrength; set => weaponStrength = value; }

    protected virtual void TakeDamage(int damage) //virtual world just makes it easier to override in other children
    {
        weaponStrength -= damage;
    }
}
