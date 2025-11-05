using UnityEngine;
public class criaMonstro : MonoBehaviour
{
    [Header("Círculos de Spawn")]
    public Transform circulo1;
    public Transform circulo2;
    public Transform circulo3;
    [Header("Prefabs dos Monstros")]
    public GameObject esqueletoPrefab;
    public GameObject lagartoPrefab;
    public GameObject golemPrefab;
    [Header("Tempos de Spawn (segundos)")]
    public float tempoEsqueleto = 5f;
    public float tempoLagarto = 7f;
    public float tempoGolem = 10f;
    private void Start()
    {
        InvokeRepeating(nameof(SpawnEsqueleto), tempoEsqueleto,
        tempoEsqueleto);
        InvokeRepeating(nameof(SpawnLagarto), tempoLagarto,
        tempoLagarto);
        InvokeRepeating(nameof(SpawnGolem), tempoGolem,
        tempoGolem);
    }
    void SpawnEsqueleto()
    {
        if (esqueletoPrefab != null && circulo1 != null)
        {
            Instantiate(esqueletoPrefab, circulo1.position, Quaternion.identity);
        }
    }
    void SpawnLagarto()
    {
        if (lagartoPrefab != null && circulo2 != null)
        {
            Instantiate(lagartoPrefab, circulo2.position, Quaternion.identity);
        }
    }
    void SpawnGolem()
    {
        if (golemPrefab != null && circulo3 != null)
        {
            Instantiate(golemPrefab, circulo3.position, Quaternion.identity);
        }
    }
}