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
    /// Karakter hareket ettikçe arkaplanda ayný þekilde yukarýya eklenecek ve oyun sonsuz döngüye girecek.
    /// </summary>
   void ArkaPlanEkle()
   {
        arkaPlanKonum += mapScale * 2;
        transform.position = new Vector2(0, arkaPlanKonum);
   }

}
