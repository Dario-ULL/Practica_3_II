using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
  [Header("Velocidades")]
  [Tooltip("Velocidad de traslación hacia adelante/atrás")]
  public float velocidadAvance = 5.0f;

  [Tooltip("Velocidad de rotación en grados por segundo")]
  public float velocidadGiro = 120.0f;

  [Header("Depuración")]
  [Tooltip("Longitud del rayo guía en la vista Scene")]
  public float longitudRayo = 2.5f;

  void Update()
  {
      float inputGiro = Input.GetAxis("Horizontal");
      float rotacionY = inputGiro * velocidadGiro * Time.deltaTime;
      transform.Rotate(0f, rotacionY, 0f, Space.Self);
      Vector3 direccionFrente = transform.forward;
      Vector3 desplazamiento = direccionFrente * velocidadAvance * Time.deltaTime;
      transform.Translate(desplazamiento, Space.World);
      Debug.DrawRay(transform.position, direccionFrente * longitudRayo, Color.green);
  }
}