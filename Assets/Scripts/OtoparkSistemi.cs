using UnityEngine;

public class OtoparkSistemi : MonoBehaviour
{
    int time = 2;
    
    void Start()
    {
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

        case 5:
        Debug.Log("Otoparkta kaldığınız süre: 5 saat");
        Debug.Log("Ücretiniz 550 TL");
        break;

        default:
        Debug.Log("Otoparkta kaldığınız süre:" + time + "saat");
        Debug.Log("Ücretiniz 550 TL");
        break;
    }

    }

}
