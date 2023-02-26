using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangBodyColorSlider : MonoBehaviour
{
    public Slider bodySlider;
    public SpriteRenderer bodySpriteRenderer;
    private Color lightColor, darkColor;

    // Start is called before the first frame update
    void Start()
    {
        lightColor = new Color(1, (float) 0.8745, (float) 0.7686, 1);
        darkColor = new Color((float) 0.3098, (float) 0.2745, (float) 0.2431, 1); 
        bodySlider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bodySpriteRenderer.color = Color.Lerp(lightColor, darkColor, bodySlider.value);
    }
}
