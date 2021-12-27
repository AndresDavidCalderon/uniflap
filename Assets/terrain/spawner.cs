using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawner : MonoBehaviour
{
    Transform pos;
    public float between;
    float untilspawn;
    private void Start()
    {
        pos = (Transform) GetComponent("Transform");
        untilspawn = between;
        
    }
    void Update()
    {
        untilspawn -= Time.deltaTime;
        if (untilspawn < 0)
        {
            untilspawn = between;
            var y=UnityEngine.Random.Range(0f, 1f);
            var obstacle = (GameObject) Instantiate(Resources.Load("obstacle"));
            var corner = Camera.main.ViewportToWorldPoint(new Vector2(1, y));
            (obstacle.GetComponent("Transform") as Transform).position = new Vector3(corner.x,corner.y);
        }
    }
}
