using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    root root;
    private void Start()
    {
        root = (root)transform.parent.parent.gameObject.GetComponent<MonoBehaviour>() ;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        root.Lose();
    }
}
