using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : Token
{
    public static TokenMgr<Shot> parent = null;


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

    public static Shot Add(float x,float y,float direction,float speed)
    {
        return parent.Add(x, y, direction, speed);
    }
}
