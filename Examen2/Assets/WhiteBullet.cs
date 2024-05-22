using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBullet : Bullet
{
    void Start()
    {
        bulletType = "White";
        Destroy(gameObject, lifeTime);
    }
}
