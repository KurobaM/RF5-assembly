using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;
using Serialize;

// Token: 0x0200081C RID: 2076
[Token(Token = "0x2000559")]
public class PartnerMonsterBehaviorController : MonsterBehaviorController
{
	// Token: 0x170007B8 RID: 1976
	// (get) Token: 0x06003768 RID: 14184 RVA: 0x000131D0 File Offset: 0x000113D0
	// (set) Token: 0x06003769 RID: 14185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000601")]
	public PartnerBehaviorType PartnerBehaviorType
	{
		[Token(Token = "0x6002E1D")]
		[Address(RVA = "0x23283F0", Offset = "0x23284F1", VA = "0x23283F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5BA0", Offset = "0x1A5CA1")]
		get
		{
			return PartnerBehaviorType.None;
		}
		[Token(Token = "0x6002E1E")]
		[Address(RVA = "0x2328400", Offset = "0x2328501", VA = "0x2328400")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5BB0", Offset = "0x1A5CB1")]
		protected set
		{
		}
	}

	// Token: 0x0600376A RID: 14186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E1F")]
	[Address(RVA = "0x2328410", Offset = "0x2328511", VA = "0x2328410", Slot = "4")]
	protected override void Start()
	{
	}

	// Token: 0x0600376B RID: 14187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E20")]
	[Address(RVA = "0x2321250", Offset = "0x2321351", VA = "0x2321250")]
	public void OrderExcuteActionScript()
	{
	}

	// Token: 0x0600376C RID: 14188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E21")]
	[Address(RVA = "0x2328420", Offset = "0x2328521", VA = "0x2328420", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x0600376D RID: 14189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E22")]
	[Address(RVA = "0x2328540", Offset = "0x2328641", VA = "0x2328540", Slot = "19")]
	protected override void OnGetVariableBehaviorParameter()
	{
	}

	// Token: 0x0600376E RID: 14190 RVA: 0x000131E8 File Offset: 0x000113E8
	[Token(Token = "0x6002E23")]
	[Address(RVA = "0x2328670", Offset = "0x2328771", VA = "0x2328670")]
	private bool IgnoreCharacter(Character character)
	{
		return default(bool);
	}

	// Token: 0x0600376F RID: 14191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E24")]
	[Address(RVA = "0x2328770", Offset = "0x2328871", VA = "0x2328770", Slot = "15")]
	public override void SetupSearchCharacterController()
	{
	}

	// Token: 0x06003770 RID: 14192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E25")]
	[Address(RVA = "0x2328940", Offset = "0x2328A41", VA = "0x2328940", Slot = "17")]
	public override void ResetSearchCharacterController()
	{
	}

	// Token: 0x06003771 RID: 14193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E26")]
	[Address(RVA = "0x2328990", Offset = "0x2328A91", VA = "0x2328990", Slot = "48")]
	protected override void AddMonsterSearchParameter()
	{
	}

	// Token: 0x06003772 RID: 14194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E27")]
	[Address(RVA = "0x2328A80", Offset = "0x2328B81", VA = "0x2328A80", Slot = "6")]
	public override void SetCharacter(Character character)
	{
	}

	// Token: 0x06003773 RID: 14195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E28")]
	[Address(RVA = "0x2328DA0", Offset = "0x2328EA1", VA = "0x2328DA0", Slot = "56")]
	public override void BeforeTakeDamage(ref DamageInfo damageInfo)
	{
	}

	// Token: 0x06003774 RID: 14196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E29")]
	[Address(RVA = "0x2328E00", Offset = "0x2328F01", VA = "0x2328E00", Slot = "57")]
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x06003775 RID: 14197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E2A")]
	[Address(RVA = "0x2328EB0", Offset = "0x2328FB1", VA = "0x2328EB0", Slot = "82")]
	public virtual void SetPartnerBehaviorType(PartnerBehaviorType type)
	{
	}

	// Token: 0x06003776 RID: 14198 RVA: 0x00013200 File Offset: 0x00011400
	[Token(Token = "0x6002E2B")]
	[Address(RVA = "0x2328EC0", Offset = "0x2328FC1", VA = "0x2328EC0")]
	public bool CheckSameMovementOrder(PartnerMovementOrderType order)
	{
		return default(bool);
	}

	// Token: 0x06003777 RID: 14199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E2C")]
	[Address(RVA = "0x2328F80", Offset = "0x2329081", VA = "0x2328F80", Slot = "63")]
	public override void OnEndActionScript()
	{
	}

	// Token: 0x06003778 RID: 14200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E2D")]
	[Address(RVA = "0x23284B0", Offset = "0x23285B1", VA = "0x23284B0")]
	private void SetupActionBehaviorContriller()
	{
	}

	// Token: 0x06003779 RID: 14201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E2E")]
	[Address(RVA = "0x2329010", Offset = "0x2329111", VA = "0x2329010", Slot = "74")]
	public override void SetupMonsterAction()
	{
	}

	// Token: 0x0600377A RID: 14202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E2F")]
	[Address(RVA = "0x2329060", Offset = "0x2329161", VA = "0x2329060", Slot = "75")]
	public override void ExecuteMonsterAction(int index)
	{
	}

	// Token: 0x0600377B RID: 14203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E30")]
	[Address(RVA = "0x2329080", Offset = "0x2329181", VA = "0x2329080")]
	public PartnerMonsterBehaviorController()
	{
	}

	// Token: 0x04007AA8 RID: 31400
	[Token(Token = "0x4006F0E")]
	private const float DEAD_INVINCIBLETIME = 1f;

	// Token: 0x04007AA9 RID: 31401
	[Token(Token = "0x4006F0F")]
	[FieldOffset(Offset = "0x118")]
	private KeyAndValue<PartnerMonsterBehaviorController.ActionType, int>[] ActionLot;

	// Token: 0x04007AAA RID: 31402
	[Token(Token = "0x4006F10")]
	[FieldOffset(Offset = "0x120")]
	private KeyAndValue<MovementBehaviorType, int>[] EndAttackMovementLot;

	// Token: 0x04007AAB RID: 31403
	[Token(Token = "0x4006F11")]
	[FieldOffset(Offset = "0x128")]
	private KeyAndValue<float, int>[] EndAttackMoveSpeedScaleLot;

	// Token: 0x04007AAC RID: 31404
	[Token(Token = "0x4006F12")]
	[FieldOffset(Offset = "0x130")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16B1A0", Offset = "0x16B2A1")]
	private PartnerBehaviorType <PartnerBehaviorType>k__BackingField;

	// Token: 0x04007AAD RID: 31405
	[Token(Token = "0x4006F13")]
	[FieldOffset(Offset = "0x138")]
	public PartnerMovementController PartnerMovementController;

	// Token: 0x04007AAE RID: 31406
	[Token(Token = "0x4006F14")]
	[FieldOffset(Offset = "0x140")]
	private MonsterActionBehaviorController ActionBehaviorController;

	// Token: 0x04007AAF RID: 31407
	[Token(Token = "0x4006F15")]
	[FieldOffset(Offset = "0x148")]
	public SharedBool IgnorePlayer;

	// Token: 0x04007AB0 RID: 31408
	[Token(Token = "0x4006F16")]
	[FieldOffset(Offset = "0x150")]
	public bool IsOrderActionScript;

	// Token: 0x0200081D RID: 2077
	[Token(Token = "0x2001248")]
	public enum ActionType
	{
		// Token: 0x04007AB2 RID: 31410
		[Token(Token = "0x4019800")]
		Favorite,
		// Token: 0x04007AB3 RID: 31411
		[Token(Token = "0x4019801")]
		Attack_1,
		// Token: 0x04007AB4 RID: 31412
		[Token(Token = "0x4019802")]
		Attack_2
	}
}
