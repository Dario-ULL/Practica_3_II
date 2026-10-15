using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    [Header("Configuración de Tiempo")]
    [Tooltip("Cantidad de frames a esperar antes de cambiar de color")]
    public int framesEspera = 30;

    [Header("Vector de Color (R, G, B)")]
    public Vector3 vectorColor;

    private Renderer rend;
    private int contadorFrames = 0;

    void Start()
    {
        rend = GetComponent<Renderer>();
        vectorColor = new Vector3(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );
        ActualizarColorObjeto();
    }

    void Update()
    {
        contadorFrames++;
        if (contadorFrames >= framesEspera)
        {
            int componenteAleatorio = Random.Range(0, 3);
            float nuevoValor = Random.Range(0f, 1f);
            switch (componenteAleatorio)
            {
                case 0:
                    vectorColor.x = nuevoValor;
                    break;
                case 1:
                    vectorColor.y = nuevoValor;
                    break;
                case 2:
                    vectorColor.z = nuevoValor;
                    break;
            }
            ActualizarColorObjeto();
            contadorFrames = 0;
        }
    }

    void ActualizarColorObjeto()
    {
        if (rend != null)
        {
            rend.material.color = new Color(vectorColor.x, vectorColor.y, vectorColor.z);
        }
    }
}