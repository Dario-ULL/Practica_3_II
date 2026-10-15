using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ejercicio_5 : MonoBehaviour
{
  [Header("Ajustes del Impulso")]
  [SerializeField] private Vector3 direccionFuerza = new Vector3(0.5f, 0f, 1f);
  [SerializeField] private float magnitudFuerza = 10f;

  private Rigidbody rb;
  private bool aplicarImpulso = false;

  private void Awake()
  {
    rb = GetComponent<Rigidbody>();
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.X))
    {
      aplicarImpulso = true;
    }
  }

  private void FixedUpdate()
  {
    if (aplicarImpulso)
    {
      rb.AddForce(direccionFuerza.normalized * magnitudFuerza, ForceMode.Impulse);
      aplicarImpulso = false;
    }
  }
}