// stores agent's internal state
using UnityEngine;

public class NPCStats : MonoBehaviour
{
    [Header("Needs")]
    public float hunger = 50f;
    public float energy = 100f;

    [Header("Resources")]
    public int money = 10;

    public enum PersonalityType // will be used later to make npc archetypes
    {
        HardWorker,
        Wealthy,
        Lazy, 
        Balanced
    }

    public PersonalityType personality;

    private void Start()
    {
        //basic randomized start
        /*
        hunger = Random.Range(0f, 100f);
        energy = Random.Range(30f, 100f);
        money = Random.Range(0, 51);
        */

        //start by assigning npcs personalities
        personality = (PersonalityType)Random.Range(0, System.Enum.GetValues(typeof(PersonalityType)).Length);
        switch (personality)
        {
            case PersonalityType.HardWorker:
                hunger = 40;
                energy = 90;
                money = 10;
                break;

            case PersonalityType.Wealthy:
                hunger = 30;
                energy = 70;
                money = 100;
                break;

            case PersonalityType.Lazy:
                hunger = 20;
                energy = 30;
                money = 20;
                break;
            
            case PersonalityType.Balanced:
                hunger = 50;
                energy = 50;
                money = 50;
                break;
        }
    }

    void Update()
    {
        hunger += Time.deltaTime * 2f;
        energy -= Time.deltaTime * 1f;

        hunger = Mathf.Clamp(hunger, 0, 100);
        energy = Mathf.Clamp(energy, 0, 100);
    }
}