using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class obstacle : MonoBehaviour
{
    Transform trans;
    floor floor;
    void Start()
    {
        floor = GameObject.Find("floor").GetComponent<floor>();
        trans = (Transform) GetComponent("Transform");
    }
    void Update()
    {
        trans.position = new Vector3(trans.position.x - (floor.scrollspeed*Time.deltaTime), trans.position.y);
        if (trans.position.x < Camera.main.ViewportToWorldPoint(new Vector3(0,0)).x)
        {
            Destroy(this.gameObject);
        }
    }
}
