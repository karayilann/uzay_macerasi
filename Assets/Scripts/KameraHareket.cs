using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    float hiz;
    [SerializeField] float hizlanma;
    [SerializeField] float maximumHiz;

    bool hareket;

    void Start()
    {
        hiz = 0.5f;
        hizlanma = 0.05f;
        maximumHiz = 2.0f;
    }


    void Update()
    {
        if (hareket)
        {
            CameraMovement();
        }
    }

    void CameraMovement()
    {
        transform.position += transform.up * hiz * Time.deltaTime;
        hiz += hizlanma * Time.deltaTime;

        if(hiz == maximumHiz)   // Oyundaki maximum hýzý belirledik. Oyunun zorluðuna etki eden bir unsur
        {
            hizlanma = 0;
        }
    }


}
