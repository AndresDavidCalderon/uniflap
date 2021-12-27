using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawner : MonoBehaviour
{
    public float between;
    float untilspawn;
    private void Start()
    {
        untilspawn = between;
    }
    void Update()
    {
        untilspawn -= Time.deltaTime;
        if (untilspawn < 0)
        {
            Random.Range(0, 1);
        }
    }
}
