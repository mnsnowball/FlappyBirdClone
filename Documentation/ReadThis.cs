using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadThis : MonoBehaviour {

    /*
     * This asset package is meant to imitate the mechanic of the game Flappy Bird. I created all of the included scripts
     * and assets over the course of about three days.
     * 
     * Here's how it works:
     * 
     * There are a few different empty game objects at work here:
     * 
     *      -The leftBounds game object deletes the piping upon collision with the gameObjects - it deletes anything that it comes into contact with.
     * 
     *      -The LevelGenerator game object does exactly what the name implies: it generates pipes with heights that are all relative to each other. 
     * The maximum height difference can be configured within the code, but can also easily be altered to be changeable within the inspector window.
     * The pipes gameObject is an empty parent for the top and bottom pipes, with the movingLevel script attached. This makes it easier to move all of the piping uniformly in one direction.
     * The top and bottom pipes respectively have a GameOver script attached to them which simply sets the timeScale to zero and makes the gameOver text appear. The gameOver text has its
     * own tag.
     * The scorer gameObject accesses the score text - the score text has its own tag as well. It has the script IncrementScore finds the score text using its tag
     * and increments it on contact.
     * 
     * I made the IncrementScore text because I had difficulty accessing the score without it having its own tag. If I made it publicly accessible, I would have had to make the scoreText a prefab,
     * and that wouldn't work because the score got stuck at 1.
     * 
     * I had a similar issue with setting the gameOver text to be active, but instead of activating the gameObject itself I just switched the text on and off.
     */
}
