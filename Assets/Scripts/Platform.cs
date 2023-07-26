using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    PolygonCollider2D polygonCollider;
    float randomHiz;
    bool hareket = true;


    public bool Hareket
    {
        get
        {
            return hareket;
        }
        set
        {
            hareket = value;
        }
    }

    void Start()
    {
        polygonCollider = GetComponent<PolygonCollider2D>();
        randomHiz = Random.Range(0.5f, 1.0f);
    }

    
    void Update()
    {
        if (hareket)
        {
            float pingPongX = Mathf.PingPong(Time.time * randomHiz, 2.25f);
            Vector2 pingPong = new Vector2(pingPongX, transform.position.y);
            transform.position = pingPong;
        }
    }
}
