using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200031F RID: 799
[Token(Token = "0x200025A")]
public class StateMachineWorker : MonoBehaviour
{
	// Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FE")]
	public StateMachine<T> Initialize<T>(MonoBehaviour component, T startState, TransitionTables[] transitionTables) where T : struct
	{
		return null;
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x2388DD0", Offset = "0x2388ED1", VA = "0x2388DD0")]
	public void RemoveSM(IStateMachine sm)
	{
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x2388E40", Offset = "0x2388F41", VA = "0x2388E40")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001301")]
	[Address(RVA = "0x23890E0", Offset = "0x23891E1", VA = "0x23890E0")]
	private void Update()
	{
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001302")]
	[Address(RVA = "0x2389380", Offset = "0x2389481", VA = "0x2389380")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001303")]
	[Address(RVA = "0x2389620", Offset = "0x2389721", VA = "0x2389620")]
	public static void DoNothing()
	{
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001304")]
	[Address(RVA = "0x2389630", Offset = "0x2389731", VA = "0x2389630")]
	public static IEnumerator DoNothingCoroutine()
	{
		return null;
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001305")]
	[Address(RVA = "0x2389640", Offset = "0x2389741", VA = "0x2389640")]
	public static void DoNothingCollision(Collision other)
	{
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001306")]
	[Address(RVA = "0x2389650", Offset = "0x2389751", VA = "0x2389650")]
	public StateMachineWorker()
	{
	}

	// Token: 0x04000C4B RID: 3147
	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x18")]
	private List<IStateMachine> stateMachineList;
}
