using UnityEngine.UI;
using UnityEngine;

public class ExtraTime : MonoBehaviour
{
    public enum Direction { left, right }
    public Direction direction;

    [SerializeField] float ObjectSpeed = 200;
    private Vector2 MovementDirection;

    [SerializeField] Text timer;

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

        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(MovementDirection * ObjectSpeed * Time.deltaTime);
        if (timer.text.Equals("0:59") || timer.text.Equals("0:40") || timer.text.Equals("0:20"))
        {
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LeftObstacle"))
        {
            MovementDirection = Vector2.right;
            direction = Direction.right;
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
        else if (collision.gameObject.CompareTag("RightObstacle"))
        {
            MovementDirection = Vector2.left;
            direction = Direction.left;
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
        else if (collision.gameObject.CompareTag("SerpentMouth"))
        {
            if (timer.text.Equals("0:59") || timer.text.Equals("0:58") || timer.text.Equals("0:57") || timer.text.Equals("0:40") || timer.text.Equals("0:39") || timer.text.Equals("0:38") || timer.text.Equals("0:20") || timer.text.Equals("0:19") || timer.text.Equals("0:18"))
            {
                gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                // add 20 second as extra time.
                Timer.timeForOneRound += 20;
            }
        }
    }
}
