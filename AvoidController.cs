using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EC RID: 492
[Token(Token = "0x200018A")]
public class AvoidController : MonoBehaviour
{
	// Token: 0x170001CD RID: 461
	// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00005010 File Offset: 0x00003210
	// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B0")]
	public float Elapsed
	{
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x22996B0", Offset = "0x22997B1", VA = "0x22996B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AF80", Offset = "0x19B081")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x22996C0", Offset = "0x22997C1", VA = "0x22996C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AF90", Offset = "0x19B091")]
		protected set
		{
		}
	}

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00005028 File Offset: 0x00003228
	// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B1")]
	public bool IsPlaying
	{
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x22996D0", Offset = "0x22997D1", VA = "0x22996D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AFA0", Offset = "0x19B0A1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x22996E0", Offset = "0x22997E1", VA = "0x22996E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AFB0", Offset = "0x19B0B1")]
		protected set
		{
		}
	}

	// Token: 0x170001CF RID: 463
	// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00005040 File Offset: 0x00003240
	// (set) Token: 0x060009FA RID: 2554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B2")]
	public bool IsAnimation
	{
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x22996F0", Offset = "0x22997F1", VA = "0x22996F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AFC0", Offset = "0x19B0C1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2299700", Offset = "0x2299801", VA = "0x2299700")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AFD0", Offset = "0x19B0D1")]
		protected set
		{
		}
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00005058 File Offset: 0x00003258
	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x2299710", Offset = "0x2299811", VA = "0x2299710", Slot = "4")]
	public virtual bool CanPlay()
	{
		return default(bool);
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00005070 File Offset: 0x00003270
	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x2299720", Offset = "0x2299821", VA = "0x2299720", Slot = "5")]
	public virtual bool DoPlay()
	{
		return default(bool);
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00005088 File Offset: 0x00003288
	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x2299740", Offset = "0x2299841", VA = "0x2299740", Slot = "6")]
	public virtual bool DoStop()
	{
		return default(bool);
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x2299750", Offset = "0x2299851", VA = "0x2299750", Slot = "7")]
	public virtual void DoCancel()
	{
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x2299760", Offset = "0x2299861", VA = "0x2299760", Slot = "8")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x22997A0", Offset = "0x22998A1", VA = "0x22997A0")]
	public AvoidController()
	{
	}

	// Token: 0x04000659 RID: 1625
	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CFF0", Offset = "0x15D0F1")]
	private float <Elapsed>k__BackingField;

	// Token: 0x0400065A RID: 1626
	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D000", Offset = "0x15D101")]
	private bool <IsPlaying>k__BackingField;

	// Token: 0x0400065B RID: 1627
	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x1D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D010", Offset = "0x15D111")]
	private bool <IsAnimation>k__BackingField;
}
