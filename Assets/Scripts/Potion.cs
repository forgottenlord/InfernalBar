using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InfernalBar
{
    public class Potion : MonoBehaviour
    {
        public string Title;
        public PotionType type;
    }

    [Flags]
    public enum PotionType
    {
        None = 0,
        LowAlcohol = 1,
        HighAlcohol = 2,
        Sweet = 4,
        Hot = 8,
    }
}