using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour, IWeapon
{
    [SerializeField] private WeaponManager weaponManager;
    public Action<int> onDealDamage;

    public void DealDamage()
    {
        onDealDamage?.Invoke(weaponManager.GetActiveWeaponData().damageamount);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DealDamage();
        }
    }
}
