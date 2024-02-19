using UnityEngine.EventSystems;
using UnityEngine;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    [SerializeField] private AudioClip pointAudio;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            SoundFXManager.instance.PlaySoundFxClip(pointAudio, transform, 1f);
            this.scoreTrigger.Invoke(eventData);
        }
    }
}
