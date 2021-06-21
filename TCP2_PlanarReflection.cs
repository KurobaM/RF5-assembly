using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B5B RID: 2907
[Token(Token = "0x2000794")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x1473C0", Offset = "0x1474C1")]
public class TCP2_PlanarReflection : MonoBehaviour
{
	// Token: 0x06004AC3 RID: 19139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EA2")]
	[Address(RVA = "0x1FBEBC0", Offset = "0x1FBECC1", VA = "0x1FBEBC0")]
	public void OnWillRenderObject()
	{
	}

	// Token: 0x06004AC4 RID: 19140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EA3")]
	[Address(RVA = "0x1FBFFE0", Offset = "0x1FC00E1", VA = "0x1FBFFE0")]
	private void OnDisable()
	{
	}

	// Token: 0x06004AC5 RID: 19141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EA4")]
	[Address(RVA = "0x1FBF830", Offset = "0x1FBF931", VA = "0x1FBF830")]
	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	// Token: 0x06004AC6 RID: 19142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EA5")]
	[Address(RVA = "0x1FBF200", Offset = "0x1FBF301", VA = "0x1FBF200")]
	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera)
	{
	}

	// Token: 0x06004AC7 RID: 19143 RVA: 0x00017DF0 File Offset: 0x00015FF0
	[Token(Token = "0x6003EA6")]
	[Address(RVA = "0x1FC0340", Offset = "0x1FC0441", VA = "0x1FC0340")]
	private static float sgn(float a)
	{
		return 0f;
	}

	// Token: 0x06004AC8 RID: 19144 RVA: 0x00017E08 File Offset: 0x00016008
	[Token(Token = "0x6003EA7")]
	[Address(RVA = "0x1FBFDE0", Offset = "0x1FBFEE1", VA = "0x1FBFDE0")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	// Token: 0x06004AC9 RID: 19145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EA8")]
	[Address(RVA = "0x1FBFB30", Offset = "0x1FBFC31", VA = "0x1FBFB30")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	// Token: 0x06004ACA RID: 19146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EA9")]
	[Address(RVA = "0x1FC0360", Offset = "0x1FC0461", VA = "0x1FC0360")]
	public TCP2_PlanarReflection()
	{
	}

	// Token: 0x0400AB51 RID: 43857
	[Token(Token = "0x400814A")]
	[FieldOffset(Offset = "0x18")]
	public bool m_DisablePixelLights;

	// Token: 0x0400AB52 RID: 43858
	[Token(Token = "0x400814B")]
	[FieldOffset(Offset = "0x1C")]
	public int m_TextureSize;

	// Token: 0x0400AB53 RID: 43859
	[Token(Token = "0x400814C")]
	[FieldOffset(Offset = "0x20")]
	public float m_ClipPlaneOffset;

	// Token: 0x0400AB54 RID: 43860
	[Token(Token = "0x400814D")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask m_ReflectLayers;

	// Token: 0x0400AB55 RID: 43861
	[Token(Token = "0x400814E")]
	[FieldOffset(Offset = "0x28")]
	private Hashtable m_ReflectionCameras;

	// Token: 0x0400AB56 RID: 43862
	[Token(Token = "0x400814F")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture m_ReflectionTexture;

	// Token: 0x0400AB57 RID: 43863
	[Token(Token = "0x4008150")]
	[FieldOffset(Offset = "0x38")]
	private int m_OldReflectionTextureSize;

	// Token: 0x0400AB58 RID: 43864
	[Token(Token = "0x4008151")]
	[FieldOffset(Offset = "0x0")]
	private static bool s_InsideRendering;
}
