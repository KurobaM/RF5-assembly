using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F3 RID: 499
[Token(Token = "0x2000191")]
public class BitMotion : StateMachineBehaviour
{
	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BB")]
	public BitBase Bit
	{
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x2455A10", Offset = "0x2455B11", VA = "0x2455A10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B050", Offset = "0x19B151")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x2455A20", Offset = "0x2455B21", VA = "0x2455A20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B060", Offset = "0x19B161")]
		set
		{
		}
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x2455A30", Offset = "0x2455B31", VA = "0x2455A30", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x2455AC0", Offset = "0x2455BC1", VA = "0x2455AC0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x2455B70", Offset = "0x2455C71", VA = "0x2455B70")]
	public BitMotion()
	{
	}

	// Token: 0x0400066F RID: 1647
	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public BitState bitState;

	// Token: 0x04000670 RID: 1648
	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public bool exitTryDestroy;

	// Token: 0x04000671 RID: 1649
	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D150", Offset = "0x15D251")]
	private BitBase <Bit>k__BackingField;
}
