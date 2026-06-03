// stores agent's internal state
using UnityEngine;

public class NPCStats : MonoBehaviour
{
    [Header("Needs")]
    public float hunger = 50f;
    public float energy = 100f;

    [Header("Resources")]
    public int money = 10;

    void Update()
    {
        hunger += Time.deltaTime * 2f;
        energy -= Time.deltaTime * 1f;

        hunger = Mathf.Clamp(hunger, 0, 100);
        energy = Mathf.Clamp(energy, 0, 100);
    }
}