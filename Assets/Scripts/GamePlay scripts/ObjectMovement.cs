using UnityEngine;
using UnityEngine.UI;

public class ObjectMovement : MonoBehaviour
{
    public enum Direction { left, right }
    public Direction direction;

    [SerializeField] float ObjectSpeed = 200;
    private Vector2 MovementDirection;

    [SerializeField] Image[] Flys;
    [SerializeField] Image[] Leaves;


    // Start is called before the first frame update
    void Start()
    {
        switch (direction)
        {
            case Direction.left:
                MovementDirection = Vector2.left;
                break;
            case Direction.right:
                MovementDirection = Vector2.right;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(MovementDirection * ObjectSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LeftObstacle"))
        {
            MovementDirection = Vector2.right;
            direction = Direction.right;
            gameObject.GetComponent<Image>().sprite = Flys[Random.Range(0, Flys.Length - 1)].sprite;
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            if (gameObject.tag == "Leaf")
            {
                gameObject.tag = "Fly";
            }
        }
        else if (collision.gameObject.CompareTag("RightObstacle"))
        {
            MovementDirection = Vector2.left;
            direction = Direction.left;
            gameObject.GetComponent<Image>().sprite = Leaves[Random.Range(0, Leaves.Length - 1)].sprite;
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            if (gameObject.tag == "Fly")
            {
                gameObject.tag = "Leaf";
            }
        }
        else if (collision.gameObject.CompareTag("SerpentMouth"))
        {
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
    }
}
