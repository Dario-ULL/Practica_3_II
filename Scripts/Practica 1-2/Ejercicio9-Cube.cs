using UnityEngine;

public class Ejercicio9_Cube : MonoBehaviour
{
  [Header("Configuración de Velocidad")]
  [Tooltip("Velocidad de movimiento del cubo")]
  public float speed = 5.0f;

  void Update()
  {
    float inputHorizontal = 0f;
    float inputVertical = 0f;
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      inputHorizontal = -1f;
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      inputHorizontal = 1f;
    }

    if (Input.GetKey(KeyCode.DownArrow))
    {
      inputVertical = -1f;
    }
    else if (Input.GetKey(KeyCode.UpArrow))
    {
      inputVertical = 1f;
    }
    float dx = inputHorizontal * speed;
    float dz = inputVertical * speed;
    transform.Translate(dx, 0f, dz, Space.World);
  }
}