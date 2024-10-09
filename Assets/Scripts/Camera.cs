using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ScreenCameraShader : MonoBehaviour
{
    //public Shader awesomeShader = null;
    public Material m_renderMaterial;
    public Shader awesomeShader = null;
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, m_renderMaterial); //Copies source texture into destination render texture with a shader,
                                                              //this is mostly used for implementing post-processing effects
    }
}
