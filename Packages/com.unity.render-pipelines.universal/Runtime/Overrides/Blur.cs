using System;

namespace UnityEngine.Rendering.Universal
{
    /// <summary>
    /// A volume component that holds settings for the Blur effect.
    /// </summary>
    [Serializable, VolumeComponentMenu("Post-processing/Blur")]
    [SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
    [URPHelpURL("post-processing-blur")]
    public sealed class Blur : VolumeComponent, IPostProcessComponent
    {
        /// <summary>
        /// Controls the strength of the blur effect.
        /// </summary>
        [Tooltip("Use the slider to set the strength of the Vignette effect.")]
        public ClampedFloatParameter blurAmount = new ClampedFloatParameter(0f, 0f, 1f);


        /// <inheritdoc/>
        public bool IsActive() => blurAmount.value > 0f;

        /// <inheritdoc/>
        [Obsolete("Unused #from(2023.1)", false)]
        public bool IsTileCompatible() => true;
    }
}
