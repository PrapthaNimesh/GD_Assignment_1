using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("bullet"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
