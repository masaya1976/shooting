using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Token
{
    public Sprite Spr0; 
    public Sprite Spr1;

    int _tAnim = 0;

    public float MoveSpeed = 5.0f;


    void FixedUpdate()
    {
        _tAnim++;
        if (_tAnim % 48 < 24)
        {
            SetSprite(Spr0); //
        }
        else
        {
            SetSprite(Spr1);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        var w = SpriteWidth / 2;
        var h = SpriteHeight / 2;
        SetSize(w, h);
    }

    // Update is called once per frame
    void Update()
    {
        // idou shori
        Vector2 v = Util.GetInputVector();
        float speed = MoveSpeed * Time.deltaTime;

        //idousite sotoni denaiyouni suru
        ClampScreenAndMove(v * speed);

    }
}
