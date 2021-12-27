using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class obstacle : MonoBehaviour
{
    public float speed;
    Transform trans;
    void Start()
    {
        trans = (Transform) GetComponent("Transform");
    }
    void Update()
    {
        trans.position = new Vector3(trans.position.x - (speed*Time.deltaTime), trans.position.y);
        if (trans.position.x < Camera.main.ViewportToWorldPoint(new Vector3(0,0)).x)
        {
            Destroy(this.gameObject);
        }
    }
}
