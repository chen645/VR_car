
using UnityEngine;
using UnityEngine.UI;
public class Rotate : MonoBehaviour
{
    public Slider slider;
    public Slider slider2;
    public GameObject model;
    // Start is called before the first frame update

    public void sliderRotatemodel()
    {
        model.transform.rotation = Quaternion.Euler(model.transform.rotation.x, slider.value, model.transform.rotation.z);


    }
    
}
