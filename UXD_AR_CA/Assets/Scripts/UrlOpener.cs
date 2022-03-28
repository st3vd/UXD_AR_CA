using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlOpener : MonoBehaviour
{
public string URL;
public void Open()
{
Application.OpenURL(URL);
}
    // Start is called before the first frame update
  
}
