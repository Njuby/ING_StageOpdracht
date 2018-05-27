using System;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

    public Animal[] animals;
    
    public Button giveLeaves,
        giveMeat,
        doTricks,
        sayHello;

    public InputField nameField;

    private string inputName;

    
    private void Start()
    {
        //get all buttons to work
        giveLeaves = giveLeaves.GetComponent<Button>();
        giveLeaves.onClick.AddListener(OnClickLeaves);
        giveMeat = giveMeat.GetComponent<Button>();
        giveMeat.onClick.AddListener(OnClickMeats);
        doTricks = doTricks.GetComponent<Button>();
        doTricks.onClick.AddListener(OnClickTricks);
        sayHello = sayHello.GetComponent<Button>();
        sayHello.onClick.AddListener(OnClickHello);

        //get all animals
        animals = FindObjectsOfType<Animal>();
        //check if names work
        //foreach(Animal a in animals)
        //{
        //    Debug.Log(a.name);
        //}
    }

    private void Update()
    {
        //get textfield input
        inputName = nameField.text;
        Debug.Log(inputName);
        
    }

    private void OnClickHello()
    {
        //Debug.Log("button works");
        foreach (Animal a in animals)
        {
            if (a.name.Equals(inputName))
            {
                a.SayHello();
                //if we dont return here then the animal with the correct name will say hello BUT all others will do too
                return;
            }
            else
            {
                a.SayHello();
            }
        }
    }

    private void OnClickTricks()
    {
        foreach (Animal a in animals)
        {
            a.PerformTrick();
        }
    }

    private void OnClickMeats()
    {
        foreach (Animal a in animals)
        {
            a.EatMeat();
        }
    }

    private void OnClickLeaves()
    {
        foreach (Animal a in animals)
        {
            a.EatLeaves();
        }
    }

   

}
