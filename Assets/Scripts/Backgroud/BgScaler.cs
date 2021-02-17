using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScaler : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 tempscale = transform.localScale;

        float width = sr.sprite.bounds.size.x;
        float worldheight = Camera.main.orthographicSize * 2F;
        float worldwidth = worldheight / Screen.height  * Screen.width ;

        tempscale.x = worldwidth / width;

        transform.localScale = tempscale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
