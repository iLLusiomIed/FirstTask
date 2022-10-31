using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterButton : MonoBehaviour
{
    public Text text;
    private IShow drawer;
    private int Count = 0;
    private void Start()
    {
        drawer = new Drawer(text);
    }
    public void Clicked()
    {
        Count++;
        drawer.ShowInfo(Count.ToString());
    }
}
