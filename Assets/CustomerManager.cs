using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : Singleton<CustomerManager>
{
    List<Customer> customers = new List<Customer>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public List<Customer> getAllCustomers()
    {
        return customers;
    }

    public void addCustomer(Customer cus)
    {
        customers.Add(cus);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
