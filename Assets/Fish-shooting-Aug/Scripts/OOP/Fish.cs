using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish  {


    public Fish()
    {
        Name = "fish(clone)";
        Value = 0;

    }
    public Fish(string name, int value)
    {
        Name = name;
        Value = value;
    }
    public string Name { get; private set; }
    public int Value { get; private set; }
}
