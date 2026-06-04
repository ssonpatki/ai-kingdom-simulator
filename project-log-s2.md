# Stage Two

**Before adding any AI model**

Add functionality for: 
* NPCs move between locations
* Food market
* Workplace
* House
* Need system
* Event logging

For example:

House ---- Market ---- Workplace

An NPC should physically walk:

Hungry
→ Go to Market
→ Buy Food

Low Money
→ Go to Workplace
→ Earn Money

Low Energy
→ Go Home
→ Sleep

# Stage Two Code Structure
Assets/
    Scripts/
        NPC/
            GoalType.cs/
            NPCAction.cs/
            NPCController.cs/
            NPCStats.cs/
            NPCDebugDisplay.cs/
        UI/
        World/
            LocationMarkers.cs/
            WorldManager.cs/

## Major File Updates

**NPCController.cs**


**NPCDebugDisplay.cs**


# Stage Two Unity Structure

For each NPC:
* NPC_1
    * [new empty child game object] DebugText
        * in DebugText, add Component (TextMeshPro - Text); use the fields in this component to change the text font/color/characteristics/etc.
        * in DebugText, add another Component w/ script NPCDebugDisplay.cs (drag NPC_1 game object into the stats and action fields in the compoent)