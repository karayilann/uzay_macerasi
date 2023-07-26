using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaPlanHareketKontrol : MonoBehaviour
{
    float arkaPlanKonum;
    float mapScale = 10.24f;

    void Start()
    {
        arkaPlanKonum = transform.position.y;
    }

    void Update()
    {
        if(arkaPlanKonum + mapScale < Camera.main.transform.position.y) 
        {
            ArkaPlanEkle();
        }     
    }

    /// <summary>
    /// Karakter hareket ettik�e arkaplanda ayn� �ekilde yukar�ya eklenecek ve oyun sonsuz d�ng�ye girecek.
    /// </summary>
   void ArkaPlanEkle()
   {
        arkaPlanKonum += mapScale * 2;
        transform.position = new Vector2(0, arkaPlanKonum);
   }

}
