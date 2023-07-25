using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour, ISound
{
    private string species;
    private int age;
    // Encapsulation
    public string Species
    {
        get { return species; }
        set { species = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = Mathf.Max(0, value); }
    }

    public abstract void Speak();


    public virtual void MakeSound()
    {
        Speak();
    }

}
