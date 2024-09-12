using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    {
                        Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                        if (touchedCollider != null && touchedCollider.transform == transform)
                        {
                            isDragging = true;
                            offset = transform.position - touchPosition;
                        }
                        break;
                    }
                case TouchPhase.Moved:
                    {
                        if (isDragging)
                        {
                            transform.position = touchPosition + offset;
                            gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
                        }
                    }
                    break;
                case TouchPhase.Ended:
                    {
                        //Adicionar pontuação ou algum outro elemento de game design 
                        if (isDragging)
                        {
                            Vector3 location = new Vector3(touchPosition.x, touchPosition.y, 0);
                            Collider2D[] hit = Physics2D.OverlapCircleAll(location, 0.2f);

                            foreach (Collider2D target in hit)
                            {
                                if (target.gameObject.CompareTag("Quadrado"))
                                {
                                    if (gameObject.name == "Square")
                                    {
                                        Destroy(gameObject);
                                    }
                                    else
                                    {
                                        transform.position = startPosition;
                                    }
                                }
                            }

                            isDragging = false;
                            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                        }
                        break;
                    }
                    
            }
        }
    }
}
