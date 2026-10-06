using UnityEngine;

public class OtoparkSistemi : MonoBehaviour
{
    [SerializeField] private int time = 1; //Kodumuzu hem gizli tutmak hem de unity üzerinden değiştirebilmek için ekledik.//
    
    void Start()
    {
    
        if (time <= 0) //Sıfır ve negatif sayıların girilmesi durumunda uyarı verecek şekilde ekledik.//
            {
                Debug.LogError("Geçersiz değer!");
                return;
            }

        switch (time)
        {
            case 1: 
            Debug.Log("Otoparkta kaldığınız süre: 1 saat");
            Debug.Log("Ücretiniz 120 TL");
            break;

            case 2: 
            Debug.Log("Otoparkta kaldığınız süre: 2 saat");
            Debug.Log("Ücretiniz 200 TL");
            break;

            case 3:
            Debug.Log("Otoparkta kaldığınız süre: 3 saat");
            Debug.Log("Ücretiniz 300 TL");
            break;

            case 4:
            Debug.Log("Otoparkta kaldığınız süre: 4 saat");
            Debug.Log("Ücretiniz 400 TL");
            break;

            default: //Dörtten farklı yazılan tüm değerler için artık aynı ücrete tabi tutulacak.//
            Debug.Log("Otoparkta kaldığınız süre: " + time + " saat");
            Debug.Log("Ücretiniz 550 TL");
            break;
    }

    }

}
