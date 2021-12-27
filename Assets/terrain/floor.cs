using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    public float scrollspeed;
    private Transform trans;
    private float initpos;
    void Start()
    {
        trans = GetComponent<Transform>();
        initpos = trans.position.x;
    }
    void Update()
    {
        var transpos = trans.position;
        transpos.x-=scrollspeed* Time.deltaTime;
        var screenwidth= Camera.main.ViewportToWorldPoint(new Vector2(1,1)).x;
        if (trans.position.x+(GetComponent<SpriteRenderer>().sprite.bounds.size.x/2)<=screenwidth)
        {
            System.Console.WriteLine("reseting floor");
            transpos.x = initpos;
        }
        trans.position = transpos;
    }
}
