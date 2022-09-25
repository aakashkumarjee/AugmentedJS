using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class PreviousScene : MonoBehaviour
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
        SceneManager.LoadScene("B");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        VirtualButton.SetActive(false);
    }



}
