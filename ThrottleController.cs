using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000214 RID: 532
[Token(Token = "0x20001B0")]
public abstract class ThrottleController : MonoBehaviour
{
	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00005658 File Offset: 0x00003858
	// (set) Token: 0x06000B1F RID: 2847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001DB")]
	public virtual ThrottleID CurrentThrottleID
	{
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x205E190", Offset = "0x205E291", VA = "0x205E190", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B250", Offset = "0x19B351")]
		get
		{
			return ThrottleID.A;
		}
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x205E1A0", Offset = "0x205E2A1", VA = "0x205E1A0", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B260", Offset = "0x19B361")]
		protected set
		{
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00005670 File Offset: 0x00003870
	[Token(Token = "0x170001DC")]
	public virtual bool IsPlaying
	{
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x205E1B0", Offset = "0x205E2B1", VA = "0x205E1B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00005688 File Offset: 0x00003888
	// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001DD")]
	public float Elapsed
	{
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x205E1E0", Offset = "0x205E2E1", VA = "0x205E1E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B270", Offset = "0x19B371")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x205E1F0", Offset = "0x205E2F1", VA = "0x205E1F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B280", Offset = "0x19B381")]
		protected set
		{
		}
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x000056A0 File Offset: 0x000038A0
	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x205E200", Offset = "0x205E301", VA = "0x205E200", Slot = "7")]
	public virtual bool CanPlay()
	{
		return default(bool);
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D4")]
	[Address(RVA = "0x205E210", Offset = "0x205E311", VA = "0x205E210", Slot = "8")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x000056B8 File Offset: 0x000038B8
	[Token(Token = "0x60009D5")]
	[Address(RVA = "0x205E260", Offset = "0x205E361", VA = "0x205E260", Slot = "9")]
	public virtual bool DoPlay(ThrottleID throttleID)
	{
		return default(bool);
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x000056D0 File Offset: 0x000038D0
	[Token(Token = "0x60009D6")]
	[Address(RVA = "0x205E2B0", Offset = "0x205E3B1", VA = "0x205E2B0", Slot = "10")]
	public virtual bool DoStop()
	{
		return default(bool);
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D7")]
	[Address(RVA = "0x205E2E0", Offset = "0x205E3E1", VA = "0x205E2E0", Slot = "11")]
	public virtual void DoStop(ThrottleID throttleID)
	{
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x205E330", Offset = "0x205E431", VA = "0x205E330")]
	protected ThrottleController()
	{
	}

	// Token: 0x040006D7 RID: 1751
	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D430", Offset = "0x15D531")]
	private ThrottleID <CurrentThrottleID>k__BackingField;

	// Token: 0x040006D8 RID: 1752
	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D440", Offset = "0x15D541")]
	private float <Elapsed>k__BackingField;
}
