using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200094D RID: 2381
[Token(Token = "0x200063C")]
public class UIFadeOnOffAnimate : MonoBehaviour
{
	// Token: 0x170008E2 RID: 2274
	// (get) Token: 0x06003F1A RID: 16154 RVA: 0x00015780 File Offset: 0x00013980
	// (set) Token: 0x06003F1B RID: 16155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000719")]
	public bool isOpen
	{
		[Token(Token = "0x6003475")]
		[Address(RVA = "0x2010570", Offset = "0x2010671", VA = "0x2010570")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7080", Offset = "0x1A7181")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003476")]
		[Address(RVA = "0x2010580", Offset = "0x2010681", VA = "0x2010580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7090", Offset = "0x1A7191")]
		private set
		{
		}
	}

	// Token: 0x06003F1C RID: 16156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003477")]
	[Address(RVA = "0x2010590", Offset = "0x2010691", VA = "0x2010590")]
	private void DoInit()
	{
	}

	// Token: 0x06003F1D RID: 16157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003478")]
	[Address(RVA = "0x2010770", Offset = "0x2010871", VA = "0x2010770")]
	private void Start()
	{
	}

	// Token: 0x06003F1E RID: 16158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003479")]
	[Address(RVA = "0x2010780", Offset = "0x2010881", VA = "0x2010780")]
	public void DoOpen()
	{
	}

	// Token: 0x06003F1F RID: 16159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600347A")]
	[Address(RVA = "0x20107D0", Offset = "0x20108D1", VA = "0x20107D0")]
	public void DoClose()
	{
	}

	// Token: 0x06003F20 RID: 16160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600347B")]
	[Address(RVA = "0x2010810", Offset = "0x2010911", VA = "0x2010810")]
	private void SetAllAlpha(float a)
	{
	}

	// Token: 0x06003F21 RID: 16161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600347C")]
	[Address(RVA = "0x2010990", Offset = "0x2010A91", VA = "0x2010990")]
	private void Update()
	{
	}

	// Token: 0x06003F22 RID: 16162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600347D")]
	[Address(RVA = "0x2010A70", Offset = "0x2010B71", VA = "0x2010A70")]
	public UIFadeOnOffAnimate()
	{
	}

	// Token: 0x0400809E RID: 32926
	[Token(Token = "0x40073D3")]
	[FieldOffset(Offset = "0x18")]
	private bool Inited;

	// Token: 0x0400809F RID: 32927
	[Token(Token = "0x40073D4")]
	[FieldOffset(Offset = "0x20")]
	private List<UIFadeOnOffAnimate.ImageGroup> imageGroups;

	// Token: 0x040080A0 RID: 32928
	[Token(Token = "0x40073D5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float FadeTime;

	// Token: 0x040080A1 RID: 32929
	[Token(Token = "0x40073D6")]
	[FieldOffset(Offset = "0x2C")]
	private float nowTime;

	// Token: 0x040080A2 RID: 32930
	[Token(Token = "0x40073D7")]
	[FieldOffset(Offset = "0x30")]
	private float fromAlpha;

	// Token: 0x040080A3 RID: 32931
	[Token(Token = "0x40073D8")]
	[FieldOffset(Offset = "0x34")]
	private float toAlpha;

	// Token: 0x040080A4 RID: 32932
	[Token(Token = "0x40073D9")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F6D0", Offset = "0x16F7D1")]
	private bool <isOpen>k__BackingField;

	// Token: 0x0200094E RID: 2382
	[Token(Token = "0x2001293")]
	private class ImageGroup
	{
		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06003F24 RID: 16164 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003F23 RID: 16163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D86")]
		public Image Image
		{
			[Token(Token = "0x600758A")]
			[Address(RVA = "0x2010B10", Offset = "0x2010C11", VA = "0x2010B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007589")]
			[Address(RVA = "0x2010A80", Offset = "0x2010B81", VA = "0x2010A80")]
			set
			{
			}
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758B")]
		[Address(RVA = "0x2010950", Offset = "0x2010A51", VA = "0x2010950")]
		public void SetAlpha(float alpha)
		{
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758C")]
		[Address(RVA = "0x20106E0", Offset = "0x20107E1", VA = "0x20106E0")]
		public ImageGroup(Image imgObj)
		{
		}

		// Token: 0x040080A5 RID: 32933
		[Token(Token = "0x401992E")]
		[FieldOffset(Offset = "0x10")]
		private Image _Image;

		// Token: 0x040080A6 RID: 32934
		[Token(Token = "0x401992F")]
		[FieldOffset(Offset = "0x18")]
		public Color basecolor;

		// Token: 0x040080A7 RID: 32935
		[Token(Token = "0x4019930")]
		[FieldOffset(Offset = "0x28")]
		public Color color;

		// Token: 0x040080A8 RID: 32936
		[Token(Token = "0x4019931")]
		[FieldOffset(Offset = "0x38")]
		public float AlphaMax;
	}
}
