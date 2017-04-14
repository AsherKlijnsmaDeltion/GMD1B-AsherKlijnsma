using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    public List<string> conversation = new List<string>();
    public int layer;
    public int index;
    public float modifier;
    public int stopCount;
    // Use this for initialization
	void Start ()
    {
        layer = 1;//zet layer op 1
	}
	
	// Update is called once per frame
	public void StartConvo ()
    {
        GameObject.Find("Main Camera").GetComponent<UIManager>().talk.text = conversation[0];//zet de tekst gelijk aan index 0 uit de list
	}
    public void OnClick(int i)
    {
        if (layer < stopCount)//geef als waarde dat layer kleiner is dan maxlayer
        {
            index = (layer * i);//zet de index gelijk aan de laag waar die zich in bevind keer de overload
            layer++;//geef de laag +1
            GameObject.Find("Main Camera").GetComponent<UIManager>().talk.text = conversation[index];//zet de tekst gelijk aan de index van de list

        }
        else
        {
            layer = 1;//zet de layer terug op 1
            index = 0;//zet de index terug op 0
        }
    }
}


