using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{

    birdfflap player;
    private void Start()
    {
        player = GameObject.Find("bird").gameObject.GetComponent<birdfflap>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        player.Lose();
    }
}
