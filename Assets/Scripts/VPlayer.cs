using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VPlayer : MonoBehaviour
{
    public Button button;
    public Button play;
    public Button pause;
    public Slider slider;
    public VideoPlayer videoPlayer;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnClick);
        play.onClick.AddListener(OnPlayClick);
        pause.onClick.AddListener(OnPauseClick);
        slider.onValueChanged.AddListener(ValueChange);
    }


    void OnClick()
    {
        animator.Play("show");
    }

    void OnPlayClick()
    {
        videoPlayer.Play();
    }

    void OnPauseClick()
    {
        videoPlayer.Pause();
    }

    void ValueChange(float value)
    {
        videoPlayer.SetDirectAudioVolume(0, value);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
