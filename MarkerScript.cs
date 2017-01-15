using UnityEngine;
using System.Collections;

public class MarkerScript : MonoBehaviour {
    //quad 1
        //floor (otherCollider) shader
            //marker (this.transform) glow & sound
            //marker animation
            //marker pickup
        //TRANSITION: record player glow & sound & enable collider

    //quad 2
        //recordPlayer (otherCollider)
        //recordPlayer reverse animation
        public GameObject lotusFlower; //animation
        public GameObject thai; //particles
        public GameObject forest; //particles
        //end record player glow
        //TRANSITION: posters glow & sound & enable collider

    //quad 3
        public GameObject posters;
        //end posters glow
        //TRANSITION: pillow glow & sound & enable collider

    //quad 4
        public GameObject pillow;
        //pillow animation
        public GameObject letters;
        //letters animation
        public GameObject mushrooms;
        //mushroom script
        public GameObject ceiling; //Q7 shader
        //end pillow glow
        //TRANSITION: water buffalo glow & sound & enable collider

    //quad 5
        public GameObject waterBuffalo;
        //water buffalo animation
        public GameObject clouds; //particle (outside window)
        //end water buffalo glow
        //TRANSITION: mannequin glow & sound & enable collider

    //quad 6
        public GameObject mannequin;
        public GameObject logo; //animation
        //end mannequin glow

    //M4R5W0N6011317
    void OnTriggerEnter(Collider otherCollider)
    {
        Debug.Log("hit!");
        if (otherCollider.gameObject.tag == "GameController")
        {
            this.transform.parent = otherCollider.gameObject.transform;
            transform.position = this.transform.parent.position;

            transform.rotation = Quaternion.LookRotation(transform.parent.forward);
        }
        else if (otherCollider.gameObject.tag == "Quad 1")
        {
            InitiateQuadOne(otherCollider);
        }
        else if (otherCollider.gameObject.tag == "Quad 2")
        {
            InitiateQuadTwo(otherCollider);
        }
        else if (otherCollider.gameObject.tag == "Quad 3")
        {
            InitiateQuadThree(otherCollider);
        }
        else if (otherCollider.gameObject.tag == "Quad 4")
        {
            InitiateQuadFour(otherCollider);
        }
        else if (otherCollider.gameObject.tag == "Quad 5")
        {
            InitiateQuadFive(otherCollider);
        }
        else if (otherCollider.gameObject.tag == "Quad 6")
        {
            InitiateQuadSix(otherCollider);
        }

    }

    void InitiateQuadOne (Collider otherCollider)
    {
        //otherCollider.gameObject.GetComponent<Animator>().enabled = true;
    }
    void InitiateQuadTwo(Collider otherCollider)
    {

    }
    void InitiateQuadThree(Collider otherCollider)
    {

    }
    void InitiateQuadFour(Collider otherCollider)
    {

    }
    void InitiateQuadFive(Collider otherCollider)
    {

    }
    void InitiateQuadSix(Collider otherCollider)
    {

    }
    void InitiateQuadSeven(Collider otherCollider)
    {

    }
}
