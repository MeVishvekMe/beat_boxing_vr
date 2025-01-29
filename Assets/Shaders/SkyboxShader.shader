Shader "Unlit/SkyboxShaderURP"
{
    Properties
    {
        _Cubemap("Cubemap", Cube) = "" {}
        _Rotation("Rotation", Float) = 0.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" "RenderPipeline"="UniversalRenderPipeline" }
        LOD 100

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            TEXTURECUBE(_Cubemap);
            SAMPLER(sampler_Cubemap);
            float _Rotation;

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
                OUT.positionHCS = TransformObjectToHClip(IN.positionOS.xyz);
                OUT.worldPos = TransformObjectToWorld(IN.positionOS.xyz);
                return OUT;
            }

            half4 frag(Varyings IN) : SV_Target
            {
                float3 dir = normalize(IN.worldPos);
                float sinTheta, cosTheta;
                sincos(_Rotation, sinTheta, cosTheta);
                float3 rotatedDir = float3(
                    dir.x,
                    dir.y * cosTheta - dir.z * sinTheta,
                    dir.y * sinTheta + dir.z * cosTheta
                );
                return SAMPLE_TEXTURECUBE(_Cubemap, sampler_Cubemap, rotatedDir);
            }
            ENDHLSL
        }
    }
}