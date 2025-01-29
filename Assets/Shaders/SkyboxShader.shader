Shader "Unlit/SkyboxShaderURP"
{
    Properties
    {
        _Cubemap("Cubemap", Cube) = "" {}
        _Rotation("Rotation", Float) = 0.0
        _Exposure("Exposure", Float) = 1.0
    }
    SubShader
    {
        Tags { "Queue"="Background" "RenderType"="Background" "RenderPipeline"="UniversalRenderPipeline" }
        LOD 100

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            TEXTURECUBE(_Cubemap);
            SAMPLER(sampler_linear_clamp);
            float _Rotation;
            float _Exposure;

            struct Attributes
            {
                float4 positionOS : POSITION;
            };

            struct Varyings
            {
                float4 positionHCS : SV_POSITION;
                float3 worldPos : TEXCOORD0;
            };

            Varyings vert(Attributes IN)
            {
                Varyings OUT;
                VertexPositionInputs vertexInput = GetVertexPositionInputs(IN.positionOS.xyz);
                OUT.positionHCS = vertexInput.positionCS; 
                OUT.worldPos = vertexInput.positionWS; 
                return OUT;
            }

            half4 frag(Varyings IN) : SV_Target
            {
                float3 dir = normalize(IN.worldPos);

                // Correct X-axis rotation for vertical movement
                float2 sincosTheta;
                sincos(radians(_Rotation), sincosTheta.x, sincosTheta.y);
                float3 rotatedDir = float3(
                    dir.x,
                    dir.y * sincosTheta.y - dir.z * sincosTheta.x, // Rotate vertically
                    dir.y * sincosTheta.x + dir.z * sincosTheta.y
                );

                half4 color = SAMPLE_TEXTURECUBE(_Cubemap, sampler_linear_clamp, rotatedDir);
                color.rgb *= _Exposure; // Apply exposure
                return color;
            }
            ENDHLSL
        }
    }
}
