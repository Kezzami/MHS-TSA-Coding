using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toCoordinators : MonoBehaviour
{
    public void goCoordinators()
    {
        SceneManager.LoadScene("Coordinators");
    }
}
