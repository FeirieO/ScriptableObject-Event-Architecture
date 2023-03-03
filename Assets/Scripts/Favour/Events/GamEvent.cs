using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GamEvent : ScriptableObject
{
    private readonly List<GamEventListener> eventListeners =
            new List<GamEventListener>();

    public void Raise()
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--)
            eventListeners[i].OnEventRaised();
    }

    public void RegisterListener(GamEventListener listener)
    {
        if (!eventListeners.Contains(listener))
            eventListeners.Add(listener);
    }

    public void UnregisterListener(GamEventListener listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }
}
