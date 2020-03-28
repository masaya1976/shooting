using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : Token
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOutside())
        {
            // gamenngai ni detanode kesu
            DestroyObj();
        }    
    }
}
