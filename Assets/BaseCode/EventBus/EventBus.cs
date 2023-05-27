using System.Collections.Generic;
using UnityEngine.Events;

namespace BaseCode.EventBus
{
    public class EventBus 
    {
        private static readonly Dictionary<ColorType, UnityEvent> Events = new();

        public static void Subscribe(ColorType colorType, UnityAction listener)
        {
            if(Events.TryGetValue(colorType, out var thisEvent))
                thisEvent.AddListener(listener);
            else
            {
                var myEvent = new UnityEvent(); 
                myEvent.AddListener(listener);
                Events.Add(colorType, myEvent);
            }
        }

        public static void Unsubscribe(ColorType colorType, UnityAction listener)
        {
            if(Events.TryGetValue(colorType, out var thisEvent))
                thisEvent.RemoveListener(listener);
        }

        public static void Publisher(ColorType colorType)
        {
            if(Events.TryGetValue(colorType, out var thisEvent))
                thisEvent?.Invoke();
        }
    }
}