Shader "Graph/Point Surface" {

    Properties {
        _Smoothness ("Smoothness", Range(0,1)) = 0.5
    }
    
    SubShader {
        CGPROGRAM
        #pragma surface ConfigureSurface Standard fullforwardshadows
        #pragma target 3.0

        struct Input {
            float3 worldPos;
        };
        float _Smoothness;
        void ConfigureSurface (Input input, inout SurfaceOutputStandard surface) {
            surface.Albedo.rg = input.worldPos.xy;
            surface.Smoothness = _Smoothness;
        }
        ENDCG


    }
}