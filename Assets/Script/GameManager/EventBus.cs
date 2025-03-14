using System;
using System.Collections.Generic;

// �̺�Ʈ ���� Ŭ����
public class EventBus
{
    private readonly Dictionary<string, List<Action<object>>> _events;

    public EventBus()
    {
        _events = new Dictionary<string, List<Action<object>>>();
    }

    // �̺�Ʈ ����
    public void On(string eventName, Action<object> handler)
    {
        if (!_events.ContainsKey(eventName))
        {
            _events[eventName] = new List<Action<object>>();
        }
        _events[eventName].Add(handler);
    }

    // �̺�Ʈ ����
    public void Trigger(string eventName, object data)
    {
        if (_events.ContainsKey(eventName))
        {
            foreach (var handler in _events[eventName])
            {
                handler(data);
            }
        }
    }

    // ���� ����
    public void Off(string eventName, Action<object> handler)
    {
        if (_events.ContainsKey(eventName))
        {
            _events[eventName].Remove(handler);
        }
    }
}