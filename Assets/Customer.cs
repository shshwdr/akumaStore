using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : HPCharacterController
{

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        CustomerManager.Instance.addCustomer(this);
    }

    protected override void Die()
    {
        base.Die();
        Debug.Log("no money");
    }

}
