using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShootTower : Tower
{

    protected override void attack()
    {
        base.attack();

        foreach (var cus in CustomerManager.Instance.getAllCustomers())
        {
            if ((cus.transform.position - transform.position).magnitude <= towerInfo.range)
            {
                cus.getDamage(towerInfo.attackDamage);
                break;
            }
        }
    }

}
