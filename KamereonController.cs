using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000719 RID: 1817
[Token(Token = "0x20004F7")]
public class KamereonController : BossMonsterContoroller
{
	// Token: 0x06002DED RID: 11757 RVA: 0x00010BC0 File Offset: 0x0000EDC0
	[Token(Token = "0x60026B9")]
	[Address(RVA = "0x2243EA0", Offset = "0x2243FA1", VA = "0x2243EA0", Slot = "9")]
	public override bool IsCanNotLockon(CharacterBase lockonCharacter)
	{
		return default(bool);
	}

	// Token: 0x06002DEE RID: 11758 RVA: 0x00010BD8 File Offset: 0x0000EDD8
	[Token(Token = "0x60026BA")]
	[Address(RVA = "0x2243FC0", Offset = "0x22440C1", VA = "0x2243FC0", Slot = "104")]
	public override bool IsCanRestraint()
	{
		return default(bool);
	}

	// Token: 0x06002DEF RID: 11759 RVA: 0x00010BF0 File Offset: 0x0000EDF0
	[Token(Token = "0x60026BB")]
	[Address(RVA = "0x2244000", Offset = "0x2244101", VA = "0x2244000", Slot = "151")]
	protected override bool CanReciveItem()
	{
		return default(bool);
	}

	// Token: 0x170006C1 RID: 1729
	// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x00010C08 File Offset: 0x0000EE08
	[Token(Token = "0x17000563")]
	private bool IsStealth
	{
		[Token(Token = "0x60026BC")]
		[Address(RVA = "0x2243EE0", Offset = "0x2243FE1", VA = "0x2243EE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170006C2 RID: 1730
	// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x00010C20 File Offset: 0x0000EE20
	// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000564")]
	public float StealthTimeNormal
	{
		[Token(Token = "0x60026BD")]
		[Address(RVA = "0x2244040", Offset = "0x2244141", VA = "0x2244040")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3680", Offset = "0x1A3781")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x2244050", Offset = "0x2244151", VA = "0x2244050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3690", Offset = "0x1A3791")]
		set
		{
		}
	}

	// Token: 0x170006C3 RID: 1731
	// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x00010C38 File Offset: 0x0000EE38
	// (set) Token: 0x06002DF4 RID: 11764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000565")]
	public float StealthTimeMadness
	{
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x2244060", Offset = "0x2244161", VA = "0x2244060")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A36A0", Offset = "0x1A37A1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x2244070", Offset = "0x2244171", VA = "0x2244070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A36B0", Offset = "0x1A37B1")]
		set
		{
		}
	}

	// Token: 0x170006C4 RID: 1732
	// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x00010C50 File Offset: 0x0000EE50
	// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000566")]
	public float StealthSlowScale
	{
		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x2244080", Offset = "0x2244181", VA = "0x2244080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A36C0", Offset = "0x1A37C1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x2244090", Offset = "0x2244191", VA = "0x2244090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A36D0", Offset = "0x1A37D1")]
		set
		{
		}
	}

