Shader "EAC VFX/FadeAndScrollUV (Emissive)"
{
    Properties
    {
        _Color ("Base Color", Color) = (1, 1, 1, 1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        [Gamma] _Metallic ("Metallic", Range(0,1)) = 0.0

        _EmissionMap("Emission Map", 2D) = "black" {}

        _FadeMask ("FadeMask (R)", 2D) = "white" {}
        _ScrollRate ("Scroll Rate", Vector) = (0, 1, 0, 0)
    }
    SubShader
    {
        Tags { "Queue"="Transparent" "RenderType"="Transparent" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows alpha:blend

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;
        sampler2D _FadeMask;
        sampler2D _EmissionMap;

        struct Input
        {
            float2 uv_MainTex;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;
        float4 _ScrollRate;

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            float2 uv = _Time.y * _ScrollRate.xy + IN.uv_MainTex;

            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D(_MainTex, uv) * _Color;
            o.Albedo = c.rgb;

            fixed4 f = tex2D(_FadeMask, IN.uv_MainTex);
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;

            fixed4 e = tex2D(_EmissionMap, IN.uv_MainTex);
            o.Alpha = c.a * f.r;
            o.Emission = e.a * f.r;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
