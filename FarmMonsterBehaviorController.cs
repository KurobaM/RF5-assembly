using System;
using System.Runtime.InteropServices;
using BehaviorDesigner.Runtime;
using Define;
using Il2CppDummyDll;
using MonsterHut;
using UnityEngine;

// Token: 0x0200081A RID: 2074
[Token(Token = "0x2000558")]
public class FarmMonsterBehaviorController : MonsterBehaviorController
{
	// Token: 0x170007B7 RID: 1975
	// (get) Token: 0x0600374F RID: 14159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000600")]
	private FriendMonsterStatus FriendMonsterStatus
	{
		[Token(Token = "0x6002E08")]
		[Address(RVA = "0x21A8250", Offset = "0x21A8351", VA = "0x21A8250")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003750 RID: 14160 RVA: 0x00013188 File Offset: 0x00011388
	[Token(Token = "0x6002E09")]
	[Address(RVA = "0x21A8310", Offset = "0x21A8411", VA = "0x21A8310")]
	public bool IsEndWorkState()
	{
		return default(bool);
	}

	// Token: 0x06003751 RID: 14161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0A")]
	[Address(RVA = "0x21A8380", Offset = "0x21A8481", VA = "0x21A8380")]
	public void OrderChangeState(FarmMonsterState state)
	{
	}

	// Token: 0x06003752 RID: 14162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0B")]
	[Address(RVA = "0x21A8420", Offset = "0x21A8521", VA = "0x21A8420")]
	public void OrderChangeWorkState(FarmMonsterWorkState state)
	{
	}

	// Token: 0x06003753 RID: 14163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0C")]
	[Address(RVA = "0x21A84D0", Offset = "0x21A85D1", VA = "0x21A84D0")]
	public void SetMovePosition(Vector3 position)
	{
	}

	// Token: 0x06003754 RID: 14164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0D")]
	[Address(RVA = "0x21A8550", Offset = "0x21A8651", VA = "0x21A8550")]
	public void SetCrossFadeAnimatorStateName([Optional] string name)
	{
	}

	// Token: 0x06003755 RID: 14165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0E")]
	[Address(RVA = "0x21A85F0", Offset = "0x21A86F1", VA = "0x21A85F0")]
	public void SetMonsterHutArea(MonsterHutAreaInterface monsterHutAreaInterface)
	{
	}

	// Token: 0x06003756 RID: 14166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E0F")]
	[Address(RVA = "0x21A8A60", Offset = "0x21A8B61", VA = "0x21A8A60")]
	public void UpdateBehavior()
	{
	}

	// Token: 0x06003757 RID: 14167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E10")]
	[Address(RVA = "0x21A92C0", Offset = "0x21A93C1", VA = "0x21A92C0")]
	public void UpdateClosePlayerPosition()
	{
	}

	// Token: 0x06003758 RID: 14168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E11")]
	[Address(RVA = "0x21A9A20", Offset = "0x21A9B21", VA = "0x21A9A20")]
	public void UpdateLeavePlayerPosition()
	{
	}

	// Token: 0x06003759 RID: 14169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E12")]
	[Address(RVA = "0x21A96E0", Offset = "0x21A97E1", VA = "0x21A96E0")]
	public void UpdateWanderPosition()
	{
	}

	// Token: 0x0600375A RID: 14170 RVA: 0x000131A0 File Offset: 0x000113A0
	[Token(Token = "0x6002E13")]
	[Address(RVA = "0x21A9D90", Offset = "0x21A9E91", VA = "0x21A9D90")]
	private Vector3 GetNavmeshRayCastPoint(Vector3 sorcePosition, Vector3 targetPosition)
	{
		return default(Vector3);
	}

	// Token: 0x0600375B RID: 14171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E14")]
	[Address(RVA = "0x21A9E10", Offset = "0x21A9F11", VA = "0x21A9E10")]
	public void SetPlayerInArea(bool isPlayerInArea)
	{
	}

	// Token: 0x0600375C RID: 14172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E15")]
	[Address(RVA = "0x21A8D50", Offset = "0x21A8E51", VA = "0x21A8D50")]
	public void UpdateHutBehaviorState()
	{
	}

	// Token: 0x0600375D RID: 14173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E16")]
	[Address(RVA = "0x21A9E20", Offset = "0x21A9F21", VA = "0x21A9E20", Slot = "47")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x0600375E RID: 14174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E17")]
	[Address(RVA = "0x21A9F00", Offset = "0x21AA001", VA = "0x21A9F00", Slot = "20")]
	public override void SetStopBehavior(bool isStopBehavior)
	{
	}

	// Token: 0x0600375F RID: 14175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E18")]
	[Address(RVA = "0x21A9F90", Offset = "0x21AA091", VA = "0x21A9F90", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06003760 RID: 14176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E19")]
	[Address(RVA = "0x21AA160", Offset = "0x21AA261", VA = "0x21AA160", Slot = "19")]
	protected override void OnGetVariableBehaviorParameter()
	{
	}

	// Token: 0x06003761 RID: 14177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E1A")]
	[Address(RVA = "0x21AA660", Offset = "0x21AA761", VA = "0x21AA660", Slot = "16")]
	protected override void OnSetupSearchCharacterController()
	{
	}

	// Token: 0x06003762 RID: 14178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E1B")]
	[Address(RVA = "0x21AA6A0", Offset = "0x21AA7A1", VA = "0x21AA6A0", Slot = "61")]
	public override void OnDead()
	{
	}

	// Token: 0x06003763 RID: 14179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E1C")]
	[Address(RVA = "0x21AA6B0", Offset = "0x21AA7B1", VA = "0x21AA6B0")]
	public FarmMonsterBehaviorController()
	{
	}

	// Token: 0x04007A97 RID: 31383
	[Token(Token = "0x4006F00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private MonsterHutAreaInterface MonsterHutAreaInterface;

	// Token: 0x04007A98 RID: 31384
	[Token(Token = "0x4006F01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private SharedFarmMonsterState SharedFarmMonsterState;

	// Token: 0x04007A99 RID: 31385
	[Token(Token = "0x4006F02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private SharedFarmMonsterHutState SharedFarmMonsterHutState;

	// Token: 0x04007A9A RID: 31386
	[Token(Token = "0x4006F03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private SharedFarmMonsterWorkState SharedFarmMonsterWorkState;

	// Token: 0x04007A9B RID: 31387
	[Token(Token = "0x4006F04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private SharedFloat SharedWaitBehaviorTime;

	// Token: 0x04007A9C RID: 31388
	[Token(Token = "0x4006F05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private SharedVector3 SharedMovePosition;

	// Token: 0x04007A9D RID: 31389
	[Token(Token = "0x4006F06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public SharedString SharedCrossFadeAnimatorStateName;

	// Token: 0x04007A9E RID: 31390
	[Token(Token = "0x4006F07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private string B_ButtonMotionName;

	// Token: 0x04007A9F RID: 31391
	[Token(Token = "0x4006F08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private SharedBool SharedUseEmotion;

	// Token: 0x04007AA0 RID: 31392
	[Token(Token = "0x4006F09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private SharedEmotionType SharedEmotionType;

	// Token: 0x04007AA1 RID: 31393
	[Token(Token = "0x4006F0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private System.Action[] MonsterHutStateUpdate;

	// Token: 0x04007AA2 RID: 31394
	[Token(Token = "0x4006F0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private int CurrentIndex;

	// Token: 0x04007AA3 RID: 31395
	[Token(Token = "0x4006F0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private bool IsPlayerInArea;

	// Token: 0x04007AA4 RID: 31396
	[Token(Token = "0x4006F0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private FriendMonsterStatus _FriendMonsterStatus;

	// Token: 0x0200081B RID: 2075
	[Token(Token = "0x2001247")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158C20", Offset = "0x158D21")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003765 RID: 14181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007431")]
		[Address(RVA = "0x21AA790", Offset = "0x21AA891", VA = "0x21AA790")]
		public <>c()
		{
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007432")]
		[Address(RVA = "0x21AA7A0", Offset = "0x21AA8A1", VA = "0x21AA7A0")]
		internal void <SetMonsterHutArea>b__21_0()
		{
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x000131B8 File Offset: 0x000113B8
		[Token(Token = "0x6007433")]
		[Address(RVA = "0x21AA7B0", Offset = "0x21AA8B1", VA = "0x21AA7B0")]
		internal bool <OnSetup>b__31_0(ActionCommandDataTable command)
		{
			return default(bool);
		}

		// Token: 0x04007AA5 RID: 31397
		[Token(Token = "0x40197FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly FarmMonsterBehaviorController.<>c <>9;

		// Token: 0x04007AA6 RID: 31398
		[Token(Token = "0x40197FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static System.Action <>9__21_0;

		// Token: 0x04007AA7 RID: 31399
		[Token(Token = "0x40197FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<ActionCommandDataTable> <>9__31_0;
	}
}
