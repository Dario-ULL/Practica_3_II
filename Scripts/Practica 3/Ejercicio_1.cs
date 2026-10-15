using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ejercicio_1 : MonoBehaviour
{
  [Header("Configuración de Movimiento")]
  [SerializeField] private float speed = 6f;

  private Rigidbody rb;
  private float horizontalInput;
  private float verticalInput;

  private void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  private void Update()
  {
    horizontalInput = Input.GetAxisRaw("Horizontal");
    verticalInput = Input.GetAxisRaw("Vertical");
  }

  private void FixedUpdate()
  {
    Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput).normalized;
    Vector3 targetVelocity = direction * speed;
    rb.linearVelocity = new Vector3(targetVelocity.x, rb.linearVelocity.y, targetVelocity.z);
  }
}
