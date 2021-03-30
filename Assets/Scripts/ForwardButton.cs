using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForwardButton : MonoBehaviour
{
    private Button thisButton;
    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        thisButton = gameObject.GetComponent<Button>();
        thisButton.onClick.AddListener(TaskOnClick);

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void TaskOnClick()
    {
        player.MoveForward();
    }
}
