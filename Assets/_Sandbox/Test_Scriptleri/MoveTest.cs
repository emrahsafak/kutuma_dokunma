using UnityEngine;

public class MoveTest : MonoBehaviour
{
    public float speed = 5f;

    // Normalized at all or not 
    public bool useNormalization = true;

    // Chose which method to test:
    public bool useNormalizeMethod = false; // false = .normalized, true = .Normalize()

    private Vector3 lastMoveDirection = Vector3.zero; // Remember last direction of the  vector


    void Update()
    {
        // Klavyeden Input al.
        float yatay = Input.GetAxis("Horizontal");    // A-D veya sol-sað 

        float dikey = Input.GetAxis("Vertical");      // W-S veya Yukarý-Aþaðý 

        // 2D oyunlarda bile pozisyon Vector3 ile tutulur. ( z = 0 )
        Vector3 hareket = new Vector3(yatay, dikey, 0f);

        // If no input, do nothing 
        if (hareket.sqrMagnitude > 0)
        {
            if (useNormalization)
            {
                if (useNormalizeMethod)
                {
                    // METHOD 1: Normalize() --> modifies the vector in-places
                    hareket.Normalize();
                }
                else
                {
                    // METHOD 2: normalized --> return a NEW normalized vector
                    hareket = hareket.normalized;
                }

                lastMoveDirection = hareket; // we are saving the movement data before get out of the if 
            
            }
        }
        else
        {
            hareket = lastMoveDirection; // we are readýng the last movement data with hareket.
        }

        // Pozisyon güncelle // // Move object
        transform.position += hareket * speed * Time.deltaTime;

        // Debug info to see the values in Console

        Debug.Log("Hareket = " + hareket + " | magnitude = " + hareket.magnitude);


    }


}
