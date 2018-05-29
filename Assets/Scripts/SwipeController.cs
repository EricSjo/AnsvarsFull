using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SwipeController : MonoBehaviour
{
    private Vector3 startPosition = Vector3.zero;
    private Vector3 endPosition = Vector3.zero;
    private float deltaX, deltaY;

    public GameObject tipOne, tipTwo, tipThree, tipFour, tipFive, tipSix, tipSeven;
    public GameObject tips1, tips2, tips3, tips4, tips5, tips6, tips7;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // swipe begins
        {
            startPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButtonUp(0))    // swipe ends
        {
            endPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (startPosition != endPosition && startPosition != Vector3.zero && endPosition != Vector3.zero)
        {
            deltaX = endPosition.x - startPosition.x;
            deltaY = endPosition.y - startPosition.y;
            if ((deltaX > 2.0f || deltaX < -2.0f) && (deltaY >= -1.0f || deltaY <= 1.0f))
            {
                if (startPosition.x < endPosition.x) // swipe LTR
                {
                    if (tips2.active)
                    {
                        tips2.SetActive(false);
                        tipTwo.SetActive(false);
                        tips1.SetActive(true);
                        tipOne.SetActive(true);
                    }
                    else if (tips3.active)
                    {
                        tips3.SetActive(false);
                        tipThree.SetActive(false);
                        tips2.SetActive(true);
                        tipTwo.SetActive(true);
                    }
                    else if (tips4.active)
                    {
                        tips4.SetActive(false);
                        tipFour.SetActive(false);
                        tips3.SetActive(true);
                        tipThree.SetActive(true);

                    }
                    else if (tips5.active)
                    {
                        tips5.SetActive(false);
                        tipFive.SetActive(false);
                        tips4.SetActive(true);
                        tipFour.SetActive(true);
                    }
                    else if (tips6.active)
                    {

                        tips6.SetActive(false);
                        tipSix.SetActive(false);
                        tips5.SetActive(true);
                        tipFive.SetActive(true);

                    }
                    else if (tips7.active)
                    {
                        tips7.SetActive(false);
                        tipSeven.SetActive(false);
                        tips6.SetActive(true);
                        tipSix.SetActive(true);
                    }

                }
                else if (startPosition.x > endPosition.x)// swipe RTL
                {
                    if (tips1.active)
                    {
                        tips1.SetActive(false);
                        tipOne.SetActive(false);
                        tips2.SetActive(true);
                        tipTwo.SetActive(true);
                    }
                    else if (tips2.active)
                    {
                        tips2.SetActive(false);
                        tipTwo.SetActive(false);
                        tips3.SetActive(true);
                        tipThree.SetActive(true);
                    }
                    else if (tips3.active)
                    {
                        tips3.SetActive(false);
                        tipThree.SetActive(false);
                        tips4.SetActive(true);
                        tipFour.SetActive(true);
                    }
                    else if (tips4.active)
                    {
                        tips4.SetActive(false);
                        tipFour.SetActive(false);
                        tips5.SetActive(true);
                        tipFive.SetActive(true);
                    }
                    else if (tips5.active && tips6 != null)
                    {
                        tips5.SetActive(false);
                        tipFive.SetActive(false);
                        tips6.SetActive(true);
                        tipSix.SetActive(true);
                    }
                    else if (tips6.active)
                    {
                        tips6.SetActive(false);
                        tipSix.SetActive(false);
                        tips7.SetActive(true);
                        tipSeven.SetActive(true);
                    }

                }
            }
            startPosition = endPosition = Vector3.zero;
        }

    }
}