using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
[Header("Vectores de entrada")]

    public Vector3 vectorA = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 vectorB = new Vector3(2.0f, 4.0f, 1.0f);

    [Header("Resultados en Inspector")]
    public float magnitudVectorA;
    public float magnitudVectorB;
    public float angulo;
    public float distancia;
    public string vectorMasAlto;

    void Start()
    {
        // 1. Magnitud
        magnitudVectorA = vectorA.magnitude;
        magnitudVectorB = vectorB.magnitude;

        // 2. Ángulo que forman
        angulo = Vector3.Angle(vectorA, vectorB);

        // 3. Distancia entre ambos
        distancia = Vector3.Distance(vectorA, vectorB);

        // 4. Comparación de altura (eje Y)
        if (vectorA.y > vectorB.y)
        {
            vectorMasAlto = "El Vector A está a una altura mayor.";
        }
        else if (vectorB.y > vectorA.y)
        {
            vectorMasAlto = "El Vector B está a una altura mayor.";
        }
        else
        {
            vectorMasAlto = "Ambos vectores están a la misma altura.";
        }

        // Salida por consola
        Debug.Log($"Magnitud Vector A: {magnitudVectorA}");
        Debug.Log($"Magnitud Vector B: {magnitudVectorB}");
        Debug.Log($"Ángulo entre vectores: {angulo}°");
        Debug.Log($"Distancia entre vectores: {distancia}");
        Debug.Log(vectorMasAlto);
    }
}