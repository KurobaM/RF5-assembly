using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Define;
using Il2CppDummyDll;

// Token: 0x020007C7 RID: 1991
[Token(Token = "0x2000532")]
[Serializable]
public class MonsterBehaviorController : AIInput, MonsterEventReceiverInterface
{
	// Token: 0x1700071D RID: 1821
	// (get) Token: 0x06003339 RID: 13113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700058E")]
	public MonsterControllerBase MonsterController
	{
		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0x1D812B0", Offset = "0x1D813B1", VA = "0x1D812B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700071E RID: 1822
	// (get) Token: 0x0600333A RID: 13114 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600333B RID: 13115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700058F")]
	public MonsterActionInformation CurrentSelectAction
	{
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x1D85D90", Offset = "0x1D85E91", VA = "0x1D85D90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x1D85DA0", Offset = "0x1D85EA1", VA = "0x1D85DA0")]
		set
		{
		}
	}

	// Token: 0x1700071F RID: 1823
	// (get) Token: 0x0600333C RID: 13116 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600333D RID: 13117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000590")]
	public SharedGameObject Target
	{
		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x1D85F10", Offset = "0x1D86011", VA = "0x1D85F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4FA0", Offset = "0x1A50A1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A91")]
		[Address(RVA = "0x1D85F20", Offset = "0x1D86021", VA = "0x1D85F20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4FB0", Offset = "0x1A50B1")]
		private set
		{
		}
	}

	// Token: 0x0600333E RID: 13118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A92")]
	[Address(RVA = "0x1D85F30", Offset = "0x1D86031", VA = "0x1D85F30", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x0600333F RID: 13119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A93")]
	[Address(RVA = "0x1D85F70", Offset = "0x1D86071", VA = "0x1D85F70", Slot = "47")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06003340 RID: 13120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A94")]
	[Address(RVA = "0x1D86040", Offset = "0x1D86141", VA = "0x1D86040", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06003341 RID: 13121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A95")]
	[Address(RVA = "0x1D86140", Offset = "0x1D86241", VA = "0x1D86140", Slot = "11")]
	protected override void OnRelese()
	{
	}

	// Token: 0x06003342 RID: 13122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A96")]
	[Address(RVA = "0x1D86220", Offset = "0x1D86321", VA = "0x1D86220", Slot = "6")]
	public override void SetCharacter(Character character)
	{
	}

	// Token: 0x06003343 RID: 13123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A97")]
	[Address(RVA = "0x1D86260", Offset = "0x1D86361", VA = "0x1D86260", Slot = "19")]
	protected override void OnGetVariableBehaviorParameter()
	{
	}

	// Token: 0x06003344 RID: 13124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A98")]
	[Address(RVA = "0x1D865B0", Offset = "0x1D866B1", VA = "0x1D865B0", Slot = "15")]
	public override void SetupSearchCharacterController()
	{
	}

	// Token: 0x06003345 RID: 13125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A99")]
	[Address(RVA = "0x1D86730", Offset = "0x1D86831", VA = "0x1D86730", Slot = "13")]
	public override void OnNotReturnNavMesh()
	{
	}

	// Token: 0x06003346 RID: 13126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A9A")]
	[Address(RVA = "0x1D867F0", Offset = "0x1D868F1", VA = "0x1D867F0", Slot = "48")]
	protected virtual void AddMonsterSearchParameter()
	{
	}

	// Token: 0x06003347 RID: 13127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A9B")]
	[Address(RVA = "0x1D86890", Offset = "0x1D86991", VA = "0x1D86890", Slot = "49")]
	public virtual void SetTarget([Optional] CharacterBase target)
	{
	}

	// Token: 0x06003348 RID: 13128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A9C")]
	[Address(RVA = "0x1D869E0", Offset = "0x1D86AE1", VA = "0x1D869E0", Slot = "50")]
	public virtual void StartActionCode()
	{
	}

	// Token: 0x06003349 RID: 13129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A9D")]
	[Address(RVA = "0x1D86A20", Offset = "0x1D86B21", VA = "0x1D86A20", Slot = "51")]
	public virtual void StartActionCodeBase()
	{
	}

	// Token: 0x0600334A RID: 13130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A9E")]
	[Address(RVA = "0x1D86B20", Offset = "0x1D86C21", VA = "0x1D86B20", Slot = "52")]
	public virtual void UpdateActiveActionInformation()
	{
	}

	// Token: 0x0600334B RID: 13131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A9F")]
	[Address(RVA = "0x1D86BD0", Offset = "0x1D86CD1", VA = "0x1D86BD0")]
	public void SortActiveActionInformation()
	{
	}

	// Token: 0x0600334C RID: 13132 RVA: 0x00011910 File Offset: 0x0000FB10
	[Token(Token = "0x6002AA0")]
	[Address(RVA = "0x1D86CF0", Offset = "0x1D86DF1", VA = "0x1D86CF0")]
	public bool IsActiveAction(MonsterActionInformation info)
	{
		return default(bool);
	}

	// Token: 0x0600334D RID: 13133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AA1")]
	[Address(RVA = "0x1D86D70", Offset = "0x1D86E71", VA = "0x1D86D70")]
	public void PopupEmotion()
	{
	}

	// Token: 0x0600334E RID: 13134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AA2")]
	[Address(RVA = "0x1D86D80", Offset = "0x1D86E81", VA = "0x1D86D80")]
	public MonsterActionInformation GetMonsterActionInformation(string actionScriptName)
	{
		return null;
	}

	// Token: 0x0600334F RID: 13135 RVA: 0x00011928 File Offset: 0x0000FB28
	[Token(Token = "0x6002AA3")]
	[Address(RVA = "0x1D86E20", Offset = "0x1D86F21", VA = "0x1D86E20", Slot = "53")]
	public virtual MovementBehaviorType GetEndAttackMovementType(out float moveSpeedScale)
	{
		return MovementBehaviorType.None;
	}

	// Token: 0x06003350 RID: 13136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AA4")]
	[Address(RVA = "0x1D86E30", Offset = "0x1D86F31", VA = "0x1D86E30", Slot = "54")]
	public virtual void OnHitAttack()
	{
	}

	// Token: 0x06003351 RID: 13137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AA5")]
	[Address(RVA = "0x1D86E40", Offset = "0x1D86F41", VA = "0x1D86E40", Slot = "55")]
	public virtual void OnChangeShortPlay(bool isEnable)
	{
	}

	// Token: 0x06003352 RID: 13138 RVA: 0x00011940 File Offset: 0x0000FB40
	[Token(Token = "0x6002AA6")]
	[Address(RVA = "0x1D86E90", Offset = "0x1D86F91", VA = "0x1D86E90")]
	public bool IsMimicryType()
	{
		return default(bool);
	}

	// Token: 0x06003353 RID: 13139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AA7")]
	[Address(RVA = "0x1D86FE0", Offset = "0x1D870E1", VA = "0x1D86FE0", Slot = "56")]
	public virtual void BeforeTakeDamage(ref DamageInfo damageInfo)
	{
	}

	// Token: 0x06003354 RID: 13140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AA8")]
	[Address(RVA = "0x1D86FF0", Offset = "0x1D870F1", VA = "0x1D86FF0", Slot = "57")]
	public virtual void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x06003355 RID: 13141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AA9")]
	[Address(RVA = "0x1D870F0", Offset = "0x1D871F1", VA = "0x1D870F0", Slot = "58")]
	public virtual void OnFreeze()
	{
	}

	// Token: 0x06003356 RID: 13142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AAA")]
	[Address(RVA = "0x1D87150", Offset = "0x1D87251", VA = "0x1D87150", Slot = "59")]
	public virtual void OnKnockBack()
	{
	}

	// Token: 0x06003357 RID: 13143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AAB")]
	[Address(RVA = "0x1D871B0", Offset = "0x1D872B1", VA = "0x1D871B0", Slot = "60")]
	public virtual void OnBlow()
	{
	}

	// Token: 0x06003358 RID: 13144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AAC")]
	[Address(RVA = "0x1D87220", Offset = "0x1D87321", VA = "0x1D87220", Slot = "61")]
	public virtual void OnDead()
	{
	}

	// Token: 0x06003359 RID: 13145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AAD")]
	[Address(RVA = "0x1D87270", Offset = "0x1D87371", VA = "0x1D87270", Slot = "62")]
	public virtual void OnBadStatus(BadStatus badStatus, bool isEnable)
	{
	}

	// Token: 0x0600335A RID: 13146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AAE")]
	[Address(RVA = "0x1D87370", Offset = "0x1D87471", VA = "0x1D87370", Slot = "63")]
	public virtual void OnEndActionScript()
	{
	}

	// Token: 0x0600335B RID: 13147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AAF")]
	[Address(RVA = "0x1D873D0", Offset = "0x1D874D1", VA = "0x1D873D0", Slot = "64")]
	public virtual void OnEndAnimEventDamageState()
	{
	}

	// Token: 0x0600335C RID: 13148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AB0")]
	[Address(RVA = "0x1D87480", Offset = "0x1D87581", VA = "0x1D87480", Slot = "65")]
	public virtual void OnEndAnimEventDeadState()
	{
	}

	// Token: 0x0600335D RID: 13149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AB1")]
	[Address(RVA = "0x1D87490", Offset = "0x1D87591", VA = "0x1D87490", Slot = "66")]
	public virtual void OnEndAnimEventGetupState()
	{
	}

	// Token: 0x0600335E RID: 13150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AB2")]
	[Address(RVA = "0x1D87540", Offset = "0x1D87641", VA = "0x1D87540", Slot = "67")]
	public virtual void OnEndAnimEventJumpStart()
	{
	}

	// Token: 0x0600335F RID: 13151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AB3")]
	[Address(RVA = "0x1D875D0", Offset = "0x1D876D1", VA = "0x1D875D0", Slot = "68")]
	public virtual void OnEndAnimEventJumpEnd()
	{
	}

	// Token: 0x06003360 RID: 13152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AB4")]
	[Address(RVA = "0x1D87660", Offset = "0x1D87761", VA = "0x1D87660", Slot = "69")]
	public virtual void OnEndAnimEventMadnessState()
	{
	}

	// Token: 0x06003361 RID: 13153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AB5")]
	[Address(RVA = "0x1D87670", Offset = "0x1D87771", VA = "0x1D87670", Slot = "70")]
	public virtual void OnEndAnimEventHappyState()
	{
	}

	// Token: 0x06003362 RID: 13154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AB6")]
	[Address(RVA = "0x1D87680", Offset = "0x1D87781", VA = "0x1D87680", Slot = "71")]
	public virtual void OnEndAnimEventWait_2State()
	{
	}

	// Token: 0x06003363 RID: 13155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AB7")]
	[Address(RVA = "0x1D87690", Offset = "0x1D87791", VA = "0x1D87690", Slot = "72")]
	public virtual void OnEndAnimEventSleepStart()
	{
	}

	// Token: 0x06003364 RID: 13156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AB8")]
	[Address(RVA = "0x1D876A0", Offset = "0x1D877A1", VA = "0x1D876A0", Slot = "73")]
	public virtual void OnEndAnimEventSleepEnd()
	{
	}

	// Token: 0x06003365 RID: 13157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AB9")]
	[Address(RVA = "0x1D87700", Offset = "0x1D87801", VA = "0x1D87700", Slot = "74")]
	public virtual void SetupMonsterAction()
	{
	}

	// Token: 0x06003366 RID: 13158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ABA")]
	[Address(RVA = "0x1D87710", Offset = "0x1D87811", VA = "0x1D87710", Slot = "75")]
	public virtual void ExecuteMonsterAction(int index)
	{
	}

	// Token: 0x06003367 RID: 13159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ABB")]
	[Address(RVA = "0x1D87720", Offset = "0x1D87821", VA = "0x1D87720", Slot = "76")]
	public virtual void AbortMonsterAction(int index)
	{
	}

	// Token: 0x06003368 RID: 13160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ABC")]
	[Address(RVA = "0x1D87730", Offset = "0x1D87831", VA = "0x1D87730", Slot = "77")]
	public virtual void EndMonsterAction()
	{
	}

	// Token: 0x06003369 RID: 13161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ABD")]
	[Address(RVA = "0x1D87740", Offset = "0x1D87841", VA = "0x1D87740", Slot = "78")]
	public virtual void OnHearFootSteps()
	{
	}

	// Token: 0x0600336A RID: 13162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ABE")]
	[Address(RVA = "0x1D87750", Offset = "0x1D87851", VA = "0x1D87750", Slot = "79")]
	public virtual void OnRestraint()
	{
	}

	// Token: 0x0600336B RID: 13163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ABF")]
	[Address(RVA = "0x1D87770", Offset = "0x1D87871", VA = "0x1D87770", Slot = "80")]
	public virtual void OnRelease()
	{
	}

	// Token: 0x0600336C RID: 13164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AC0")]
	[Address(RVA = "0x1D87780", Offset = "0x1D87881", VA = "0x1D87780", Slot = "30")]
	public void OnChangeModel()
	{
	}

	// Token: 0x0600336D RID: 13165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AC1")]
	[Address(RVA = "0x1D877E0", Offset = "0x1D878E1", VA = "0x1D877E0", Slot = "22")]
	public void TameStart()
	{
	}

	// Token: 0x0600336E RID: 13166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AC2")]
	[Address(RVA = "0x1D87800", Offset = "0x1D87901", VA = "0x1D87800", Slot = "23")]
	public void TameEnd()
	{
	}

	// Token: 0x0600336F RID: 13167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AC3")]
	[Address(RVA = "0x1D87840", Offset = "0x1D87941", VA = "0x1D87840", Slot = "81")]
	protected virtual void OnEndContDeadFade()
	{
	}

	// Token: 0x06003370 RID: 13168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AC4")]
	[Address(RVA = "0x1D87940", Offset = "0x1D87A41", VA = "0x1D87940")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4FC0", Offset = "0x1A50C1")]
	protected IEnumerator CountDead()
	{
		return null;
	}

	// Token: 0x06003371 RID: 13169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AC5")]
	[Address(RVA = "0x1D879F0", Offset = "0x1D87AF1", VA = "0x1D879F0")]
	public MonsterBehaviorController()
	{
	}

	// Token: 0x06003372 RID: 13170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AC6")]
	[Address(RVA = "0x1D87C40", Offset = "0x1D87D41", VA = "0x1D87C40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5030", Offset = "0x1A5131")]
	private void <OnEndContDeadFade>b__82_0()
	{
	}

	// Token: 0x040077BB RID: 30651
	[Token(Token = "0x4006CE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected MonsterControllerBase _MonsterController;

	// Token: 0x040077BC RID: 30652
	[Token(Token = "0x4006CE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected List<MonsterActionInformation> ActiveActionInformationList;

	// Token: 0x040077BD RID: 30653
	[Token(Token = "0x4006CE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float ModelScaleRate;

	// Token: 0x040077BE RID: 30654
	[Token(Token = "0x4006CEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private MonsterActionInformation _CurrentSelectAction;

	// Token: 0x040077BF RID: 30655
	[Token(Token = "0x4006CEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected SharedBool IsEndAction;

	// Token: 0x040077C0 RID: 30656
	[Token(Token = "0x4006CEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169D80", Offset = "0x169E81")]
	private SharedGameObject <Target>k__BackingField;

	// Token: 0x040077C1 RID: 30657
	[Token(Token = "0x4006CED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public HateController HateController;

	// Token: 0x040077C2 RID: 30658
	[Token(Token = "0x4006CEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected SharedBool IsEndAnimationStartJump;

	// Token: 0x040077C3 RID: 30659
	[Token(Token = "0x4006CEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected SharedBool IsEndAnimationEndJump;

	// Token: 0x040077C4 RID: 30660
	[Token(Token = "0x4006CF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected SharedBool UseNavMeshAgent;

	// Token: 0x040077C5 RID: 30661
	[Token(Token = "0x4006CF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<MonsterActionBehaviorType> MonsterActionTypeList;

	// Token: 0x040077C6 RID: 30662
	[Token(Token = "0x4006CF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected Dictionary<int, List<MonsterBehaviorController.BehaviorActionParam>> ActionBehaviorParamListDic;

	// Token: 0x040077C7 RID: 30663
	[Token(Token = "0x4006CF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected List<MonsterBehaviorController.BehaviorActionParam> CurrentBehaviorActionParamList;

	// Token: 0x040077C8 RID: 30664
	[Token(Token = "0x4006CF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public int CurrentActionParamListIndex;

	// Token: 0x040077C9 RID: 30665
	[Token(Token = "0x4006CF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected Dictionary<int, MonsterBehaviorController.BehaviorActionParam> ActionBehaviorParamDic;

	// Token: 0x040077CA RID: 30666
	[Token(Token = "0x4006CF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int CurrentLotteryType;

	// Token: 0x040077CB RID: 30667
	[Token(Token = "0x4006CF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	protected MonsterBehaviorController.BehaviorActionParam CurrentBehaviorActionParam;

	// Token: 0x040077CC RID: 30668
	[Token(Token = "0x4006CF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public int CurrentActionParamIndex;

	// Token: 0x040077CD RID: 30669
	[Token(Token = "0x4006CF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public MonsterActionBehaviorType CurrentMonsterActionBehaviorType;

	// Token: 0x040077CE RID: 30670
	[Token(Token = "0x4006CFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public int ActionCodeBaseNo;

	// Token: 0x040077CF RID: 30671
	[Token(Token = "0x4006CFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public MonsterBehaviorController.BehaviorStateMachine StateMachine;

	// Token: 0x040077D0 RID: 30672
	[Token(Token = "0x4006CFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int DeadCount;

	// Token: 0x020007C8 RID: 1992
	[Token(Token = "0x200121B")]
	public enum MonsterAction
	{
		// Token: 0x040077D2 RID: 30674
		[Token(Token = "0x401973E")]
		ACTION = 17,
		// Token: 0x040077D3 RID: 30675
		[Token(Token = "0x401973F")]
		WINCE,
		// Token: 0x040077D4 RID: 30676
		[Token(Token = "0x4019740")]
		DEAD,
		// Token: 0x040077D5 RID: 30677
		[Token(Token = "0x4019741")]
		DEADACTION,
		// Token: 0x040077D6 RID: 30678
		[Token(Token = "0x4019742")]
		E_COUNT
	}

	// Token: 0x020007C9 RID: 1993
	[Token(Token = "0x200121C")]
	public class BehaviorStateMachine
	{
		// Token: 0x06003373 RID: 13171 RVA: 0x00011958 File Offset: 0x0000FB58
		[Token(Token = "0x6007396")]
		[Address(RVA = "0x1D87FA0", Offset = "0x1D880A1", VA = "0x1D87FA0")]
		public int StateCount()
		{
			return 0;
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007397")]
		[Address(RVA = "0x1D88000", Offset = "0x1D88101", VA = "0x1D88000")]
		public void Init()
		{
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00011970 File Offset: 0x0000FB70
		[Token(Token = "0x6007398")]
		[Address(RVA = "0x1D88020", Offset = "0x1D88121", VA = "0x1D88020")]
		public TaskStatus Update()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007399")]
		[Address(RVA = "0x1D880A0", Offset = "0x1D881A1", VA = "0x1D880A0")]
		public void End()
		{
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739A")]
		[Address(RVA = "0x1D880C0", Offset = "0x1D881C1", VA = "0x1D880C0")]
		public void AddState(int type, System.Action init, Func<TaskStatus> update, System.Action end)
		{
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739B")]
		[Address(RVA = "0x1D88250", Offset = "0x1D88351", VA = "0x1D88250")]
		public void SetNextStateType(int type)
		{
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739C")]
		[Address(RVA = "0x1D88260", Offset = "0x1D88361", VA = "0x1D88260")]
		public void ChangeState()
		{
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739D")]
		[Address(RVA = "0x1D87BC0", Offset = "0x1D87CC1", VA = "0x1D87BC0")]
		public BehaviorStateMachine()
		{
		}

		// Token: 0x040077D7 RID: 30679
		[Token(Token = "0x4019743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int NextStateType;

		// Token: 0x040077D8 RID: 30680
		[Token(Token = "0x4019744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MonsterBehaviorController.BehaviorStateMachine.BehaviorState CurrentState;

		// Token: 0x040077D9 RID: 30681
		[Token(Token = "0x4019745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, MonsterBehaviorController.BehaviorStateMachine.BehaviorState> States;

		// Token: 0x020007CA RID: 1994
		[Token(Token = "0x200164D")]
		public class BehaviorState
		{
			// Token: 0x0600337B RID: 13179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600809D")]
			[Address(RVA = "0x1D881D0", Offset = "0x1D882D1", VA = "0x1D881D0")]
			public BehaviorState(int type, System.Action init, Func<TaskStatus> update, System.Action end)
			{
			}

			// Token: 0x040077DA RID: 30682
			[Token(Token = "0x401C3FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int Type;

			// Token: 0x040077DB RID: 30683
			[Token(Token = "0x401C3FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public System.Action Init;

			// Token: 0x040077DC RID: 30684
			[Token(Token = "0x401C3FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<TaskStatus> Update;

			// Token: 0x040077DD RID: 30685
			[Token(Token = "0x401C3FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public System.Action End;
		}
	}

	// Token: 0x020007CB RID: 1995
	[Token(Token = "0x200121D")]
	protected class BehaviorActionParam
	{
		// Token: 0x0600337C RID: 13180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739E")]
		[Address(RVA = "0x1D87EA0", Offset = "0x1D87FA1", VA = "0x1D87EA0")]
		public BehaviorActionParam()
		{
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739F")]
		[Address(RVA = "0x1D87EB0", Offset = "0x1D87FB1", VA = "0x1D87EB0")]
		public BehaviorActionParam(List<MonsterActionBehaviorType> actionBehaviorTypeList, [Optional] System.Action setupAction, [Optional] Action<int, int> executeAction, [Optional] Action<int, int> abortAction, [Optional] System.Action endAction)
		{
		}

		// Token: 0x040077DE RID: 30686
		[Token(Token = "0x4019746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<MonsterActionBehaviorType> BehaviorActionTypeList;

		// Token: 0x040077DF RID: 30687
		[Token(Token = "0x4019747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public System.Action SetupAction;

		// Token: 0x040077E0 RID: 30688
		[Token(Token = "0x4019748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<int, int> ExecuteAction;

		// Token: 0x040077E1 RID: 30689
		[Token(Token = "0x4019749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<int, int> AbortAction;

		// Token: 0x040077E2 RID: 30690
		[Token(Token = "0x401974A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public System.Action EndAction;
	}

	// Token: 0x020007CC RID: 1996
	[Token(Token = "0x200121E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158A50", Offset = "0x158B51")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600337F RID: 13183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A1")]
		[Address(RVA = "0x1D87CE0", Offset = "0x1D87DE1", VA = "0x1D87CE0")]
		public <>c()
		{
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x00011988 File Offset: 0x0000FB88
		[Token(Token = "0x60073A2")]
		[Address(RVA = "0x1D87CF0", Offset = "0x1D87DF1", VA = "0x1D87CF0")]
		internal int <SortActiveActionInformation>b__46_0(MonsterActionInformation a, MonsterActionInformation b)
		{
			return 0;
		}

		// Token: 0x040077E3 RID: 30691
		[Token(Token = "0x401974B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly MonsterBehaviorController.<>c <>9;

		// Token: 0x040077E4 RID: 30692
		[Token(Token = "0x401974C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<MonsterActionInformation> <>9__46_0;
	}

	// Token: 0x020007CD RID: 1997
	[Token(Token = "0x200121F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158A60", Offset = "0x158B61")]
	private sealed class <CountDead>d__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003381 RID: 13185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A3")]
		[Address(RVA = "0x1D879C0", Offset = "0x1D87AC1", VA = "0x1D879C0")]
		[DebuggerHidden]
		public <CountDead>d__83(int <>1__state)
		{
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A4")]
		[Address(RVA = "0x1D87D80", Offset = "0x1D87E81", VA = "0x1D87D80", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x000119A0 File Offset: 0x0000FBA0
		[Token(Token = "0x60073A5")]
		[Address(RVA = "0x1D87D90", Offset = "0x1D87E91", VA = "0x1D87D90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06003384 RID: 13188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D4C")]
		private object Current
		{
			[Token(Token = "0x60073A6")]
			[Address(RVA = "0x1D87E20", Offset = "0x1D87F21", VA = "0x1D87E20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A7")]
		[Address(RVA = "0x1D87E30", Offset = "0x1D87F31", VA = "0x1D87E30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D4D")]
		private object Current
		{
			[Token(Token = "0x60073A8")]
			[Address(RVA = "0x1D87E90", Offset = "0x1D87F91", VA = "0x1D87E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040077E5 RID: 30693
		[Token(Token = "0x401974D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040077E6 RID: 30694
		[Token(Token = "0x401974E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040077E7 RID: 30695
		[Token(Token = "0x401974F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterBehaviorController <>4__this;
	}
}
