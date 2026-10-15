using UnityEngine;

public class Ejercicio_6 : MonoBehaviour
{
  [Header("Referencias")]
  [SerializeField] private Transform objetivoCilindro;
  [SerializeField] private GameObject obstaculoCubo;
  [SerializeField] private Material materialImpacto;

  [Header("Movimiento")]
  [SerializeField] private float velocidad = 3f;

  private Collider esfera;
  private Renderer esferaRenderer;
  private Collider cubo;
  private bool cuboAlcanzado = false;

  private void Start()
  {
    esfera = GetComponent<Collider>();
    esferaRenderer = GetComponent<Renderer>();
    if (obstaculoCubo != null)
    {
      cubo = obstaculoCubo.GetComponent<Collider>();
    }
  }

  private void Update()
  {
    if (objetivoCilindro != null)
    {
      transform.position = Vector3.MoveTowards(
        transform.position,
        objetivoCilindro.position,
        velocidad * Time.deltaTime
      );
    }

    if (!cuboAlcanzado && cubo != null && esfera != null)
    {
      if (esfera.bounds.Intersects(cubo.bounds))
      {
        cuboAlcanzado = true;
        CambiarMaterial();
      }
    }
  }

  private void CambiarMaterial()
  {
    if (esferaRenderer != null && materialImpacto != null)
    {
      esferaRenderer.material = materialImpacto;
      Debug.Log("¡La esfera alcanzó el cubo obstáculo! Material modificado.");
    }
  }
}
