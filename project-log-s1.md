# Development Order
1. NPC needs
2. NPC movement
3. World locations
4. Goal system
5. Memory system
6. Relationships
7. Event detection
8. AI narrator
9. AI dialogue

# Stage One: Functioning Autonomous Village

* build the simulation first and ignore the LLM entirely
* if NPCs can't function autonomously without AI-generated text, the project will become much harder to debug.

**Start with Four Major Systems**
* NPC needs (hunger, energy, wealth)
* Actions (eat, work, sleep)
* Goal selection
* World update loop

# Stage One Repo Structure

Assets/
    Scripts/
        NPC/
            GoalType.cs/
            NPCAction.cs/
            NPCController.cs/
            NPCStats.cs/
        UI/
        World/
            WorldManager.cs/

# Stage One Unity Structure
**unity**
* Main Camera
* Directional Light
* WorldManager
    * initialized using "Create Empty"
* NPC_1
    * initialized using Cube game object
    * added components (scripts): NPCStats, NPCController, NPCAction 
    * enter play mode, open inspector, view NPC Stats and NPC Controller to see how **Needs**, **Resources**, and **Current Goal** changes
* NPC_2
    * see info under NPC_1 (all NPCs duplicated from NPC_1)
* NPC_3
    * see info under NPC_1
* NPC_4
    * see info under NPC_1
* NPC_5
    * see info under NPC_1
* NPC_6
    * see info under NPC_1
* NPC_7
    * see info under NPC_1
* NPC_8
    * see info under NPC_1
* NPC_9
    * see info under NPC_1
* NPC_10
    * see info under NPC_1

*note: once in play mode, message such as "NPC_1 worked. NPC_3 bought food. etc." should be displayed in Console*