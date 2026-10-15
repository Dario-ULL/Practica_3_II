using UnityEngine;

public class Ejercicio9_Sphere : MonoBehaviour
{
  [Header("Configuración de Velocidad")]
  [Tooltip("Velocidad de movimiento de la esfera")]
  public float speed = 5.0f;

  void Update()
  {
    float inputHorizontal = 0f;
    float inputVertical = 0f;

    if (Input.GetKey(KeyCode.A))
    {
        inputHorizontal = -1f;
    }
    else if (Input.GetKey(KeyCode.D))
    {
        inputHorizontal = 1f;
    }
    if (Input.GetKey(KeyCode.W))
    {
      inputVertical = 1f;
    }
    else if (Input.GetKey(KeyCode.S))
    {
      inputVertical = -1f;
    }
    float dx = inputHorizontal * speed;
    float dz = inputVertical * speed;

    transform.Translate(dx, 0f, dz, Space.World);
  }
}