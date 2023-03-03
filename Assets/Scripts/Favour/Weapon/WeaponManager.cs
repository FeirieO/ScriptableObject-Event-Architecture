using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] private WeaponStorage weaponData;

    public int activeWeaponDataIndex;

    public WeaponData GetActiveWeaponData()
    {
        return weaponData.WeaponList[activeWeaponDataIndex];
    }

}