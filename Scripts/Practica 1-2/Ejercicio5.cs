using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
  [Header("Desplazamiento relativo (Delta X, Delta Y, Delta Z)")]
  public Vector3 desplazamiento = new Vector3(0f, 0f, 0f);

  private Vector3 posicionOriginal;
  private bool desplazado = false;
  private bool teclaPresionadaEnFrameAnterior = false;

  void Start()
  {
    posicionOriginal = transform.position;
  }

  void Update()
  {
    float valorSalto = Input.GetAxis("Jump");
    if (valorSalto > 0f && !teclaPresionadaEnFrameAnterior)
    {
      if (!desplazado)
      {
        transform.position = posicionOriginal + desplazamiento;
        desplazado = true;
      }
      else
      {
        transform.position = posicionOriginal;
        desplazado = false;
      }
    }
    teclaPresionadaEnFrameAnterior = valorSalto > 0f;
  }
}