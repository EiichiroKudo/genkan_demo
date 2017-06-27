using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
    [ExecuteInEditMode]
    [RequireComponent (typeof(Camera))]
    [AddComponentMenu ("Image Effects/Other/Screen Overlay")]
    public class ScreenOverlaySnow : PostEffectsBase
	{
	    public enum OverlayBlendMode
		{
            Additive = 0,
            ScreenBlend = 1,
            Multiply = 2,
            Overlay = 3,
            AlphaBlend = 4,
        }

        public OverlayBlendMode blendMode = OverlayBlendMode.Overlay;
        public float intensity = 0f;
        public Texture texture = null;

        public Shader overlayShader = null;
        private Material overlayMaterial = null;

        int num = 0;


        public override bool CheckResources ()
		{
            CheckSupport (false);

            overlayMaterial = CheckShaderAndCreateMaterial (overlayShader, overlayMaterial);

            if	(!isSupported)
                ReportAutoDisable ();
            return isSupported;
        }

        void OnRenderImage (RenderTexture source, RenderTexture destination)
		{
            if (CheckResources() == false)
			{
                Graphics.Blit (source, destination);
                return;
            }

            Vector4 UV_Transform = new  Vector4(1, 0, 0, 1);

			#if UNITY_WP8
	    	// WP8 has no OS support for rotating screen with device orientation,
	    	// so we do those transformations ourselves.
			if (Screen.orientation == ScreenOrientation.LandscapeLeft) {
				UV_Transform = new Vector4(0, -1, 1, 0);
			}
			if (Screen.orientation == ScreenOrientation.LandscapeRight) {
				UV_Transform = new Vector4(0, 1, -1, 0);
			}
			if (Screen.orientation == ScreenOrientation.PortraitUpsideDown) {
				UV_Transform = new Vector4(-1, 0, 0, -1);
			}
			#endif

            overlayMaterial.SetVector("_UV_Transform", UV_Transform);
            overlayMaterial.SetFloat ("_Intensity", intensity);
            overlayMaterial.SetTexture ("_Overlay", texture);
            Graphics.Blit (source, destination, overlayMaterial, (int) blendMode);
        }

        void Update(){

            if(Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha2)){
                num = 1;
            }

            if(Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha1)){
                num = 0;
            }

            if(Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha3)){
                num = 1;
            }

            if(Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha4)){
                num = 0;
            }

            if(Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha5)){
                num = 0;
            }

            if(Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha6)){
                num = 0;
            }

            if(num == 0 && intensity > 0f){   
                intensity -= 0.01f;
            }

            if(num == 1 && intensity < 1f){
                intensity += 0.01f;
            }

            
        }
    }
}
