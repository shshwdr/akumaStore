using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower:MonoBehaviour
{
    public string type;
    protected TowerInfo towerInfo;

    float currentCoolDown = 0;

    private void Start()
    {
        towerInfo = TowerManager.Instance.towerDict[type];
    }

    private void Update()
    {
        currentCoolDown += Time.deltaTime;
        if (currentCoolDown >= towerInfo.attackTime)
        {
            currentCoolDown = 0;
            attack();
        }
    }

    protected virtual void attack()
    {

    }
}