using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
public class DScreen : MonoBehaviour
{
    public GameObject VirtualButton;
    public GameObject Scenename;

    void Start()
    {
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        VirtualButton.SetActive(true);
        SceneManager.LoadScene("D");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        VirtualButton.SetActive(false);
    }

}
