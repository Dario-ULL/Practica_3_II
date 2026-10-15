using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    [Tooltip("Velocidad de avance continuo")]
    public float velocidadAvance = 3.0f;

    [Tooltip("Velocidad de rotación")]
    public float velocidadGiro = 90.0f; // grados por segundo

    void Update()
    {
        // 1. Lectura del eje Horizontal (-1 a 1)
        float inputGiro = Input.GetAxis("Horizontal");

        // 2. Rotar el objeto sobre el eje Y (espacio local/propio)
        float gradosGiro = inputGiro * velocidadGiro * Time.deltaTime;
        transform.Rotate(0f, gradosGiro, 0f, Space.Self);

        // 3. Dirección hacia adelante en coordenadas mundiales
        // transform.forward apunta siempre al frente del objeto según su rotación actual
        // (a diferencia de Vector3.forward, que es el vector fijo (0, 0, 1) del mundo)
        Vector3 direccionAdelante = transform.forward;

        // 4. Trasladar al objeto de manera continua hacia su frente
        transform.Translate(direccionAdelante * velocidadAvance * Time.deltaTime, Space.World);

        // 5. Dibujar un rayo visible en la vista Scene para depurar la orientación
        Debug.DrawRay(transform.position, direccionAdelante * 2.0f, Color.red);
    }
}