using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000657 RID: 1623
[Token(Token = "0x200048C")]
public class ScreenFadeManager : SingletonMonoBehaviour<ScreenFadeManager>
{
	// Token: 0x1700066F RID: 1647
	// (get) Token: 0x06002863 RID: 10339 RVA: 0x0000FF78 File Offset: 0x0000E178
	// (set) Token: 0x06002862 RID: 10338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000525")]
	public static bool IsPlaying
	{
		[Token(Token = "0x6002229")]
		[Address(RVA = "0x21DD440", Offset = "0x21DD541", VA = "0x21DD440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1FC0", Offset = "0x1A20C1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002228")]
		[Address(RVA = "0x21DD3D0", Offset = "0x21DD4D1", VA = "0x21DD3D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1FB0", Offset = "0x1A20B1")]
		private set
		{
		}
	}

	// Token: 0x17000670 RID: 1648
	// (get) Token: 0x06002865 RID: 10341 RVA: 0x0000FF90 File Offset: 0x0000E190
	// (set) Token: 0x06002864 RID: 10340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000526")]
	public static ScreenFadeManager.State FadeState
	{
		[Token(Token = "0x600222B")]
		[Address(RVA = "0x21DD520", Offset = "0x21DD621", VA = "0x21DD520")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1FE0", Offset = "0x1A20E1")]
		get
		{
			return ScreenFadeManager.State.None;
		}
		[Token(Token = "0x600222A")]
		[Address(RVA = "0x21DD4B0", Offset = "0x21DD5B1", VA = "0x21DD4B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1FD0", Offset = "0x1A20D1")]
		private set
		{
		}
	}

	// Token: 0x17000671 RID: 1649
	// (get) Token: 0x06002866 RID: 10342 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
	[Token(Token = "0x17000527")]
	public static bool IsReady
	{
		[Token(Token = "0x600222C")]
		[Address(RVA = "0x21DD590", Offset = "0x21DD691", VA = "0x21DD590")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002867 RID: 10343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600222D")]
	[Address(RVA = "0x21DD680", Offset = "0x21DD781", VA = "0x21DD680", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06002868 RID: 10344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600222E")]
	[Address(RVA = "0x21DD790", Offset = "0x21DD891", VA = "0x21DD790")]
	private void Start()
	{
	}

	// Token: 0x06002869 RID: 10345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600222F")]
	[Address(RVA = "0x21DD8B0", Offset = "0x21DD9B1", VA = "0x21DD8B0")]
	public static Coroutine FadeOut(float time = 0.5f, [Optional] Action action, ScreenFadeManager.ColorType colorType = ScreenFadeManager.ColorType.Black, bool onLoad = true)
	{
		return null;
	}

	// Token: 0x0600286A RID: 10346 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002230")]
	[Address(RVA = "0x21DDB40", Offset = "0x21DDC41", VA = "0x21DDB40")]
	public static Coroutine FadeIn(float time = 0.5f, [Optional] Action action, ScreenFadeManager.ColorType colorType = ScreenFadeManager.ColorType.Black, bool onLoad = true)
	{
		return null;
	}

	// Token: 0x0600286B RID: 10347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002231")]
	[Address(RVA = "0x21DD800", Offset = "0x21DD901", VA = "0x21DD800")]
	public static void LoadLoadingAnim()
	{
	}

	// Token: 0x0600286C RID: 10348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002232")]
	[Address(RVA = "0x21DDDD0", Offset = "0x21DDED1", VA = "0x21DDDD0")]
	public ScreenFadeManager()
	{
	}

	// Token: 0x04006FC4 RID: 28612
	[Token(Token = "0x400683C")]
	private const float DefaultFadeDuration = 0.5f;

	// Token: 0x04006FC5 RID: 28613
	[Token(Token = "0x400683D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Fade m_fade;

	// Token: 0x04006FC6 RID: 28614
	[Token(Token = "0x400683E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1686E0", Offset = "0x1687E1")]
	private static bool <IsPlaying>k__BackingField;

	// Token: 0x04006FC7 RID: 28615
	[Token(Token = "0x400683F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1686F0", Offset = "0x1687F1")]
	private static ScreenFadeManager.State <FadeState>k__BackingField;

	// Token: 0x02000658 RID: 1624
	[Token(Token = "0x2001154")]
	public enum ColorType
	{
		// Token: 0x04006FC9 RID: 28617
		[Token(Token = "0x40193FC")]
		White,
		// Token: 0x04006FCA RID: 28618
		[Token(Token = "0x40193FD")]
		Black
	}

	// Token: 0x02000659 RID: 1625
	[Token(Token = "0x2001155")]
	public enum State
	{
		// Token: 0x04006FCC RID: 28620
		[Token(Token = "0x40193FF")]
		None,
		// Token: 0x04006FCD RID: 28621
		[Token(Token = "0x4019400")]
		FadeOut,
		// Token: 0x04006FCE RID: 28622
		[Token(Token = "0x4019401")]
		FadeIn
	}

	// Token: 0x0200065A RID: 1626
	[Token(Token = "0x2001156")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1581C0", Offset = "0x1582C1")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x0600286E RID: 10350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007125")]
		[Address(RVA = "0x21DDB30", Offset = "0x21DDC31", VA = "0x21DDB30")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007126")]
		[Address(RVA = "0x21DDE30", Offset = "0x21DDF31", VA = "0x21DDE30")]
		internal void <FadeOut>b__0()
		{
		}

		// Token: 0x04006FCF RID: 28623
		[Token(Token = "0x4019402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action action;
	}

	// Token: 0x0200065B RID: 1627
	[Token(Token = "0x2001157")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1581D0", Offset = "0x1582D1")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x06002870 RID: 10352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007127")]
		[Address(RVA = "0x21DDDC0", Offset = "0x21DDEC1", VA = "0x21DDDC0")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007128")]
		[Address(RVA = "0x21DDF30", Offset = "0x21DE031", VA = "0x21DDF30")]
		internal void <FadeIn>b__0()
		{
		}

		// Token: 0x04006FD0 RID: 28624
		[Token(Token = "0x4019403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action action;
	}
}
