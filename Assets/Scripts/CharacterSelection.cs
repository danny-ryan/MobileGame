using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{

    private GameObject[] characters;
    private int index;


    void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        characters = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            characters[i] = transform.GetChild(i).gameObject;
        }

        foreach (GameObject go in characters)
        {
            go.SetActive(false);
        }

        if (characters[index])
        {
            characters[index].SetActive(true);
        }
    }


    public void NextCharacter()
    {
        characters[index].SetActive(false);

        index--;
        if (index < 0)
        {
            index = characters.Length - 1;

        }
        characters[index].SetActive(true);

    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("Scene1");
    }
}
