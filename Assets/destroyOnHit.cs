using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name != "Player")
        Debug.Log("collision detected!");
        Debug.Log(col.gameObject.name);
        if (col.gameObject.tag == "Cube")
        {
            Destroy(col.gameObject);
            
        }
        Destroy(gameObject);
        
    }
}
