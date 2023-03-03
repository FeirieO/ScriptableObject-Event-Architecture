using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Game/Weapon")]
public class WeaponStorage : ScriptableObject
{
    [SerializeField] List<WeaponData> weaponList;
    public List<WeaponData> WeaponList => weaponList;
}
