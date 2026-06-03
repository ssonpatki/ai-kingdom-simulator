// tracks everything happening
    // will be used later for memory and AI narration

using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public static WorldManager Instance;

    public List<string> worldEvents = new();

    private void Awake()
    {
        Instance = this;
    }

    public void AddEvent(string eventText)
    {
        worldEvents.Add(eventText);

        Debug.Log($"WORLD EVENT: {eventText}");
    }
}