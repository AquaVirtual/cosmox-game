using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class CloseError : MonoBehaviour
{

    public GameObject Error;

    public string Pause_Setup { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitError()
    {
        Error.SetActive(false);
    }

}