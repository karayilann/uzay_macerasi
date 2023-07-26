using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Full_Screen : MonoBehaviour
{


    void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        Vector2 tempScale = transform.localScale;    // Arkaplan resminin boyutunu ald�k.
        float spriteGenislik = renderer.size.x;
        
        // �arpma simgesinin solu sadece orjinden alt ve �st aras�ndaki mesafeyi verir. Y�ksekli�i bulmak i�in 2 ile �arpt�k.
        float ekranYukseklik = Camera.main.orthographicSize * 2.0f;
        float ekranGenislik = ekranYukseklik / Screen.height * Screen.width;
        tempScale.x = ekranGenislik / spriteGenislik;
        transform.localScale = tempScale;
    }

    void Update()
    {
        
    }
}
