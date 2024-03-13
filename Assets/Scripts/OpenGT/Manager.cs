using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenGT {
    public class Manager
    {
        [Serializable]
        public enum TimePeriod
        {
            tick, millisecond, second, minute
        }

        public int RandomByTime(float seed, TimePeriod period)
        {
            switch (period) {
                case TimePeriod.tick:
                    return (int)(DateTime.UtcNow.Ticks * seed);
                case TimePeriod.millisecond:
                    return (int)(DateTime.UtcNow.Millisecond * seed);
                case TimePeriod.second:
                    return (int)(DateTime.UtcNow.Second * seed);
                case TimePeriod.minute:
                    return (int)(DateTime.UtcNow.Minute * seed);
            }
            Debug.LogWarning("Method PublicRandomByTime, does not return any number, so it will return 0");
            return 0;
        }

        public int RandomByPlace(float seedX, float seedY, float seedZ, Transform place)
        {
            return (int)((seedX * place.transform.position.x) + (seedY * place.transform.position.y) + (seedZ * place.transform.position.z));
        }

        public class Generation
        {
            public object GetRoom(List<object> rooms, int seed, Transform position)
            {
                OpenGT.Manager manager = new OpenGT.Manager();
                return rooms[manager.RandomByPlace(seed, seed * 11, seed * 101,position)];
            }
        }
    }
}
