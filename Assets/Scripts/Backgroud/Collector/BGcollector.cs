using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGcollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Background")
        {
            target.gameObject.SetActive(false);
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
