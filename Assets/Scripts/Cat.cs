using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cat : Animal
{

    public string furColor;

    public Cat(string furColor)
    {
        this.furColor = furColor;
    }

    public new string Species
    {
        get { return "Cat"; }
    }

    public void Purr()
    {
        Debug.Log("Purr... Purr...");
    }


    // Inheritance
    public override void Speak()
    {
        Debug.Log("Meow! Meow!");
    }

}
