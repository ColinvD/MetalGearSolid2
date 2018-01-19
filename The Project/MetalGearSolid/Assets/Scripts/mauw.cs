using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mauw : MonoBehaviour
{
    [SerializeField]
    private Image healthbar;
    public bool show;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        /*
        if (show && y > -50)
        {
            y -= Time.deltaTime * 1;
            healthbar.transform.position = new Vector3(healthbar.transform.position.x, healthbar.transform.position.y + 1f, healthbar.transform.position.z);
        }
        else if (y < -50)
        {
            //healthbar.transform.position.y - healthbar.canvas.pixelRect.height > -healthbar.rectTransform.rect.height
            healthbar.transform.position = new Vector3(healthbar.transform.position.x, healthbar.canvas.pixelRect.height - healthbar.rectTransform.localPosition.y, healthbar.transform.position.z);
        }
        else if (!show && y < -200)
        {
            y += Time.deltaTime * 1;
        }
        if (y <= -200)
        {
            disable
        }
        else
        {
            enable
        }
        */
    }

    float getY()
    {
        return healthbar.transform.position.y - healthbar.canvas.pixelRect.height;
    }

    void setY(float input)
    {
        healthbar.transform.position = new Vector3(healthbar.transform.position.x, healthbar.canvas.pixelRect.height + input, healthbar.transform.position.z);
    }

    void addY()
    {
        healthbar.transform.position += new Vector3(0, 1.0f, 0);
    }
}
