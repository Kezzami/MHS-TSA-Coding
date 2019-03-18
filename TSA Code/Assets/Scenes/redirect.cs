using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class redirect : MonoBehaviour
{
    // Start is called before the first frame update
    public void changeToHeadFaculty(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
