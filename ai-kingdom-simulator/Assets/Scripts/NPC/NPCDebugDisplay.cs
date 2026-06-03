// floating text above NPC showing Current GOal, Hunger, Energy, Money

using TMPro;
using UnityEngine;

public class NPCDebugDisplay : MonoBehaviour
{
    public NPCStats stats;
    public NPCController controller;

    private TextMeshPro textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        textMesh.text =
            $"Goal: {controller.currentGoal}\n" +
            $"Hunger: {stats.hunger:F0}\n" +
            $"Energy: {stats.energy:F0}\n" +
            $"Money: {stats.money}";
    }

    void LateUpdate()
    {
        if (Camera.main != null)
        {
            transform.forward = Camera.main.transform.forward;    // make text face camera
        }
    }
}