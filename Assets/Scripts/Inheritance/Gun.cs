using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    public Gun()
    {                               //if private, would not have seen the calls
        WeaponName = "TommyGun";
        WeaponStrength = 700;
    }
}
