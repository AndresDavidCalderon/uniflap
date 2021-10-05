using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    public float scrollspeed;
    private Transform trans;
    private Vector2 transpos;
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transpos = trans.position;
        transpos.x-=scrollspeed* Time.deltaTime;
        if (trans.position.x+(GetComponent<SpriteRenderer>().sprite.texture.width/2)<=Screen.width)
        {
            print("reseting floor");
            transpos.x = GetComponent<SpriteRenderer>().sprite.texture.width / 2;
        }
    }
}
