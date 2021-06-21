using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CF RID: 463
[Token(Token = "0x200016D")]
public abstract class EquipBaseObserve : NormalizedTimeObserve
{
	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06000994 RID: 2452 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000995 RID: 2453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AC")]
	public HumanEquipment Equipment
	{
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x22B6AC0", Offset = "0x22B6BC1", VA = "0x22B6AC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AF30", Offset = "0x19B031")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x22B6AD0", Offset = "0x22B6BD1", VA = "0x22B6AD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AF40", Offset = "0x19B041")]
		private set
		{
		}
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000847")]
	[Address(RVA = "0x22B6AE0", Offset = "0x22B6BE1", VA = "0x22B6AE0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000848")]
	[Address(RVA = "0x22B6BF0", Offset = "0x22B6CF1", VA = "0x22B6BF0", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000849")]
	[Address(RVA = "0x22B6D00", Offset = "0x22B6E01", VA = "0x22B6D00", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084A")]
	[Address(RVA = "0x22B6E10", Offset = "0x22B6F11", VA = "0x22B6E10")]
	public void Init(HumanEquipment equipment, float normalizedTime)
	{
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084B")]
	[Address(RVA = "0x22B6E50", Offset = "0x22B6F51", VA = "0x22B6E50")]
	protected EquipBaseObserve()
	{
	}

	// Token: 0x04000612 RID: 1554
	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CD40", Offset = "0x15CE41")]
	private HumanEquipment <Equipment>k__BackingField;
}
