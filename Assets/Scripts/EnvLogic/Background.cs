using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update


    [Range(-1f, 1f)]
    //variable for the speed of the background movement
    public float scrollSpeed = 0.5f;
    private float offset;

    //variable for the material of the background
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset,0));
    }
}