	// Token: 0x06002DF7 RID: 11767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026C3")]
	[Address(RVA = "0x22440A0", Offset = "0x22441A1", VA = "0x22440A0", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002DF8 RID: 11768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026C4")]
	[Address(RVA = "0x2244180", Offset = "0x2244281", VA = "0x2244180")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002DF9 RID: 11769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026C5")]
	[Address(RVA = "0x22442C0", Offset = "0x22443C1", VA = "0x22442C0", Slot = "134")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002DFA RID: 11770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026C6")]
	[Address(RVA = "0x22442F0", Offset = "0x22443F1", VA = "0x22442F0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002DFB RID: 11771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026C7")]
	[Address(RVA = "0x2244320", Offset = "0x2244421", VA = "0x2244320", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002DFC RID: 11772 RVA: 0x00010C68 File Offset: 0x0000EE68
	[Token(Token = "0x60026C8")]
	[Address(RVA = "0x22443F0", Offset = "0x22444F1", VA = "0x22443F0", Slot = "52")]
	protected override float GetSlowMoveScale()
	{
		return 0f;
	}

	// Token: 0x06002DFD RID: 11773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026C9")]
	[Address(RVA = "0x2243A60", Offset = "0x2243B61", VA = "0x2243A60")]
	public void PlayStealth()
	{
	}

	// Token: 0x06002DFE RID: 11774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026CA")]
	[Address(RVA = "0x2243290", Offset = "0x2243391", VA = "0x2243290")]
	public void PlayDefault()
	{
	}

	// Token: 0x06002DFF RID: 11775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026CB")]
	[Address(RVA = "0x2244740", Offset = "0x2244841", VA = "0x2244740")]
	private void UpdateStartStealthWaitState()
	{
	}

	// Token: 0x06002E00 RID: 11776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026CC")]
	[Address(RVA = "0x2244830", Offset = "0x2244931", VA = "0x2244830")]
	private void UpdateStealthLoopState()
	{
	}

	// Token: 0x06002E01 RID: 11777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026CD")]
	[Address(RVA = "0x22443D0", Offset = "0x22444D1", VA = "0x22443D0")]
	private void MainUpdateStealth()
	{
	}

	// Token: 0x06002E02 RID: 11778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026CE")]
	[Address(RVA = "0x22448A0", Offset = "0x22449A1", VA = "0x22448A0")]
	public void SetupCrazyRush(int min, int max)
	{
	}

	// Token: 0x06002E03 RID: 11779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026CF")]
	[Address(RVA = "0x2244900", Offset = "0x2244A01", VA = "0x2244900")]
	public void NextCrazyRush(string nextAction)
	{
	}

	// Token: 0x06002E04 RID: 11780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026D0")]
	[Address(RVA = "0x2244960", Offset = "0x2244A61", VA = "0x2244960", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002E05 RID: 11781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026D1")]
	[Address(RVA = "0x2244F80", Offset = "0x2245081", VA = "0x2244F80")]
	public KamereonController()
	{
	}

	// Token: 0x0400742A RID: 29738
	[Token(Token = "0x4006B01")]
	[FieldOffset(Offset = "0x508")]
	private KamereonShaderControl ShaderController;

	// Token: 0x0400742B RID: 29739
	[Token(Token = "0x4006B02")]
	[FieldOffset(Offset = "0x510")]
	[SerializeField]
	public float StealthFadeTime;

	// Token: 0x0400742C RID: 29740
	[Token(Token = "0x4006B03")]
	[FieldOffset(Offset = "0x514")]
	[SerializeField]
	public float StealthLoopWaitTimeOffset;

	// Token: 0x0400742D RID: 29741
	[Token(Token = "0x4006B04")]
	[FieldOffset(Offset = "0x518")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169850", Offset = "0x169951")]
	private float <StealthTimeNormal>k__BackingField;

	// Token: 0x0400742E RID: 29742
	[Token(Token = "0x4006B05")]
	[FieldOffset(Offset = "0x51C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169860", Offset = "0x169961")]
	private float <StealthTimeMadness>k__BackingField;

	// Token: 0x0400742F RID: 29743
	[Token(Token = "0x4006B06")]
	[FieldOffset(Offset = "0x520")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169870", Offset = "0x169971")]
	private float <StealthSlowScale>k__BackingField;

	// Token: 0x04007430 RID: 29744
	[Token(Token = "0x4006B07")]
	[FieldOffset(Offset = "0x524")]
	private float T;

	// Token: 0x04007431 RID: 29745
	[Token(Token = "0x4006B08")]
	[FieldOffset(Offset = "0x528")]
	private Action StealthState;

	// Token: 0x04007432 RID: 29746
	[Token(Token = "0x4006B09")]
	[FieldOffset(Offset = "0x530")]
	private bool IsCrazyRush;

	// Token: 0x04007433 RID: 29747
	[Token(Token = "0x4006B0A")]
	[FieldOffset(Offset = "0x534")]
	private int CrazyRushCounter;
}
