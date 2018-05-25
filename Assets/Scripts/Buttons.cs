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

    public string inputName;

    private void Start()
    {
        giveLeaves = giveLeaves.GetComponent<Button>();
        giveLeaves.onClick.AddListener(OnClickLeaves);
        giveMeat = giveMeat.GetComponent<Button>();
        giveMeat.onClick.AddListener(OnClickMeats);
        doTricks = doTricks.GetComponent<Button>();
        doTricks.onClick.AddListener(OnClickTricks);
        sayHello = sayHello.GetComponent<Button>();
        sayHello.onClick.AddListener(OnClickHello);
    }

    private void OnClickHello()
    {
        foreach(Animal a in animals)
        {
            a.SayHello();
        }
    }

    private void OnClickTricks()
    {
        foreach (Animal a in animals)
        {
            a.DoTrick();
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

    private void Update()
    {
        inputName = nameField.text;
        Debug.Log(inputName);
    }

}
