using UnityEngine;
using System.Collections;


public class BoxManager : MonoBehaviour
{
    public GameObject Boxing;
    public GameObject feet;
    public GameObject bos;
    public int kutu=0;
    public GameObject[] dene;
    public GameObject replay;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kutu")
        {
            gameObject.transform.position = gameObject.transform.position += new Vector3(0, 1, 0);
            Destroy(other.gameObject);
            kutuNew();
        }

        if (other.gameObject.tag=="enemy")
        {
            dene = GameObject.FindGameObjectsWithTag("Tasi");
            int x = dene.Length-1;
            if (dene.Length > 1)
            {
                for (int i = 0; i < 1; i++)
                {
                    Destroy(dene[x]);
                    x--;
                    StartCoroutine(Fallling());
                }

            }
            else
            {
                Time.timeScale = 0f;
                replay.SetActive(true);
            }

        }
        else if (other.gameObject.tag=="enemy2")
        {
            dene = GameObject.FindGameObjectsWithTag("Tasi");
            int x = dene.Length - 1;
            if (dene.Length > 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    Destroy(dene[x]);
                    x--;
                    StartCoroutine(Fallling());
                }
            }
            else
            {
                Time.timeScale = 0f;
                replay.SetActive(true);
            }

        }
        else if (other.gameObject.tag == "enemy3")
        {
            dene = GameObject.FindGameObjectsWithTag("Tasi");
            int x = dene.Length - 1;
            if (dene.Length > 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Destroy(dene[x]);
                    x--;
                    StartCoroutine(Fallling());
                }
            }
            else
            {
                Time.timeScale = 0f;
                replay.SetActive(true);
            }

        }
        else if (other.gameObject.tag == "enemy4")
        {
            dene = GameObject.FindGameObjectsWithTag("Tasi");
            int x = dene.Length - 1;
            if (dene.Length > 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    Destroy(dene[x]);
                    x--;
                    StartCoroutine(Fallling());
                }
            }
            else
            {
                Time.timeScale = 0f;
                replay.SetActive(true);
            }

        }
        else if (other.gameObject.tag == "enemy5")
        {
            dene = GameObject.FindGameObjectsWithTag("Tasi");
            int x = dene.Length - 1;
            if (dene.Length > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Destroy(dene[x]);
                    x--;
                    StartCoroutine(Fallling());
                }
            }
            else
            {
                Time.timeScale = 0f;
                replay.SetActive(true);
            }
        }
    }
    IEnumerator Fallling()
    {
        yield return new WaitForSeconds(0.6f);
         gameObject.transform.position = gameObject.transform.position -= new Vector3(0, 1, 0);
        feet.transform.Translate(0,1, 0);

    }
    public void kutuNew()
    {
        feet.transform.position += new Vector3(0, kutu);
        GameObject Parent = Instantiate(Boxing, feet.transform.position, Quaternion.identity) as GameObject;
        Parent.transform.SetParent(bos.transform);
        kutu = -1;
    }


}
