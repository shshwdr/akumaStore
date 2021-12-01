using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : HPCharacterController
{

    NPCPathFinding pathFinding;
    public Transform target;
    protected override void Awake()
    {
        base.Awake();
        pathFinding = GetComponent<NPCPathFinding>();
    }
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        CustomerManager.Instance.addCustomer(this);

        pathFinding.setTarget(target);
    }

    protected override void Die()
    {
        base.Die();
        Debug.Log("no money");
    }

}
