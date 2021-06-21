using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000655 RID: 1621
[Token(Token = "0x200048A")]
[Attribute(Name = "RequireComponent", RVA = "0x146210", Offset = "0x146311")]
[Attribute(Name = "RequireComponent", RVA = "0x146210", Offset = "0x146311")]
public class FadeUI : MonoBehaviour, IFade
{
	// Token: 0x1700066B RID: 1643
	// (get) Token: 0x06002856 RID: 10326 RVA: 0x0000FF48 File Offset: 0x0000E148
	// (set) Token: 0x06002857 RID: 10327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000521")]
	public float Range
	{
		[Token(Token = "0x600221C")]
		[Address(RVA = "0x21C7C10", Offset = "0x21C7D11", VA = "0x21C7C10", Slot = "4")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600221D")]
		[Address(RVA = "0x21C7C20", Offset = "0x21C7D21", VA = "0x21C7C20", Slot = "5")]
		set
		{
		}
	}

	// Token: 0x1700066C RID: 1644
	// (get) Token: 0x06002858 RID: 10328 RVA: 0x0000FF60 File Offset: 0x0000E160
	// (set) Token: 0x06002859 RID: 10329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000522")]
	public Color fadeColor
	{
		[Token(Token = "0x600221E")]
		[Address(RVA = "0x21C7D20", Offset = "0x21C7E21", VA = "0x21C7D20", Slot = "6")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600221F")]
		[Address(RVA = "0x21C7D30", Offset = "0x21C7E31", VA = "0x21C7D30", Slot = "7")]
		set
		{
		}
	}

	// Token: 0x0600285A RID: 10330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002220")]
	[Address(RVA = "0x21C7D40", Offset = "0x21C7E41", VA = "0x21C7D40")]
	private void Start()
	{
	}

	// Token: 0x0600285B RID: 10331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002221")]
	[Address(RVA = "0x21C7D50", Offset = "0x21C7E51", VA = "0x21C7D50")]
	public void UpdateMaskTexture(Texture texture)
	{
	}

	// Token: 0x0600285C RID: 10332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002222")]
	[Address(RVA = "0x21C7C30", Offset = "0x21C7D31", VA = "0x21C7C30")]
	private void UpdateMaskCutout(float range)
	{
	}

	// Token: 0x0600285D RID: 10333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002223")]
	[Address(RVA = "0x21C7DE0", Offset = "0x21C7EE1", VA = "0x21C7DE0")]
	public FadeUI()
	{
	}

	// Token: 0x04006FBF RID: 28607
	[Token(Token = "0x4006837")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Material mat;

	// Token: 0x04006FC0 RID: 28608
	[Token(Token = "0x4006838")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RenderTexture rt;

	// Token: 0x04006FC1 RID: 28609
	[Token(Token = "0x4006839")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Texture texture;

	// Token: 0x04006FC2 RID: 28610
	[Token(Token = "0x400683A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Color color;

	// Token: 0x04006FC3 RID: 28611
	[Token(Token = "0x400683B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x1686A0", Offset = "0x1687A1")]
	private float cutoutRange;
}
