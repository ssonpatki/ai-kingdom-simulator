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

# Stage Two Unity Structure

For each NPC:
* NPC_1
    * [new empty child game object] DebugText
        * in DebugText, add Component (TextMeshPro - Text)