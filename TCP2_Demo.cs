using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B54 RID: 2900
[Token(Token = "0x200078E")]
public class TCP2_Demo : MonoBehaviour
{
	// Token: 0x06004A89 RID: 19081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E69")]
	[Address(RVA = "0x1FB5AB0", Offset = "0x1FB5BB1", VA = "0x1FB5AB0")]
	private void Awake()
	{
	}

	// Token: 0x06004A8A RID: 19082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E6A")]
	[Address(RVA = "0x1FB6170", Offset = "0x1FB6271", VA = "0x1FB6170")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004A8B RID: 19083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E6B")]
	[Address(RVA = "0x1FB6300", Offset = "0x1FB6401", VA = "0x1FB6300")]
	private void OnGUI()
	{
	}

	// Token: 0x06004A8C RID: 19084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E6C")]
	[Address(RVA = "0x1FB8970", Offset = "0x1FB8A71", VA = "0x1FB8970")]
	private void UnityDiffuseShader()
	{
	}

	// Token: 0x06004A8D RID: 19085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E6D")]
	[Address(RVA = "0x1FB5B50", Offset = "0x1FB5C51", VA = "0x1FB5B50")]
	private void UpdateShader()
	{
	}

	// Token: 0x06004A8E RID: 19086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E6E")]
	[Address(RVA = "0x1FB86C0", Offset = "0x1FB87C1", VA = "0x1FB86C0")]
	private void RimOutlineColor()
	{
	}

	// Token: 0x06004A8F RID: 19087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E6F")]
	[Address(RVA = "0x1FB61A0", Offset = "0x1FB62A1", VA = "0x1FB61A0")]
	private void RestoreRimColors()
	{
	}

	// Token: 0x06004A90 RID: 19088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E70")]
	[Address(RVA = "0x1FB8A80", Offset = "0x1FB8B81", VA = "0x1FB8A80")]
	private void ToggleKeyword(Material m, bool enabled, string keyword)
	{
	}

	// Token: 0x06004A91 RID: 19089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E71")]
	[Address(RVA = "0x1FB8780", Offset = "0x1FB8881", VA = "0x1FB8780")]
	private void PrevRamp()
	{
	}

	// Token: 0x06004A92 RID: 19090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E72")]
	[Address(RVA = "0x1FB8880", Offset = "0x1FB8981", VA = "0x1FB8880")]
	private void NextRamp()
	{
	}

	// Token: 0x06004A93 RID: 19091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E73")]
	[Address(RVA = "0x1FB8EE0", Offset = "0x1FB8FE1", VA = "0x1FB8EE0")]
	public TCP2_Demo()
	{
	}

	// Token: 0x0400AAE1 RID: 43745
	[Token(Token = "0x40080DD")]
	[FieldOffset(Offset = "0x18")]
	public Material[] AffectedMaterials;

	// Token: 0x0400AAE2 RID: 43746
	[Token(Token = "0x40080DE")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D[] RampTextures;

	// Token: 0x0400AAE3 RID: 43747
	[Token(Token = "0x40080DF")]
	[FieldOffset(Offset = "0x28")]
	public GUISkin GuiSkin;

	// Token: 0x0400AAE4 RID: 43748
	[Token(Token = "0x40080E0")]
	[FieldOffset(Offset = "0x30")]
	public Light DirLight;

	// Token: 0x0400AAE5 RID: 43749
	[Token(Token = "0x40080E1")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Robot;

	// Token: 0x0400AAE6 RID: 43750
	[Token(Token = "0x40080E2")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Ethan;

	// Token: 0x0400AAE7 RID: 43751
	[Token(Token = "0x40080E3")]
	[FieldOffset(Offset = "0x48")]
	private bool mUnityShader;

	// Token: 0x0400AAE8 RID: 43752
	[Token(Token = "0x40080E4")]
	[FieldOffset(Offset = "0x49")]
	private bool mShaderSpecular;

	// Token: 0x0400AAE9 RID: 43753
	[Token(Token = "0x40080E5")]
	[FieldOffset(Offset = "0x4A")]
	private bool mShaderBump;

	// Token: 0x0400AAEA RID: 43754
	[Token(Token = "0x40080E6")]
	[FieldOffset(Offset = "0x4B")]
	private bool mShaderReflection;

	// Token: 0x0400AAEB RID: 43755
	[Token(Token = "0x40080E7")]
	[FieldOffset(Offset = "0x4C")]
	private bool mShaderRim;

	// Token: 0x0400AAEC RID: 43756
	[Token(Token = "0x40080E8")]
	[FieldOffset(Offset = "0x4D")]
	private bool mShaderRimOutline;

	// Token: 0x0400AAED RID: 43757
	[Token(Token = "0x40080E9")]
	[FieldOffset(Offset = "0x4E")]
	private bool mShaderOutline;

	// Token: 0x0400AAEE RID: 43758
	[Token(Token = "0x40080EA")]
	[FieldOffset(Offset = "0x50")]
	private float mRimMin;

	// Token: 0x0400AAEF RID: 43759
	[Token(Token = "0x40080EB")]
	[FieldOffset(Offset = "0x54")]
	private float mRimMax;

	// Token: 0x0400AAF0 RID: 43760
	[Token(Token = "0x40080EC")]
	[FieldOffset(Offset = "0x58")]
	private bool mRampTextureFlag;

	// Token: 0x0400AAF1 RID: 43761
	[Token(Token = "0x40080ED")]
	[FieldOffset(Offset = "0x60")]
	private Texture2D mRampTexture;

	// Token: 0x0400AAF2 RID: 43762
	[Token(Token = "0x40080EE")]
	[FieldOffset(Offset = "0x68")]
	private float mRampSmoothing;

	// Token: 0x0400AAF3 RID: 43763
	[Token(Token = "0x40080EF")]
	[FieldOffset(Offset = "0x6C")]
	private float mLightRotationX;

	// Token: 0x0400AAF4 RID: 43764
	[Token(Token = "0x40080F0")]
	[FieldOffset(Offset = "0x70")]
	private float mLightRotationY;

	// Token: 0x0400AAF5 RID: 43765
	[Token(Token = "0x40080F1")]
	[FieldOffset(Offset = "0x74")]
	private bool mViewRobot;

	// Token: 0x0400AAF6 RID: 43766
	[Token(Token = "0x40080F2")]
	[FieldOffset(Offset = "0x75")]
	private bool mRobotOutlineNormals;

	// Token: 0x0400AAF7 RID: 43767
	[Token(Token = "0x40080F3")]
	[FieldOffset(Offset = "0x78")]
	private TCP2_Demo_View DemoView;
}
