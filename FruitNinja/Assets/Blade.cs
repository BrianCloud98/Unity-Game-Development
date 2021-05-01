using UnityEngine;

public class Blade : MonoBehaviour
{
    bool isCutting = false;
    Rigidbody2D rb;
    Camera cam;
    bool isLeft = true;
    bool isRight = false;
    EdgeCollider2D edgeCollider;
    Vector2 previousPosition;
    public float minCuttingVelocity = .0001f;

    private void Start()
    {
        edgeCollider = GetComponent<EdgeCollider2D>();
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetAxis("Mouse X") < 0)
        {
            isRight = true;
            isLeft = false;
        } else if (Input.GetAxis("Mouse X") > 0) {
            isRight = false;
            isLeft = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        } else if (Input.GetMouseButtonUp(0)) {
            StopCutting();
        }

        if (isCutting)
        {
            UpdateCut();
        }

    }
    void UpdateCut()
    {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;

        float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
        if (velocity > minCuttingVelocity)
        {
            edgeCollider.enabled = true;
        } else
        {
            edgeCollider.enabled = false;
        }

        previousPosition = newPosition;

        if (isRight)
        {
            transform.eulerAngles = new Vector3(0, 50, 180);
        } else {
            transform.eulerAngles = new Vector3(0, 230, 180);
        }        
    }

    void StartCutting()
    {
        isCutting = true;
        edgeCollider.enabled = false;
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void StopCutting()
    {
        isCutting = false;
        edgeCollider.enabled = false;
    }
}
