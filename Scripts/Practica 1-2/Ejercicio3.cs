using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    [Header("Posición de la Esfera")]
    public Vector3 posicionActual;

    void Start()
    {
        // Obtención de la posición mediante el componente Transform
        Transform miTransform = GetComponent<Transform>();
        posicionActual = miTransform.position;

        // Mostrar vector en pantalla / consola
        Debug.Log($"La posición actual de la esfera es: {posicionActual}");
    }
}