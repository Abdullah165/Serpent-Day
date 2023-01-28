using UnityEngine.UI;
using UnityEngine;

public class ResultWindow : MonoBehaviour
{
    [SerializeField] Text timer;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.text.Equals("0:01"))
        {
            transform.LeanScale(Vector2.one, 0.3f);
        }
    }
}
