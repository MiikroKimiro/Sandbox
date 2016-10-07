using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class menuCamera : MonoBehaviour {

    public float amplitude = 200f;
    public int octaves = 256;

    int currentTime = 0;

    // Use this for initialization
    void Start () {
        VignetteAndChromaticAberration VaCA = GetComponent<VignetteAndChromaticAberration>();
        VaCA.intensity = .25f;
        VaCA.blur = 2.5f;
        VaCA.chromaticAberration = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<VignetteAndChromaticAberration>().chromaticAberration = Mathf.Sin(Time.time * .5f) * 4f;
        if (currentTime > octaves)
        {

            currentTime = 0;
            GetComponent<VignetteAndChromaticAberration>().chromaticAberration = Random.Range(-amplitude, amplitude);
        }
        currentTime++;
    }

}