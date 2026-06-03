// initial version of decision-making system

using UnityEngine;

public class NPCController : MonoBehaviour
{
    public Transform house;
    public Transform market;
    public Transform workplace;

    public float moveSpeed = 2f;
    private NPCStats stats;
    private NPCAction actions;

    public GoalType currentGoal;

    private float decisionTimer = 0f;

    private void Start()
    {
        stats = GetComponent<NPCStats>();
        actions = GetComponent<NPCAction>();
    }

    private void Update()
    {
        decisionTimer += Time.deltaTime;

        if (decisionTimer >= 3f)
        {
            DecideGoal();
            ExecuteGoal();

            decisionTimer = 0f;
        }
    }

    private void DecideGoal()
    {
        if (stats.hunger > 70)
        {
            currentGoal = GoalType.Eat;
        }
        else if (stats.energy < 30)
        {
            currentGoal = GoalType.Sleep;
        }
        else
        {
            currentGoal = GoalType.Work;
        }
    }

    private void ExecuteGoal()
    {
        switch (currentGoal)
        {
            case GoalType.Eat:
                actions.Eat();
                break;

            case GoalType.Work:
                actions.Work();
                break;

            case GoalType.Sleep:
                actions.Sleep();
                break;
        }
    }
}