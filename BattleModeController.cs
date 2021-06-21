using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EE RID: 494
[Token(Token = "0x200018C")]
public class BattleModeController : MonoBehaviour
{
	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06000A09 RID: 2569 RVA: 0x000050E8 File Offset: 0x000032E8
	// (set) Token: 0x06000A0A RID: 2570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B3")]
	public bool IsStart
	{
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x2207CB0", Offset = "0x2207DB1", VA = "0x2207CB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AFE0", Offset = "0x19B0E1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x2207CC0", Offset = "0x2207DC1", VA = "0x2207CC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AFF0", Offset = "0x19B0F1")]
		protected set
		{
		}
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00005100 File Offset: 0x00003300
	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x2207CD0", Offset = "0x2207DD1", VA = "0x2207CD0", Slot = "4")]
	public virtual bool DoStart(bool Immediate)
	{
		return default(bool);
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x2207D20", Offset = "0x2207E21", VA = "0x2207D20", Slot = "5")]
	public virtual void DoEnd(bool Immediate)
	{
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00005118 File Offset: 0x00003318
	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x2207D50", Offset = "0x2207E51", VA = "0x2207D50", Slot = "6")]
	public virtual bool CanStart()
	{
		return default(bool);
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00005130 File Offset: 0x00003330
	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x2207D60", Offset = "0x2207E61", VA = "0x2207D60", Slot = "7")]
	public virtual bool CanEnd()
	{
		return default(bool);
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x2207D70", Offset = "0x2207E71", VA = "0x2207D70")]
	public BattleModeController()
	{
	}

	// Token: 0x0400065D RID: 1629
	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D030", Offset = "0x15D131")]
	private bool <IsStart>k__BackingField;
}
