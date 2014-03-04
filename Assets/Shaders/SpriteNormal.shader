Shader "CustomSprite/Sprite-Normal"

{

    Properties

    {

        [PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}

        _BumpMap ("Normalmap", 2D) = "bump" {}

        _Color ("Tint", Color) = (1,1,1,1)

    }

 

    SubShader

    {

        Tags

        { 

            "Queue"="Transparent" 

            "IgnoreProjector"="True" 

            "RenderType"="Transparent" 

            "PreviewType"="Plane"

            //"CanUseSpriteAtlas"="True"

        }

 

        Cull Off

        Lighting Off

        ZWrite Off

        Fog { Mode Off }

        Blend SrcAlpha OneMinusSrcAlpha

 

        CGPROGRAM

        #pragma surface surf Lambert vertex:vert

 

        sampler2D _MainTex;

        sampler2D _BumpMap;

        fixed4 _Color;

 

        struct Input

        {

            float2 uv_MainTex;

            float2 uv_BumpMap;

            fixed4 color;

        };

        

        void vert (inout appdata_full v, out Input o)

        {

            v.normal = float3(0,0,-1);

            v.tangent = float4(1, 0, 0, -1);

            

            UNITY_INITIALIZE_OUTPUT(Input, o);

            o.color = _Color;

        }

 

        void surf (Input IN, inout SurfaceOutput o)

        {

            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);

            o.Albedo = c.rgb;

            o.Alpha = c.a;

            o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));

        }

        ENDCG

    }

 

Fallback "Transparent/VertexLit"

}