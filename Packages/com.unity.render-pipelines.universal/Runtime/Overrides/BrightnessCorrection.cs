using System;

namespace UnityEngine.Rendering.Universal
{
    [Serializable, VolumeComponentMenu("Post-processing/BrightnessCorrection")]
    [SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
    public class BrightnessCorrection : VolumeComponent, IPostProcessComponent
    {
        public BoolParameter b_UseBrightnessCorrection =  new(false);
        public ClampedFloatParameter m_Brightness = new ClampedFloatParameter(0f, -90f, 100f);
        public ClampedFloatParameter m_Gamma = new ClampedFloatParameter(1f, 0.5f, 2f);

        public bool IsActive() => b_UseBrightnessCorrection.value;
    }
}

