using System;
using System.Collections.Generic;

// 이벤트 버스 클래스
public class EventBus
{
    private readonly Dictionary<string, List<Action<object>>> _events;

    public EventBus()
    {
        _events = new Dictionary<string, List<Action<object>>>();
    }

    // 이벤트 구독
    public void On(string eventName, Action<object> handler)
    {
        if (!_events.ContainsKey(eventName))
        {
            _events[eventName] = new List<Action<object>>();
        }
        _events[eventName].Add(handler);
    }

    // 이벤트 발행
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

    // 구독 해제
    public void Off(string eventName, Action<object> handler)
    {
        if (_events.ContainsKey(eventName))
        {
            _events[eventName].Remove(handler);
        }
    }
}