using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class root : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = transform.Find("bird").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Lose()
    {
        player.transform.position = new Vector2(player.transform.position.x,Camera.main.ViewportToWorldPoint(new Vector2(0, 0.5f)).y);
    }
}
