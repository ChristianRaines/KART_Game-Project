using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallscontroll : MonoBehaviour
{
    public GameObject m_fall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "KartCollider")
        {
            m_fall.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
