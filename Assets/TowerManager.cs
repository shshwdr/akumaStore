using Sinbad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInfo
{
    public string name;
    public string displayName;
    public string description;
}

public class TowerInfo : BaseInfo
{
    public string placeType;
    public float attackTime;
    public float attackDamage;
    public float range;

}

public class TowerManager : Singleton<TowerManager>
{
    public Dictionary<string, TowerInfo> towerDict = new Dictionary<string, TowerInfo>();
    private void Awake()
    {
        var towers = CsvUtil.LoadObjects<TowerInfo>("Tower");
        foreach (var info in towers)
        {
            towerDict[info.name] = info;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
