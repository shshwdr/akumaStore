using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableTowerCell : SelectableCell
{

    public void buildTower()
    {
        var prefab = Resources.Load<GameObject>("tower/appleTower");
        var go = Instantiate(prefab, MouseManager.Instance.previousSelected.transform.position, Quaternion.identity);

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
