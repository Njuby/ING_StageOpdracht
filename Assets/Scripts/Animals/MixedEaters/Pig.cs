using UnityEngine;
using UnityEngine.UI;

public class Pig : Animal{
    public string name;
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    private Text text;

    protected override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "oink oink";
    }

    protected override void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = "munch munch oink";
    }

    protected override void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = "nomnomnom oink thx";
    }

    protected override void PerformTrick()
    {
        StartCoroutine(DoTrick());
    }
}

	
