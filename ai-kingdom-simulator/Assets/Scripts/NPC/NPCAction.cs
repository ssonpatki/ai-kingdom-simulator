// actions avaliable to the agent
using UnityEngine;

public class NPCAction : MonoBehaviour
{
    private NPCStats stats;

    private void Start()
    {
        stats = GetComponent<NPCStats>();
    }

    public void Eat()
    {
        if (stats.money >= 5)
        {
            stats.money -= 5;
            stats.hunger -= 50;

            Debug.Log($"{name} bought food.");
        }
    }

    public void Work()
    {
        stats.money += 10;
        stats.energy -= 10;

        WorldManager.Instance.AddEvent(
            $"{name} earned money by working."
        );
    }

    public void Sleep()
    {
        stats.energy += 40;

        Debug.Log($"{name} slept.");
    }
}