using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class spawner : MonoBehaviour
{
    Transform pos;
    public float between;
    public float max_height;
    public float min_height;
    GameObject score_label;
    float untilspawn;
    private void Start()
    {
        score_label = GameObject.Find("Main Camera/Canvas/score");
        pos = (Transform) GetComponent("Transform");
        untilspawn = between;
        
    }
    void Update()
    {
        untilspawn -= Time.deltaTime;
        if (untilspawn < 0)
        {
            untilspawn = between;
            var y=UnityEngine.Random.Range(min_height, max_height);
            var corner = Camera.main.ViewportToWorldPoint(new Vector2(1, y));
            var obstacle = (GameObject) Instantiate(Resources.Load("obstacle"), new Vector3(corner.x, corner.y),new Quaternion(0,0,0,0),GameObject.Find("obstacles").GetComponent<Transform>());
            score_label.GetComponent<Text>().text = System.Convert.ToString(System.Convert.ToInt32(score_label.GetComponent<Text>().text) + 1);
        }
    }
}
