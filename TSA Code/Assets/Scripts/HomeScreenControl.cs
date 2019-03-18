using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class HomeScreenControl : MonoBehaviour
{
    public Button headFaculty;

    // Start is called before the first frame update
    void Start()
    {
        Button head = headFaculty.GetComponent<Button> ();

        head.onClick.AddListener(ClickHead);
    }
    
    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public void ClickHead()
    {
        SceneManager.LoadScene("HeadFaculty");
    }
}
