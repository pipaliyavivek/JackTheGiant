using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("destroyCollectable", 6f);
    }
    private void OnDisable()
    {
        
    }
    void destroyCollectable()
    {
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}
