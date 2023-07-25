using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalGenerate : MonoBehaviour
{
    // Polymorphism
    void Start()
    {
        List<ISound> animals = new List<ISound>();

        Dog dog = new Dog("Golden Retriever");
        dog.Age = 10;
        animals.Add(dog);

        Cat cat = new Cat("Gray");
        cat.Age = 5;
        animals.Add(cat);

        foreach (ISound animal in animals) { 
            animal.MakeSound();
        }
    }
}
