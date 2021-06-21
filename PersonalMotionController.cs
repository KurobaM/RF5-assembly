using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020D RID: 525
[Token(Token = "0x20001A9")]
public abstract class PersonalMotionController : MonoBehaviour
{
	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x06000AEC RID: 2796 RVA: 0x000055B0 File Offset: 0x000037B0
	// (set) Token: 0x06000AED RID: 2797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D4")]
	public bool IsActivated
	{
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x213D780", Offset = "0x213D881", VA = "0x213D780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B1D0", Offset = "0x19B2D1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x213D790", Offset = "0x213D891", VA = "0x213D790")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B1E0", Offset = "0x19B2E1")]
		protected set
		{
		}
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x06000AEE RID: 2798 RVA: 0x000055C8 File Offset: 0x000037C8
	// (set) Token: 0x06000AEF RID: 2799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D5")]
	public bool IsMotionPlay
	{
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x213D7A0", Offset = "0x213D8A1", VA = "0x213D7A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B1F0", Offset = "0x19B2F1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x213D7B0", Offset = "0x213D8B1", VA = "0x213D7B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B200", Offset = "0x19B301")]
		protected set
		{
		}
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x213D7C0", Offset = "0x213D8C1", VA = "0x213D7C0", Slot = "4")]
	public virtual void Setup()
	{
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x213D7D0", Offset = "0x213D8D1", VA = "0x213D7D0", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x213D7E0", Offset = "0x213D8E1", VA = "0x213D7E0", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x213D7F0", Offset = "0x213D8F1", VA = "0x213D7F0", Slot = "7")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x213D8F0", Offset = "0x213D9F1", VA = "0x213D8F0", Slot = "8")]
	public virtual void SetActivate(bool active)
	{
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x213D950", Offset = "0x213DA51", VA = "0x213D950", Slot = "9")]
	public virtual void DoPlayMotion()
	{
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x213D9A0", Offset = "0x213DAA1", VA = "0x213D9A0", Slot = "10")]
	public virtual void DoStopMotion()
	{
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x213D9B0", Offset = "0x213DAB1", VA = "0x213D9B0", Slot = "11")]
	public virtual void PlayMotion(int no)
	{
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x213D9C0", Offset = "0x213DAC1", VA = "0x213D9C0", Slot = "12")]
	public virtual void OnMotionPlay(int no)
	{
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x213D9D0", Offset = "0x213DAD1", VA = "0x213D9D0")]
	protected PersonalMotionController()
	{
	}

	// Token: 0x040006BF RID: 1727
	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0x18")]
	protected PersonalMotionDataTable m_DataTable;

	// Token: 0x040006C0 RID: 1728
	[Token(Token = "0x4000565")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D3B0", Offset = "0x15D4B1")]
	private bool <IsActivated>k__BackingField;

	// Token: 0x040006C1 RID: 1729
	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0x21")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D3C0", Offset = "0x15D4C1")]
	private bool <IsMotionPlay>k__BackingField;

	// Token: 0x040006C2 RID: 1730
	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0x24")]
	protected float m_elapsed;
}
