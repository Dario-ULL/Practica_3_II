using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
  [Header("Configuración")]
  [Tooltip("Velocidad ajustable desde el Inspector")]
  public float velocidad = 5.0f;

  void Update()
  {
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    if (Input.GetKey(KeyCode.UpArrow))
    {
      float resultado = velocidad * vertical;
      Debug.Log($"Flecha Arriba: {resultado}");
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
      float resultado = velocidad * vertical;
      Debug.Log($"Flecha Abajo: {resultado}");
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      float resultado = velocidad * horizontal;
      Debug.Log($"Flecha Izquierda: {resultado}");
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
      float resultado = velocidad * horizontal;
      Debug.Log($"Flecha Derecha: {resultado}");
    }
  }
}
