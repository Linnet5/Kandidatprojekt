using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScrollingTiles : MonoBehaviour
{

    RawImage sprite;

    [Range(0.0f, 0.05f)]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        sprite.uvRect = new Rect(sprite.uvRect.x + speed* Time.deltaTime,
            sprite.uvRect.y+ speed * Time.deltaTime, 
            sprite.uvRect.width, 
            sprite.uvRect.height);
    }
}
