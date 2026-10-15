using UnityEngine;

public class Ejercicio_3 : MonoBehaviour
{
  [Header("Sistema de Daño")]
  [SerializeField] private int dañoAcumulado = 0;

  [Header("Color")]
  [SerializeField] private Color colorEnZona = Color.magenta;
  private Color colorOriginal;
  private Renderer playerRenderer;

  private void Awake()
  {
    playerRenderer = GetComponent<Renderer>();
    if (playerRenderer != null)
    {
      colorOriginal = playerRenderer.material.color;
    }
  }
  private void OnTriggerEnter(Collider other)
  {
    Debug.Log("¡Entraste a la Zona de Color!");
    if (playerRenderer != null)
    {
      playerRenderer.material.color = colorEnZona;
    }
    if (other.CompareTag("Daño"))
    {
      dañoAcumulado += 10;
      Debug.Log($"¡Daño recibido! Daño total acumulado: {dañoAcumulado}");
    }
  }
  private void OnTriggerExit(Collider other)
  {
    Debug.Log("Salió de un trigger: " + other.gameObject.name);
    Debug.Log("Restaurando color original.");
    if (playerRenderer != null)
    {
      playerRenderer.material.color = colorOriginal;
    }
  }
}