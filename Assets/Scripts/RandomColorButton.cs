using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColorButton : MonoBehaviour
{
    private Image image;
    private IChangeColor randColor;
    private void Start()
    {
        image = GetComponent<Image>();
        randColor = new RandomColor(image);
    }
    
    public void Clicked()
    {
        randColor.SetColor();
    }
}
