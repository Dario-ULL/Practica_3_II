using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
  [Header("Configuración de Movimiento")]
  [Tooltip("Dirección del movimiento (X, Y, Z)")]
  public Vector3 moveDirection = new Vector3(1f, 0f, 0f);

  [Tooltip("Velocidad del movimiento (inicialmente > 1)")]
  public float speed = 2.0f;

  [Header("Sistema de Referencia")]
  [Tooltip("Marcar para usar coordenadas locales; desmarcar para coordenadas globales (World)")]
  public bool usarEspacioLocal = true;

  void Start()
  {
    Vector3 posInicial = transform.position;
    posInicial.y = 0f;
    transform.position = posInicial;
  }

  void Update()
  {
    float dx = moveDirection.x * speed * Time.deltaTime;
    float dy = moveDirection.y * speed * Time.deltaTime;
    float dz = moveDirection.z * speed * Time.deltaTime;

    if (usarEspacioLocal)
    {
      transform.Translate(dx, dy, dz, Space.Self);
    }
    else
    {
      transform.Translate(dx, dy, dz, Space.World);
    }
  }
}