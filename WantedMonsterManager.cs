using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007A6 RID: 1958
[Token(Token = "0x2000526")]
public class WantedMonsterManager
{
	// Token: 0x06003267 RID: 12903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029F8")]
	[Address(RVA = "0x1E4C5C0", Offset = "0x1E4C6C1", VA = "0x1E4C5C0")]
	public WantedMonsterManager()
	{
	}

	// Token: 0x06003268 RID: 12904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029F9")]
	[Address(RVA = "0x1E4C7A0", Offset = "0x1E4C8A1", VA = "0x1E4C7A0")]
	private void DestroyMonster()
	{
	}

	// Token: 0x06003269 RID: 12905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029FA")]
	[Address(RVA = "0x1E4C880", Offset = "0x1E4C981", VA = "0x1E4C880")]
	public void Setup()
	{
	}

	// Token: 0x0600326A RID: 12906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029FB")]
	[Address(RVA = "0x1E4CAC0", Offset = "0x1E4CBC1", VA = "0x1E4CAC0")]
	public void CheckWantedData()
	{
	}

	// Token: 0x0600326B RID: 12907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029FC")]
	[Address(RVA = "0x1E4CD10", Offset = "0x1E4CE11", VA = "0x1E4CD10")]
	public void OnUpdate()
	{
	}

	// Token: 0x0600326C RID: 12908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029FD")]
	[Address(RVA = "0x1E4CE10", Offset = "0x1E4CF11", VA = "0x1E4CE10")]
	private void UpdateWaitAppearing()
	{
	}

	// Token: 0x0600326D RID: 12909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029FE")]
	[Address(RVA = "0x1E4D2C0", Offset = "0x1E4D3C1", VA = "0x1E4D2C0")]
	private void OnDeadFinish(MonsterControllerBase monster)
	{
	}

	// Token: 0x0600326E RID: 12910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029FF")]
	[Address(RVA = "0x1E4D3F0", Offset = "0x1E4D4F1", VA = "0x1E4D3F0")]
	private void UpdateWaitDisappearing()
	{
	}

	// Token: 0x0600326F RID: 12911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A00")]
	[Address(RVA = "0x1E4CD90", Offset = "0x1E4CE91", VA = "0x1E4CD90")]
	private void UpdateWantedState()
	{
	}

	// Token: 0x06003270 RID: 12912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A01")]
	[Address(RVA = "0x1E4C940", Offset = "0x1E4CA41", VA = "0x1E4C940")]
	private void SetupWantedField()
	{
	}

	// Token: 0x06003271 RID: 12913 RVA: 0x00011628 File Offset: 0x0000F828
	[Token(Token = "0x6002A02")]
	[Address(RVA = "0x1E4CC20", Offset = "0x1E4CD21", VA = "0x1E4CC20")]
	private bool ExistData()
	{
		return default(bool);
	}

	// Token: 0x06003272 RID: 12914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A03")]
	[Address(RVA = "0x1E4CBF0", Offset = "0x1E4CCF1", VA = "0x1E4CBF0")]
	public void OnReset()
	{
	}

	// Token: 0x04007715 RID: 30485
	[Token(Token = "0x4006C88")]
	private const float Length = 5f;

	// Token: 0x04007716 RID: 30486
	[Token(Token = "0x4006C89")]
	private const string FieldSceneName = "FieldMap";

	// Token: 0x04007717 RID: 30487
	[Token(Token = "0x4006C8A")]
	[FieldOffset(Offset = "0x10")]
	private bool ExistOnFieldScene;

	// Token: 0x04007718 RID: 30488
	[Token(Token = "0x4006C8B")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<WantedFieldType, WantedField> WantedFieldDic;

	// Token: 0x04007719 RID: 30489
	[Token(Token = "0x4006C8C")]
	[FieldOffset(Offset = "0x20")]
	private MonsterBehaviorController WantedMonsterBehaviorController;

	// Token: 0x0400771A RID: 30490
	[Token(Token = "0x4006C8D")]
	[FieldOffset(Offset = "0x28")]
	private float AppearRange;

	// Token: 0x0400771B RID: 30491
	[Token(Token = "0x4006C8E")]
	[FieldOffset(Offset = "0x2C")]
	private float DisappearRange;

	// Token: 0x0400771C RID: 30492
	[Token(Token = "0x4006C8F")]
	[FieldOffset(Offset = "0x30")]
	private Transform PopPointTransform;

	// Token: 0x0400771D RID: 30493
	[Token(Token = "0x4006C90")]
	[FieldOffset(Offset = "0x38")]
	private List<Action> UpdateStateList;

	// Token: 0x0400771E RID: 30494
	[Token(Token = "0x4006C91")]
	[FieldOffset(Offset = "0x40")]
	private WantedMonsterManager.State CurrentState;

	// Token: 0x020007A7 RID: 1959
	[Token(Token = "0x2001206")]
	public enum State
	{
		// Token: 0x04007720 RID: 30496
		[Token(Token = "0x40196F7")]
		None,
		// Token: 0x04007721 RID: 30497
		[Token(Token = "0x40196F8")]
		WaitAppearing,
		// Token: 0x04007722 RID: 30498
		[Token(Token = "0x40196F9")]
		WaitDisappearing
	}

	// Token: 0x020007A8 RID: 1960
	[Token(Token = "0x2001207")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158970", Offset = "0x158A71")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003274 RID: 12916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600735A")]
		[Address(RVA = "0x1E4D680", Offset = "0x1E4D781", VA = "0x1E4D680")]
		public <>c()
		{
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600735B")]
		[Address(RVA = "0x1E4D690", Offset = "0x1E4D791", VA = "0x1E4D690")]
		internal void <.ctor>b__11_0()
		{
		}

		// Token: 0x04007723 RID: 30499
		[Token(Token = "0x40196FA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly WantedMonsterManager.<>c <>9;

		// Token: 0x04007724 RID: 30500
		[Token(Token = "0x40196FB")]
		[FieldOffset(Offset = "0x8")]
		public static Action <>9__11_0;
	}

	// Token: 0x020007A9 RID: 1961
	[Token(Token = "0x2001208")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158980", Offset = "0x158A81")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x06003276 RID: 12918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600735C")]
		[Address(RVA = "0x1E4D2B0", Offset = "0x1E4D3B1", VA = "0x1E4D2B0")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600735D")]
		[Address(RVA = "0x1E4D6A0", Offset = "0x1E4D7A1", VA = "0x1E4D6A0")]
		internal void <UpdateWaitAppearing>b__0(MonsterControllerBase controller)
		{
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600735E")]
		[Address(RVA = "0x1E4D7D0", Offset = "0x1E4D8D1", VA = "0x1E4D7D0")]
		internal void <UpdateWaitAppearing>b__1(EnemyBehaviorController behavior)
		{
		}

		// Token: 0x04007725 RID: 30501
		[Token(Token = "0x40196FC")]
		[FieldOffset(Offset = "0x10")]
		public WantedMonsterManager <>4__this;

		// Token: 0x04007726 RID: 30502
		[Token(Token = "0x40196FD")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 direction;

		// Token: 0x04007727 RID: 30503
		[Token(Token = "0x40196FE")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector3> patrolPoints;

		// Token: 0x04007728 RID: 30504
		[Token(Token = "0x40196FF")]
		[FieldOffset(Offset = "0x30")]
		public Action<EnemyBehaviorController> <>9__1;
	}
}
