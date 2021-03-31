using UnityEngine;

public class OpenWebpage : MonoBehaviour
{
    [SerializeField] private string url;

    public void OpenURL()
    {
        Application.OpenURL(url);
    }
}
