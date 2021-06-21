using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200010C RID: 268
[Token(Token = "0x20000D2")]
public class MonsterAnimatorStateEvent : StateMachineBehaviour
{
	// Token: 0x060005D0 RID: 1488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x1D858D0", Offset = "0x1D859D1", VA = "0x1D858D0")]
	public void SetOwner(MonsterControllerBase monsterControllerBase)
	{
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x1D858E0", Offset = "0x1D859E1", VA = "0x1D858E0")]
	public void AddEvent(float normalizeTime, Action action)
	{
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x1D859B0", Offset = "0x1D85AB1", VA = "0x1D859B0")]
	private void InvokeNormalizeTimeEvent(MonsterAnimatorStateEvent.NormalizeTimeEvent normalizeTimeEvent)
	{
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x1D85A60", Offset = "0x1D85B61", VA = "0x1D85A60", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x1D85BB0", Offset = "0x1D85CB1", VA = "0x1D85BB0", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x1D85D00", Offset = "0x1D85E01", VA = "0x1D85D00", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x1D85D10", Offset = "0x1D85E11", VA = "0x1D85D10")]
	public MonsterAnimatorStateEvent()
	{
	}

	// Token: 0x04000316 RID: 790
	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MonsterAnimatorStateType MonsterAnimatorStateType;

	// Token: 0x04000317 RID: 791
	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x20")]
	private List<MonsterAnimatorStateEvent.NormalizeTimeEvent> NormalizeTimeEventList;

	// Token: 0x04000318 RID: 792
	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x28")]
	private MonsterControllerBase MonsterControllerBase;

	// Token: 0x04000319 RID: 793
	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0x30")]
	private bool CanInvoke;

	// Token: 0x0200010D RID: 269
	[Token(Token = "0x2000FC4")]
	public class NormalizeTimeEvent
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BCE")]
		[Address(RVA = "0x1D859A0", Offset = "0x1D85AA1", VA = "0x1D859A0")]
		public NormalizeTimeEvent()
		{
		}

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x4018D27")]
		[FieldOffset(Offset = "0x10")]
		public bool isInvoke;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x4018D28")]
		[FieldOffset(Offset = "0x14")]
		public float NormalizeTime;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x4018D29")]
		[FieldOffset(Offset = "0x18")]
		public Action Action;
	}
}
