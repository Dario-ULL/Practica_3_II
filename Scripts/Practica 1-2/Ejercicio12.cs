using System.Collections;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
  [Header("Objetivo")]
  [Tooltip("Referencia al Transform de la esfera")]
  public Transform objetivoEsfera;
  [Header("Configuración de Movimiento")]
  [Tooltip("Velocidad constante de avance")]
  public float speed = 3.0f;
  [Tooltip("Tiempo de espera antes de girar hacia la esfera")]
  public float tiempoDeEspera = 1.0f;
  [Tooltip("Velocidad de giro para ver la rotación de forma suave")]
  public float velocidadGiro = 5.0f;
  private bool puedeGirar = false;

  void Start()
  {
    if (objetivoEsfera == null)
    {
      GameObject esferaGO = GameObject.Find("Sphere");
      if (esferaGO != null)
      {
        objetivoEsfera = esferaGO.transform;
      }
    }
    StartCoroutine(RutinaEspera());
  }

  IEnumerator RutinaEspera()
  {
    yield return new WaitForSeconds(tiempoDeEspera);
    puedeGirar = true;
  }

  void Update()
  {
    if (!puedeGirar || objetivoEsfera == null) return;
    Vector3 puntoDeMira = new Vector3(
      objetivoEsfera.position.x,
      transform.position.y,
      objetivoEsfera.position.z
    );
    Vector3 direccion = puntoDeMira - transform.position;
    if (direccion.magnitude > 0.05f)
    {
      Quaternion rotacionDeseada = Quaternion.LookRotation(direccion);
      transform.rotation = Quaternion.Slerp(transform.rotation, rotacionDeseada, velocidadGiro * Time.deltaTime);
      transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
  }
}