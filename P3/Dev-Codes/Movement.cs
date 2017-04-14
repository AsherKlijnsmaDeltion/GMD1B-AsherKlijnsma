using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 move;
    public Vector3 jump;
    public float hor;
    public float boost;
    public int jumpCount;
    public Rigidbody rb;
    public RaycastHit hit;
    private Vector3 right;
    public bool permission;
    public GameObject conversationManager;
    // Use this for initialization
    void Start()
    {
        boost = 20;//zet boost op 20
    }

    // Update is called once per frame
    void Update()
    {
        CheckButtons();//voer deze functie uit elke frame

        move.x = hor;
        hor = Input.GetAxis("Horizontal");
        transform.Translate(move * Time.deltaTime * boost);//zet de basis benodigdheden voor movement
        if (jumpCount < 2)//geef de voorwaarde van wanneer je mag springen
        {
            if (Input.GetButtonDown("Jump"))//als je op spatie drukt
            {
                rb.velocity = jump;//de velocity van de rigidbody wordt omgezet naar de waarde van jump
                jumpCount++;//geef de jumpcout +1
            }
        }
        right = transform.TransformDirection(Vector3.right) * 10;//geeft aan wat de vector3 right is
        Debug.DrawRay(rb.transform.position, right, Color.green);//geef de raycast groen weer
        if (Physics.Raycast(transform.position, right, out hit, 10))//geef de voorwaarde dat de raycast iets raakt
        {
            if (hit.transform.tag == "NPC")//geef de voowaarde dat het de tag npc heeft
            {
                if (permission == true)//als de bool permission true staat
                {
                    conversationManager.GetComponent<ConversationScript>().StartConvo();//voer de functie StartConvo uit
                    EnableText();//voer de functie enableText uit
                    permission = false;//zet de bool op false
                    
                }
                if (Input.GetButtonDown("E"))//als er op e gedrukt wordt
                {
                  DisableText();//voer de disableText functie uit
                  EnableConvo();//voer de functie EnableConvo uit
                 }
              }
          }
     }
    void OnCollisionEnter(Collision C)
    {
        if (C.gameObject.tag == "Ground")//geef als voorwaarde dat het object waar aanraking mee is de tag ground heeft
        {
            jumpCount = 0;//zet de jumpcounter op 0
        }
    }
    void EnableConvo()
    {
        
        GameObject.Find("Main Camera").GetComponent<UIManager>().canvas.SetActive(true);//zet de canvas aan
        
    }
    void EnableText()
    {
        GameObject.Find("Main Camera").GetComponent<UIManager>().textCanvas.SetActive(true);//zet de text aan
        
    }
    void DisableText() {

        GameObject.Find("Main Camera").GetComponent<UIManager>().textCanvas.SetActive(false);//zet de canvas uit
        
    }

    // This checks for conversation input
    public void CheckButtons()
    {
        if (Input.GetButtonDown("Yes"))//geef als voorwaarde dat er op yes wordt gedrukt
        {
            conversationManager.GetComponent<ConversationScript>().OnClick(1);//geef een waarde van 1 mee bij yes
        }
        if (Input.GetButtonDown("No"))//geef als voorwaarde dat er op no wordt gedrukt
        {
            conversationManager.GetComponent<ConversationScript>().OnClick(2);//geef een waarde van 2 mee bij no
        }
    }
}

