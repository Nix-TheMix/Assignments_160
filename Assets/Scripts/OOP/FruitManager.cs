using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> FruitSalad;


    // Start is called before the first frame update
    void Start()
    {
        FruitSalad = new List<Fruit>();  //defining list of fruits

        Fruit fruit = new Fruit("apple", "green", 1.2f);

        FruitSalad.Add(fruit);

        CreateFruitSalad();
        DisplayFruitSalad();

    }

    private void DisplayFruitSalad()
    {
        for (int i = 0; i < FruitSalad.Count; i++)
        {
            print(FruitSalad[i].color + " " + FruitSalad[i].name + " weighing " + FruitSalad[i].weight + "units");
        }

    }

    private void CreateFruitSalad()
    {
        FruitSalad.Add(new Fruit());

        FruitSalad.Add(new Fruit("strawberry"));

        FruitSalad.Add(new Fruit(7.9f));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
