using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000654 RID: 1620
[Token(Token = "0x2000489")]
public class FadeImage : Graphic, IFade
{
	// Token: 0x17000669 RID: 1641
	// (get) Token: 0x0600284D RID: 10317 RVA: 0x0000FF18 File Offset: 0x0000E118
	// (set) Token: 0x0600284E RID: 10318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700051F")]
	public float Range
	{
		[Token(Token = "0x6002213")]
		[Address(RVA = "0x21C77B0", Offset = "0x21C78B1", VA = "0x21C77B0", Slot = "50")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6002214")]
		[Address(RVA = "0x21C77C0", Offset = "0x21C78C1", VA = "0x21C77C0", Slot = "51")]
		set
		{
		}
	}

	// Token: 0x1700066A RID: 1642
	// (get) Token: 0x0600284F RID: 10319 RVA: 0x0000FF30 File Offset: 0x0000E130
	// (set) Token: 0x06002850 RID: 10320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000520")]
	public Color fadeColor
	{
		[Token(Token = "0x6002215")]
		[Address(RVA = "0x21C7940", Offset = "0x21C7A41", VA = "0x21C7940", Slot = "52")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6002216")]
		[Address(RVA = "0x21C7950", Offset = "0x21C7A51", VA = "0x21C7950", Slot = "53")]
		set
		{
		}
	}

	// Token: 0x06002851 RID: 10321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002217")]
	[Address(RVA = "0x21C7AA0", Offset = "0x21C7BA1", VA = "0x21C7AA0", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x06002852 RID: 10322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002218")]
	[Address(RVA = "0x21C7880", Offset = "0x21C7981", VA = "0x21C7880")]
	private void UpdateMaskCutout(float range)
	{
	}

	// Token: 0x06002853 RID: 10323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002219")]
	[Address(RVA = "0x21C7AD0", Offset = "0x21C7BD1", VA = "0x21C7AD0")]
	public void UpdateMaskTexture(Texture texture)
	{
	}

	// Token: 0x06002854 RID: 10324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600221A")]
	[Address(RVA = "0x21C7A00", Offset = "0x21C7B01", VA = "0x21C7A00")]
	public void UpdateMaskColor(Color fadecolor)
	{
	}

	// Token: 0x06002855 RID: 10325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600221B")]
	[Address(RVA = "0x21C7BA0", Offset = "0x21C7CA1", VA = "0x21C7BA0")]
	public FadeImage()
	{
	}

	// Token: 0x04006FBC RID: 28604
	[Token(Token = "0x4006834")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Texture maskTexture;

	// Token: 0x04006FBD RID: 28605
	[Token(Token = "0x4006835")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x168620", Offset = "0x168721")]
	private float cutoutRange;

	// Token: 0x04006FBE RID: 28606
	[Token(Token = "0x4006836")]
	[FieldOffset(Offset = "0x9C")]
	private Color m_color;
}
