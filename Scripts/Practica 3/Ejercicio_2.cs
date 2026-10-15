using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class Ejercicio_2 : MonoBehaviour
{  
  public Vector3 vectorColor;
  private Renderer myRenderer;
  private Renderer rend;

  private void Awake()
  {
    myRenderer = GetComponent<Renderer>();    
  }

  private void OnCollisionEnter(Collision collision)
  {
    Renderer otherRenderer = collision.gameObject.GetComponent<Renderer>();
    if (collision.gameObject.CompareTag("Plano"))
    {
      return;
    }    
    Debug.Log($"{gameObject.name} colisionó con: {collision.gameObject.name}");
    if (otherRenderer != null)
    {
      Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
      otherRenderer.material.color = colorAleatorio;
    }
    if (otherRenderer != null)
    {
      int componenteAleatorio = Random.Range(0, 3);
      float nuevoValor = Random.Range(0f, 1f);
      switch (componenteAleatorio)
      {
        case 0:
          vectorColor.x = nuevoValor;
          break;
        case 1:
          vectorColor.y = nuevoValor;
          break;
        case 2:
          vectorColor.z = nuevoValor;
          break;
      }
      ActualizarColorObjeto();
    }
  }
  void ActualizarColorObjeto()
  {
    if (rend != null)
    {
      rend.material.color = new Color(vectorColor.x, vectorColor.y, vectorColor.z);
    }
  }
}

