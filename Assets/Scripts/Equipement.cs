using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class Equipement {

    public string Name;
    public float Price;
    public string Rarity;
}

[Serializable]
public class ListL{
    public List<Equipement> L;
}
