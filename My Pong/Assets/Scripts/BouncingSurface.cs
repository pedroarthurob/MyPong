using UnityEngine;

public class BouncingSurface : MonoBehaviour
{
    [SerializeField] private AudioClip bounceAudio;
    [SerializeField] private float bounciness;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            SoundFXManager.instance.PlaySoundFxClip(bounceAudio, transform, 1f);
            ball.AddForce(-normal*bounciness);
        }
    }
}
    