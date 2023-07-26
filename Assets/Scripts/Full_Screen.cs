using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Full_Screen : MonoBehaviour
{


    void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        Vector2 tempScale = transform.localScale;    // Arkaplan resminin boyutunu aldýk.
        float spriteGenislik = renderer.size.x;
        
        // çarpma simgesinin solu sadece orjinden alt ve üst arasýndaki mesafeyi verir. Yüksekliði bulmak için 2 ile çarptýk.
        float ekranYukseklik = Camera.main.orthographicSize * 2.0f;
        float ekranGenislik = ekranYukseklik / Screen.height * Screen.width;
        tempScale.x = ekranGenislik / spriteGenislik;
        transform.localScale = tempScale;
    }

    void Update()
    {
        
    }
}
