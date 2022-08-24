using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fish"))
        {
            Fish.Instance.score += 1;
            Fish.Instance.scoreText.text = Fish.Instance.score.ToString();
        }
    }
}
