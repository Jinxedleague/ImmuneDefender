using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    int lives;
    int keyPicker;
    int keyCount;
    public Text livesText;
    public Text spellingText;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        keyPicker = 0;
        keyCount = 0;
        livesText.text = "Lives: " + lives;
        spellingText.text = "Press the matching keys to power up your immune system! Lets start with 'V'";
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives;
        if(keyCount == 50)
        {
            SceneManager.LoadScene("Win");
        }
        else { }

        if(Input.GetKeyDown(KeyCode.V) && keyPicker==0)
        {
            keyCount++;
            keyPicker = Random.Range(0, 5);
            keyText();
        }
        if (Input.GetKeyDown(KeyCode.I) && keyPicker == 1)
        {
            keyCount++;
            keyPicker = Random.Range(0, 5);
            keyText();
        }
        if (Input.GetKeyDown(KeyCode.R) && keyPicker == 2)
        {
            keyCount++;
            keyPicker = Random.Range(0, 5);
            keyText();
        }
        if (Input.GetKeyDown(KeyCode.U) && keyPicker == 3)
        {
            keyCount++;
            keyPicker = Random.Range(0, 5);
            keyText();
        }
        if (Input.GetKeyDown(KeyCode.S) && keyPicker == 4)
        {
            keyCount++;
            keyPicker = Random.Range(0, 5);
            keyText();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Virus"))
        {
            if (lives >= 1)
            {
                lives--;
                Destroy(collision.gameObject);
            }
            else if (lives == 0)
            {
                SceneManager.LoadScene("Loss");
            }
        }
        Debug.Log("Lives: " + lives);
    }

    private void keyText()
    {
        if(keyPicker == 0)
        {
            spellingText.text = "V (" + keyCount + ")";
        }
        if (keyPicker == 1)
        {
            spellingText.text = "I (" + keyCount + ")";
        }
        if (keyPicker == 2)
        {
            spellingText.text = "R (" + keyCount + ")";
        }
        if (keyPicker == 3)
        {
            spellingText.text = "U (" + keyCount + ")";
        }
        if (keyPicker == 4)
        {
            spellingText.text = "S (" + keyCount + ")";
        }
    }
}
