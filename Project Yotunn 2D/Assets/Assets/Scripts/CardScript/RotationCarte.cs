using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Dérive de la class Monobehavior, 
// Nous permet d'accéder à des méthodes importantes dans le code:
// Start(), Update(), FixedUpdate(), LateUpdate() --> sont des méthodes qui sont appelé dès l'instanciation de l'objet
//                  --> Les fonctions avec le nom Update se font appeller indifiniment par le mécanisme du jeu lorsque l'objet est instancié 
// Source pour documentation sur la class parent monobehavior https://docs.unity3d.com/ScriptReference/MonoBehaviour.html 

public class RotationCarte : MonoBehaviour {
    // Ce script est attaché à la carte pour afficher laquelles des faces de la carte devant être affiché.

    // Object parent pour les aspects graphics de la carte avant
    public RectTransform CarteFace;

    // Object parent pour les aspects graphics de la carte arriere
    public RectTransform CarteBack;

    // L'object carte qui sera utile lorsque que nous voudrions savoir la rotation de la carte
    public Transform Carte;

    // Si la bool est faux la camera regarde l'arrière
    private bool arriereCarte = false;

	// Méthode appelé à chaque changement d'image (frame) 
	void Update () {
        //Si la rotation est plus grand que 90deg ou plus petit que 270 deg nous désactivons la face de la carte et nous activons l'arrière de la carte
        //https://answers.unity.com/questions/149801/transformrotation-in-degrees-instead-of-0-to-1.html <-- EulerAngle
        if (Carte.eulerAngles.y > 90 && Carte.eulerAngles.y < 270)
        {
            //SetActive est une méthode prennant une bool et si true active l'élément si prend false désactive l'élément
            CarteFace.gameObject.SetActive(false);
            CarteBack.gameObject.SetActive(true);
        }
        else
        {
            // Au contraire ici nous désactivons l'arrière pour activer la face, cela donne une effet de réalisme
            CarteFace.gameObject.SetActive(true);
            CarteBack.gameObject.SetActive(false);
        }
    }

    //Yan
}
