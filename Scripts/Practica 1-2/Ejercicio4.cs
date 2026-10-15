using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    [Header("Etiquetas de búsqueda")]
    public string tagCubo = "Cube";
    public string tagCilindro = "Cylinder";

    void Start()
    {
        Transform transformEsfera = GetComponent<Transform>();

        // Buscar el objeto Cubo
        GameObject cubo = GameObject.FindWithTag(tagCubo);
        if (cubo != null)
        {
            Transform transformCubo = cubo.GetComponent<Transform>();
            float distCubo = Vector3.Distance(transformEsfera.position, transformCubo.position);
            Debug.Log($"Distancia al Cubo: {distCubo:F2} unidades.");
        }
        else
        {
            Debug.LogWarning($"No se encontró ningún objeto con el tag '{tagCubo}'.");
        }

        // Buscar el objeto Cilindro
        GameObject cilindro = GameObject.FindWithTag(tagCilindro);
        if (cilindro != null)
        {
            Transform transformCilindro = cilindro.GetComponent<Transform>();
            float distCilindro = Vector3.Distance(transformEsfera.position, transformCilindro.position);
            Debug.Log($"Distancia al Cilindro: {distCilindro:F2} unidades.");
        }
        else
        {
            Debug.LogWarning($"No se encontró ningún objeto con el tag '{tagCilindro}'.");
        }
    }
}