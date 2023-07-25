using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private string breed;

    public Dog(string breed)
    {
        this.breed = breed;
    }

    public new string Species
    {
        get { return "Dog"; }
    }

    public void Bark()
    {
        Debug.Log("Woof! Woof!");
    }

    // Inheritance 
    public override void Speak()
    {
        Debug.Log("Bark! Bark!");
    }
}
