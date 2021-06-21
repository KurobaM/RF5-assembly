using System;
using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using BossData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020006C7 RID: 1735
[Token(Token = "0x20004D5")]
public abstract class BossBehaviorController : MonsterBehaviorController
{
	// Token: 0x1700069C RID: 1692
	// (get) Token: 0x06002A81 RID: 10881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000542")]
	protected BossMonsterContoroller BossMonsterContoroller
	{
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x2457580", Offset = "0x2457681", VA = "0x2457580")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700069D RID: 1693
	// (get) Token: 0x06002A82 RID: 10882 RVA: 0x00010620 File Offset: 0x0000E820
	// (set) Token: 0x06002A83 RID: 10883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000543")]
	public BossBehaviorController.BossMadnessState _BossMadnessState
	{
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x2457670", Offset = "0x2457771", VA = "0x2457670")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2770", Offset = "0x1A2871")]
		get
		{
			return BossBehaviorController.BossMadnessState.None;
		}
		[Token(Token = "0x60023CD")]
		[Address(RVA = "0x2457680", Offset = "0x2457781", VA = "0x2457680")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2780", Offset = "0x1A2881")]
		protected set
		{
		}
	}

	// Token: 0x1700069E RID: 1694
	// (get) Token: 0x06002A84 RID: 10884 RVA: 0x00010638 File Offset: 0x0000E838
	[Token(Token = "0x17000544")]
	public bool IsMadness
	{
		[Token(Token = "0x60023CE")]
		[Address(RVA = "0x2457690", Offset = "0x2457791", VA = "0x2457690")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700069F RID: 1695
	// (get) Token: 0x06002A85 RID: 10885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000545")]
	public BossDataAssetBase BossDataAsset
	{
		[Token(Token = "0x60023CF")]
		[Address(RVA = "0x24576A0", Offset = "0x24577A1", VA = "0x24576A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170006A0 RID: 1696
	// (get) Token: 0x06002A87 RID: 10887 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002A86 RID: 10886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000546")]
	protected CalcLotteryBossBehavior CalcLotteryBossBehavior
	{
		[Token(Token = "0x60023D1")]
		[Address(RVA = "0x24576C0", Offset = "0x24577C1", VA = "0x24576C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A27A0", Offset = "0x1A28A1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x24576B0", Offset = "0x24577B1", VA = "0x24576B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2790", Offset = "0x1A2891")]
		set
		{
		}
	}

	// Token: 0x06002A88 RID: 10888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023D2")]
	[Address(RVA = "0x244F9E0", Offset = "0x244FAE1", VA = "0x244F9E0")]
	public void SetupHUDBossHpBar()
	{
	}

	// Token: 0x06002A89 RID: 10889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023D3")]
	[Address(RVA = "0x24576D0", Offset = "0x24577D1", VA = "0x24576D0", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x06002A8A RID: 10890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023D4")]
	[Address(RVA = "0x2457720", Offset = "0x2457821", VA = "0x2457720", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002A8B RID: 10891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023D5")]
	[Address(RVA = "0x2457770", Offset = "0x2457871", VA = "0x2457770")]
	private void OnDisable()
	{
	}

	// Token: 0x06002A8C RID: 10892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023D6")]
	[Address(RVA = "0x2457830", Offset = "0x2457931", VA = "0x2457830", Slot = "82")]
	public virtual void SetBossDataAsset(BossDataAssetBase bossData)
	{
	}

	// Token: 0x06002A8D RID: 10893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D7")]
	[Address(RVA = "0x24578A0", Offset = "0x24579A1", VA = "0x24578A0", Slot = "83")]
	public virtual List<MonsterActionInformation> GetActiveActionInformationList()
	{
		return null;
	}

	// Token: 0x06002A8E RID: 10894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023D8")]
	[Address(RVA = "0x2457940", Offset = "0x2457A41", VA = "0x2457940", Slot = "19")]
	protected override void OnGetVariableBehaviorParameter()
	{
	}

	// Token: 0x06002A8F RID: 10895 RVA: 0x00010650 File Offset: 0x0000E850
	[Token(Token = "0x60023D9")]
	[Address(RVA = "0x24580C0", Offset = "0x24581C1", VA = "0x24580C0")]
	private bool IgnoreCharacter(Character character)
	{
		return default(bool);
	}

	// Token: 0x06002A90 RID: 10896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DA")]
	[Address(RVA = "0x2458100", Offset = "0x2458201", VA = "0x2458100", Slot = "15")]
	public override void SetupSearchCharacterController()
	{
	}

	// Token: 0x06002A91 RID: 10897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DB")]
	[Address(RVA = "0x24582E0", Offset = "0x24583E1", VA = "0x24582E0", Slot = "52")]
	public override void UpdateActiveActionInformation()
	{
	}

	// Token: 0x06002A92 RID: 10898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DC")]
	[Address(RVA = "0x24583A0", Offset = "0x24584A1", VA = "0x24583A0", Slot = "57")]
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x06002A93 RID: 10899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DD")]
	[Address(RVA = "0x24584B0", Offset = "0x24585B1", VA = "0x24584B0", Slot = "84")]
	public virtual void OnMadness()
	{
	}

	// Token: 0x06002A94 RID: 10900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DE")]
	[Address(RVA = "0x2458550", Offset = "0x2458651", VA = "0x2458550", Slot = "85")]
	public virtual void CreateMadnessEffect()
	{
	}

	// Token: 0x06002A95 RID: 10901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023DF")]
	[Address(RVA = "0x24585F0", Offset = "0x24586F1", VA = "0x24585F0", Slot = "86")]
	public virtual void StartMadness()
	{
	}

	// Token: 0x06002A96 RID: 10902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023E0")]
	[Address(RVA = "0x2458680", Offset = "0x2458781", VA = "0x2458680", Slot = "63")]
	public override void OnEndActionScript()
	{
	}

	// Token: 0x06002A97 RID: 10903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023E1")]
	[Address(RVA = "0x24586A0", Offset = "0x24587A1", VA = "0x24586A0", Slot = "69")]
	public override void OnEndAnimEventMadnessState()
	{
	}

	// Token: 0x06002A98 RID: 10904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023E2")]
	[Address(RVA = "0x24587C0", Offset = "0x24588C1", VA = "0x24587C0", Slot = "54")]
	public override void OnHitAttack()
	{
	}

	// Token: 0x06002A99 RID: 10905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023E3")]
	[Address(RVA = "0x24587D0", Offset = "0x24588D1", VA = "0x24587D0", Slot = "65")]
	public override void OnEndAnimEventDeadState()
	{
	}

	// Token: 0x06002A9A RID: 10906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E4")]
	[Address(RVA = "0x2458800", Offset = "0x2458901", VA = "0x2458800", Slot = "87")]
	public virtual string GetLotteryTypeEnumToString(int SelectType)
	{
		return null;
	}

	// Token: 0x06002A9B RID: 10907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023E5")]
	[Address(RVA = "0x2458850", Offset = "0x2458951", VA = "0x2458850", Slot = "88")]
	public virtual void OnUpdateBossDataBitArray()
	{
	}

	// Token: 0x06002A9C RID: 10908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023E6")]
	[Address(RVA = "0x2458A20", Offset = "0x2458B21", VA = "0x2458A20", Slot = "89")]
	protected virtual void UpdateMonsterActionListIndex()
	{
	}

	// Token: 0x06002A9D RID: 10909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023E7")]
	[Address(RVA = "0x2458A90", Offset = "0x2458B91", VA = "0x2458A90", Slot = "90")]
	protected virtual void SetupMonsterActionList(int type)
	{
	}

	// Token: 0x06002A9E RID: 10910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023E8")]
	[Address(RVA = "0x2458B10", Offset = "0x2458C11", VA = "0x2458B10", Slot = "91")]
	protected virtual void UpdateMonsterActionList()
	{
	}

	// Token: 0x06002A9F RID: 10911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023E9")]
	[Address(RVA = "0x2458C00", Offset = "0x2458D01", VA = "0x2458C00", Slot = "74")]
	public override void SetupMonsterAction()
	{
	}

	// Token: 0x06002AA0 RID: 10912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023EA")]
	[Address(RVA = "0x2458D60", Offset = "0x2458E61", VA = "0x2458D60", Slot = "75")]
	public override void ExecuteMonsterAction(int index)
	{
	}

	// Token: 0x06002AA1 RID: 10913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023EB")]
	[Address(RVA = "0x2458E10", Offset = "0x2458F11", VA = "0x2458E10", Slot = "76")]
	public override void AbortMonsterAction(int index)
	{
	}

	// Token: 0x06002AA2 RID: 10914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023EC")]
	[Address(RVA = "0x2458ED0", Offset = "0x2458FD1", VA = "0x2458ED0", Slot = "77")]
	public override void EndMonsterAction()
	{
	}

	// Token: 0x06002AA3 RID: 10915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023ED")]
	[Address(RVA = "0x2458F00", Offset = "0x2459001", VA = "0x2458F00", Slot = "92")]
	protected virtual void UpdateRestraintBehaviorTiming()
	{
	}

	// Token: 0x06002AA4 RID: 10916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023EE")]
	[Address(RVA = "0x2458F30", Offset = "0x2459031", VA = "0x2458F30", Slot = "93")]
	protected virtual void UpdateReciveItemBehaviorTiming()
	{
	}

	// Token: 0x06002AA5 RID: 10917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023EF")]
	[Address(RVA = "0x2458F60", Offset = "0x2459061", VA = "0x2458F60", Slot = "79")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002AA6 RID: 10918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023F0")]
	[Address(RVA = "0x2458F90", Offset = "0x2459091", VA = "0x2458F90")]
	protected BossBehaviorController()
	{
	}

	// Token: 0x06002AA7 RID: 10919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023F1")]
	[Address(RVA = "0x2458FA0", Offset = "0x24590A1", VA = "0x2458FA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A27B0", Offset = "0x1A28B1")]
	private void <CreateMadnessEffect>b__48_0(ParticleSystem effect)
	{
	}

	// Token: 0x04007246 RID: 29254
	[Token(Token = "0x40069EC")]
	[FieldOffset(Offset = "0x118")]
	private BossMonsterContoroller _BossMonsterContoroller;

	// Token: 0x04007247 RID: 29255
	[Token(Token = "0x40069ED")]
	[FieldOffset(Offset = "0x120")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1695A0", Offset = "0x1696A1")]
	private BossBehaviorController.BossMadnessState <_BossMadnessState>k__BackingField;

	// Token: 0x04007248 RID: 29256
	[Token(Token = "0x40069EE")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private BossDataAssetBase _BossDataAsset;

	// Token: 0x04007249 RID: 29257
	[Token(Token = "0x40069EF")]
	[FieldOffset(Offset = "0x130")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1695C0", Offset = "0x1696C1")]
	private CalcLotteryBossBehavior <CalcLotteryBossBehavior>k__BackingField;

	// Token: 0x0400724A RID: 29258
	[Token(Token = "0x40069F0")]
	[FieldOffset(Offset = "0x138")]
	private bool IsHitPrevAttack;

	// Token: 0x0400724B RID: 29259
	[Token(Token = "0x40069F1")]
	[FieldOffset(Offset = "0x140")]
	protected SharedMovementBehaviorType SharedMovementBehaviorType;

	// Token: 0x0400724C RID: 29260
	[Token(Token = "0x40069F2")]
	[FieldOffset(Offset = "0x148")]
	protected SharedFloat MaxWaitInterval;

	// Token: 0x0400724D RID: 29261
	[Token(Token = "0x40069F3")]
	[FieldOffset(Offset = "0x150")]
	protected SharedFloat MinWaitInterval;

	// Token: 0x0400724E RID: 29262
	[Token(Token = "0x40069F4")]
	[FieldOffset(Offset = "0x158")]
	protected SharedFloat MoveAroundRange;

	// Token: 0x0400724F RID: 29263
	[Token(Token = "0x40069F5")]
	[FieldOffset(Offset = "0x160")]
	protected SharedFloat MoveAroundAngle;

	// Token: 0x04007250 RID: 29264
	[Token(Token = "0x40069F6")]
	[FieldOffset(Offset = "0x168")]
	protected SharedBool IsReleseEyes;

	// Token: 0x04007251 RID: 29265
	[Token(Token = "0x40069F7")]
	[FieldOffset(Offset = "0x170")]
	protected SharedFloat LeaveRange;

	// Token: 0x04007252 RID: 29266
	[Token(Token = "0x40069F8")]
	[FieldOffset(Offset = "0x178")]
	protected SharedFloat CloseRange;

	// Token: 0x04007253 RID: 29267
	[Token(Token = "0x40069F9")]
	[FieldOffset(Offset = "0x180")]
	protected SharedFloat MoveSpeedScale;

	// Token: 0x04007254 RID: 29268
	[Token(Token = "0x40069FA")]
	[FieldOffset(Offset = "0x188")]
	protected SharedFloat JumpTime;

	// Token: 0x04007255 RID: 29269
	[Token(Token = "0x40069FB")]
	[FieldOffset(Offset = "0x190")]
	protected SharedVector3 JumpArrivePosition;

	// Token: 0x04007256 RID: 29270
	[Token(Token = "0x40069FC")]
	[FieldOffset(Offset = "0x198")]
	protected SharedString CrossFadeAnimatorStateName;

	// Token: 0x04007257 RID: 29271
	[Token(Token = "0x40069FD")]
	[FieldOffset(Offset = "0x1A0")]
	protected SharedBool OnlyUseMaxRange;

	// Token: 0x04007258 RID: 29272
	[Token(Token = "0x40069FE")]
	[FieldOffset(Offset = "0x1A8")]
	protected SharedVector3 MovePosition;

	// Token: 0x04007259 RID: 29273
	[Token(Token = "0x40069FF")]
	[FieldOffset(Offset = "0x1B0")]
	protected SharedBool UseBaseActionScript;

	// Token: 0x0400725A RID: 29274
	[Token(Token = "0x4006A00")]
	[FieldOffset(Offset = "0x1B8")]
	protected SharedVector3 TargetPosition;

	// Token: 0x020006C8 RID: 1736
	[Token(Token = "0x200117A")]
	protected enum ActionScriptNo
	{
		// Token: 0x0400725C RID: 29276
		[Token(Token = "0x40194C9")]
		Madness = 100,
		// Token: 0x0400725D RID: 29277
		[Token(Token = "0x40194CA")]
		e_Count
	}

	// Token: 0x020006C9 RID: 1737
	[Token(Token = "0x200117B")]
	public enum BossMadnessState
	{
		// Token: 0x0400725F RID: 29279
		[Token(Token = "0x40194CC")]
		None,
		// Token: 0x04007260 RID: 29280
		[Token(Token = "0x40194CD")]
		WaitMadnessAnimation,
		// Token: 0x04007261 RID: 29281
		[Token(Token = "0x40194CE")]
		MadnessAnimation,
		// Token: 0x04007262 RID: 29282
		[Token(Token = "0x40194CF")]
		Madness
	}

	// Token: 0x020006CA RID: 1738
	[Token(Token = "0x200117C")]
	public enum BossMonsterAction
	{
		// Token: 0x04007264 RID: 29284
		[Token(Token = "0x40194D1")]
		MADNESS = 21,
		// Token: 0x04007265 RID: 29285
		[Token(Token = "0x40194D2")]
		MADNESSANIMEND,
		// Token: 0x04007266 RID: 29286
		[Token(Token = "0x40194D3")]
		E_COUNT
	}

	// Token: 0x020006CB RID: 1739
	[Token(Token = "0x200117D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158340", Offset = "0x158441")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002AA9 RID: 10921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A2")]
		[Address(RVA = "0x24590D0", Offset = "0x24591D1", VA = "0x24590D0")]
		public <>c()
		{
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A3")]
		[Address(RVA = "0x24590E0", Offset = "0x24591E1", VA = "0x24590E0")]
		internal void <SetupHUDBossHpBar>b__36_0(CharacterStatusBase status, int amount)
		{
		}

		// Token: 0x04007267 RID: 29287
		[Token(Token = "0x40194D4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BossBehaviorController.<>c <>9;

		// Token: 0x04007268 RID: 29288
		[Token(Token = "0x40194D5")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction<CharacterStatusBase, int> <>9__36_0;
	}
}
