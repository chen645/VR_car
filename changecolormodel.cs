using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class changecolormodel : MonoBehaviour
{
    // Start is called before the first frame update
    public MeshRenderer meshModel;
    public void ChangeColor()
    {
        meshModel.material.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
    }

}
