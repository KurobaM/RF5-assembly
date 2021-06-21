using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;

// Token: 0x0200009F RID: 159
[Token(Token = "0x2000079")]
public class MonsterActionScriptsControllerBase : ActionScriptControllerBase
{
	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007C")]
	public MonsterControllerBase Monster
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1D84910", Offset = "0x1D84A11", VA = "0x1D84910")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007D")]
	public override Character Character
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1D84DD0", Offset = "0x1D84ED1", VA = "0x1D84DD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007E")]
	public MonsterVoiceController MonsterVoiceController
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1D84E80", Offset = "0x1D84F81", VA = "0x1D84E80")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600030D RID: 781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700007F")]
	public MonsterActionCodeDataTableArray ActionCodeDataTableArray
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1D84F30", Offset = "0x1D85031", VA = "0x1D84F30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A080", Offset = "0x19A181")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1D84F40", Offset = "0x1D85041", VA = "0x1D84F40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A090", Offset = "0x19A191")]
		protected set
		{
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000080")]
	public List<CharacterBase> HitCharacterList
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1D84F50", Offset = "0x1D85051", VA = "0x1D84F50")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000257")]
	[Address(RVA = "0x1D84F60", Offset = "0x1D85061", VA = "0x1D84F60")]
	public void SetNextActionCodeName(string actionCodeName)
	{
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1D84F70", Offset = "0x1D85071", VA = "0x1D84F70", Slot = "24")]
	public virtual void SetActionCodeDataTableArray(MonsterActionCodeDataTableArray array)
	{
	}

	// Token: 0x06000311 RID: 785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1D83BA0", Offset = "0x1D83CA1", VA = "0x1D83BA0", Slot = "25")]
	public virtual void SharedProjectileControllerParameter(MonsterProjectileActionScriptsController controller)
	{
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025A")]
	[Address(RVA = "0x1D850E0", Offset = "0x1D851E1", VA = "0x1D850E0", Slot = "26")]
	public virtual MonsterProjectileActionScriptsController CreateProjectileBullet()
	{
		return null;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025B")]
	[Address(RVA = "0x1D851B0", Offset = "0x1D852B1", VA = "0x1D851B0", Slot = "10")]
	protected override ActionCommandBase DataTableToCommandClass(ActionCommandDataTable actionCommandDataTable)
	{
		return null;
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x1D852D0", Offset = "0x1D853D1", VA = "0x1D852D0", Slot = "11")]
	public override void InternalSetUpActionCode(string actionCodeName)
	{
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025D")]
	[Address(RVA = "0x1D85570", Offset = "0x1D85671", VA = "0x1D85570", Slot = "13")]
	public override void StopAction()
	{
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025E")]
	[Address(RVA = "0x1D855C0", Offset = "0x1D856C1", VA = "0x1D855C0", Slot = "12")]
	public override void DoAction(ActionCode actionCode)
	{
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x1D856B0", Offset = "0x1D857B1", VA = "0x1D856B0", Slot = "23")]
	protected override void Update()
	{
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x1D858C0", Offset = "0x1D859C1", VA = "0x1D858C0")]
	public void SetClearHitListTime(float time)
	{
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x1D85640", Offset = "0x1D85741", VA = "0x1D85640")]
	public void ClearHitList()
	{
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x1D85800", Offset = "0x1D85901", VA = "0x1D85800")]
	private void UpdateClearHitList()
	{
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000263")]
	[Address(RVA = "0x1D84CA0", Offset = "0x1D84DA1", VA = "0x1D84CA0")]
	public MonsterActionScriptsControllerBase()
	{
	}

	// Token: 0x0400021B RID: 539
	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x140")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B830", Offset = "0x15B931")]
	private MonsterActionCodeDataTableArray <ActionCodeDataTableArray>k__BackingField;

	// Token: 0x0400021C RID: 540
	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x148")]
	private MonsterControllerBase _Monster;

	// Token: 0x0400021D RID: 541
	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x150")]
	[NonSerialized]
	public UnityEvent OnEndActionScriptEvent;

	// Token: 0x0400021E RID: 542
	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x158")]
	public MonsterProjectileEvent MonsterProjectileEvent;

	// Token: 0x0400021F RID: 543
	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x160")]
	public int CurrentActionIndex;

	// Token: 0x04000220 RID: 544
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x168")]
	private MonsterVoiceController _MonsterVoiceController;

	// Token: 0x04000221 RID: 545
	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x170")]
	private List<CharacterBase> HitCharacterBaseList;

	// Token: 0x04000222 RID: 546
	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x178")]
	private float ClearHitListTime;

	// Token: 0x04000223 RID: 547
	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x17C")]
	private float ClearHitListTimer;
}
