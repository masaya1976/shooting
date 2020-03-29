using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Token
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //レイヤー名を取得する
        string name = LayerMask.LayerToName(collision.gameObject.layer);

        if(name == "Shot")
        {
            Shot s = collision.GetComponent<Shot>();
            s.Vanish();
        }
    }
}
