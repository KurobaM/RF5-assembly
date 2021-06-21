using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200077B RID: 1915
[Token(Token = "0x200051E")]
public class YadokariController : BossMonsterContoroller
{
	// Token: 0x170006E7 RID: 1767
	// (get) Token: 0x0600317B RID: 12667 RVA: 0x00011250 File Offset: 0x0000F450
	// (set) Token: 0x0600317C RID: 12668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000579")]
	public float ShellDamageBonusRate
	{
		[Token(Token = "0x600298A")]
		[Address(RVA = "0x284C340", Offset = "0x284C441", VA = "0x284C340")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A46F0", Offset = "0x1A47F1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x284C350", Offset = "0x284C451", VA = "0x284C350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4700", Offset = "0x1A4801")]
		set
		{
		}
	}

	// Token: 0x170006E8 RID: 1768
	// (get) Token: 0x0600317D RID: 12669 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600317E RID: 12670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700057A")]
	public YadokariShellController YadokariShellController
	{
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x284C360", Offset = "0x284C461", VA = "0x284C360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4710", Offset = "0x1A4811")]
		get
		{
			return null;
		}
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x284C370", Offset = "0x284C471", VA = "0x284C370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4720", Offset = "0x1A4821")]
		private set
		{
		}
	}

	// Token: 0x170006E9 RID: 1769
	// (get) Token: 0x0600317F RID: 12671 RVA: 0x00011268 File Offset: 0x0000F468
	[Token(Token = "0x1700057B")]
	public bool IsThrowShell
	{
		[Token(Token = "0x600298E")]
		[Address(RVA = "0x284C060", Offset = "0x284C161", VA = "0x284C060")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170006EA RID: 1770
	// (get) Token: 0x06003180 RID: 12672 RVA: 0x00011280 File Offset: 0x0000F480
	// (set) Token: 0x06003181 RID: 12673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700057C")]
	public int ThrowShellCount
	{
		[Token(Token = "0x600298F")]
		[Address(RVA = "0x284C380", Offset = "0x284C481", VA = "0x284C380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4730", Offset = "0x1A4831")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002990")]
		[Address(RVA = "0x284C390", Offset = "0x284C491", VA = "0x284C390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4740", Offset = "0x1A4841")]
		set
		{
		}
	}

	// Token: 0x170006EB RID: 1771
	// (get) Token: 0x06003182 RID: 12674 RVA: 0x00011298 File Offset: 0x0000F498
	// (set) Token: 0x06003183 RID: 12675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700057D")]
	public int RestraintThrowShellTCount
	{
		[Token(Token = "0x6002991")]
		[Address(RVA = "0x284C3A0", Offset = "0x284C4A1", VA = "0x284C3A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4750", Offset = "0x1A4851")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002992")]
		[Address(RVA = "0x284C3B0", Offset = "0x284C4B1", VA = "0x284C3B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4760", Offset = "0x1A4861")]
		set
		{
		}
	}

	// Token: 0x06003184 RID: 12676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002993")]
	[Address(RVA = "0x284C3C0", Offset = "0x284C4C1", VA = "0x284C3C0", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06003185 RID: 12677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002994")]
	[Address(RVA = "0x284C4E0", Offset = "0x284C5E1", VA = "0x284C4E0", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06003186 RID: 12678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002995")]
	[Address(RVA = "0x284C4F0", Offset = "0x284C5F1", VA = "0x284C4F0", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06003187 RID: 12679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002996")]
	[Address(RVA = "0x284C580", Offset = "0x284C681", VA = "0x284C580")]
	private void RollingUpdate()
	{
	}

	// Token: 0x06003188 RID: 12680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002997")]
	[Address(RVA = "0x284C830", Offset = "0x284C931", VA = "0x284C830")]
	private void CreateProjectile(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06003189 RID: 12681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002998")]
	[Address(RVA = "0x284CA40", Offset = "0x284CB41", VA = "0x284CA40", Slot = "125")]
	protected override void OnSetModelObject(GameObject model)
	{
	}

	// Token: 0x0600318A RID: 12682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002999")]
	[Address(RVA = "0x284CAC0", Offset = "0x284CBC1", VA = "0x284CAC0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x0600318B RID: 12683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600299A")]
	[Address(RVA = "0x284CB00", Offset = "0x284CC01", VA = "0x284CB00", Slot = "139")]
	public override void OnFinishDeadEvent()
	{
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x000112B0 File Offset: 0x0000F4B0
	[Token(Token = "0x600299B")]
	[Address(RVA = "0x284CD00", Offset = "0x284CE01", VA = "0x284CD00")]
	public bool CheckBack()
	{
		return default(bool);
	}

	// Token: 0x0600318D RID: 12685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600299C")]
	[Address(RVA = "0x284CE70", Offset = "0x284CF71", VA = "0x284CE70")]
	public void SetRestraint(bool restraint)
	{
	}

	// Token: 0x0600318E RID: 12686 RVA: 0x000112C8 File Offset: 0x0000F4C8
	[Token(Token = "0x600299D")]
	[Address(RVA = "0x284CE80", Offset = "0x284CF81", VA = "0x284CE80", Slot = "53")]
	protected override float GetMoveSpeedMax()
	{
		return 0f;
	}

	// Token: 0x0600318F RID: 12687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600299E")]
	[Address(RVA = "0x284C5F0", Offset = "0x284C6F1", VA = "0x284C5F0")]
	protected void RangeEffectUpdate()
	{
	}

	// Token: 0x06003190 RID: 12688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600299F")]
	[Address(RVA = "0x284CEC0", Offset = "0x284CFC1", VA = "0x284CEC0")]
	public void SetRangeDisplay(bool play)
	{
	}

	// Token: 0x06003191 RID: 12689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029A0")]
	[Address(RVA = "0x284CEF0", Offset = "0x284CFF1", VA = "0x284CEF0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06003192 RID: 12690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029A1")]
	[Address(RVA = "0x284DC10", Offset = "0x284DD11", VA = "0x284DC10")]
	public YadokariController()
	{
	}

	// Token: 0x06003194 RID: 12692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029A3")]
	[Address(RVA = "0x284DD60", Offset = "0x284DE61", VA = "0x284DD60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4770", Offset = "0x1A4871")]
	private void <OnSetup>b__33_0(ParticleSystem particle)
	{
	}

	// Token: 0x04007649 RID: 30281
	[Token(Token = "0x4006C40")]
	private const float ShellRange = 5f;

	// Token: 0x0400764A RID: 30282
	[Token(Token = "0x4006C41")]
	private const float ThrowShellSpeed = 20f;

	// Token: 0x0400764B RID: 30283
	[Token(Token = "0x4006C42")]
	private const float ThrowShellPower = 8f;

	// Token: 0x0400764C RID: 30284
	[Token(Token = "0x4006C43")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 Range_Effect_Scale;

	// Token: 0x0400764D RID: 30285
	[Token(Token = "0x4006C44")]
	[FieldOffset(Offset = "0xC")]
	private static readonly Vector3 Range_Effect_Scale_Ball;

	// Token: 0x0400764E RID: 30286
	[Token(Token = "0x4006C45")]
	[FieldOffset(Offset = "0x508")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169980", Offset = "0x169A81")]
	private float <ShellDamageBonusRate>k__BackingField;

	// Token: 0x0400764F RID: 30287
	[Token(Token = "0x4006C46")]
	[FieldOffset(Offset = "0x510")]
	public AnimationCurve JumpAnimationCurve;

	// Token: 0x04007650 RID: 30288
	[Token(Token = "0x4006C47")]
	[FieldOffset(Offset = "0x518")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169990", Offset = "0x169A91")]
	private YadokariShellController <YadokariShellController>k__BackingField;

	// Token: 0x04007651 RID: 30289
	[Token(Token = "0x4006C48")]
	[FieldOffset(Offset = "0x520")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1699A0", Offset = "0x169AA1")]
	private int <ThrowShellCount>k__BackingField;

	// Token: 0x04007652 RID: 30290
	[Token(Token = "0x4006C49")]
	[FieldOffset(Offset = "0x524")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1699B0", Offset = "0x169AB1")]
	private int <RestraintThrowShellTCount>k__BackingField;

	// Token: 0x04007653 RID: 30291
	[Token(Token = "0x4006C4A")]
	[FieldOffset(Offset = "0x528")]
	public bool IsRolling;

	// Token: 0x04007654 RID: 30292
	[Token(Token = "0x4006C4B")]
	[FieldOffset(Offset = "0x52C")]
	public float RollingAngle;

	// Token: 0x04007655 RID: 30293
	[Token(Token = "0x4006C4C")]
	[FieldOffset(Offset = "0x530")]
	public bool IsRestraint;

	// Token: 0x04007656 RID: 30294
	[Token(Token = "0x4006C4D")]
	[FieldOffset(Offset = "0x534")]
	public int WaveCount;

	// Token: 0x04007657 RID: 30295
	[Token(Token = "0x4006C4E")]
	[FieldOffset(Offset = "0x538")]
	public int SafeWaveCount;

	// Token: 0x04007658 RID: 30296
	[Token(Token = "0x4006C4F")]
	[FieldOffset(Offset = "0x540")]
	private ParticleSystem RangeEffect;

	// Token: 0x04007659 RID: 30297
	[Token(Token = "0x4006C50")]
	[FieldOffset(Offset = "0x548")]
	public bool IsRangeSearch;

	// Token: 0x0400765A RID: 30298
	[Token(Token = "0x4006C51")]
	[FieldOffset(Offset = "0x549")]
	public bool IsShellThrowRange;

	// Token: 0x0400765B RID: 30299
	[Token(Token = "0x4006C52")]
	[FieldOffset(Offset = "0x54C")]
	public Vector3 RangePos;

	// Token: 0x0200077C RID: 1916
	[Token(Token = "0x20011E4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158760", Offset = "0x158861")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003196 RID: 12694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072DD")]
		[Address(RVA = "0x284DF80", Offset = "0x284E081", VA = "0x284DF80")]
		public <>c()
		{
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072DE")]
		[Address(RVA = "0x284DF90", Offset = "0x284E091", VA = "0x284DF90")]
		internal void <OnUniqueActionCommandInternal>b__46_1()
		{
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072DF")]
		[Address(RVA = "0x284DFA0", Offset = "0x284E0A1", VA = "0x284DFA0")]
		internal void <OnUniqueActionCommandInternal>b__46_0()
		{
		}

		// Token: 0x0400765C RID: 30300
		[Token(Token = "0x4019672")]
		[FieldOffset(Offset = "0x0")]
		public static readonly YadokariController.<>c <>9;

		// Token: 0x0400765D RID: 30301
		[Token(Token = "0x4019673")]
		[FieldOffset(Offset = "0x8")]
		public static Action <>9__46_1;

		// Token: 0x0400765E RID: 30302
		[Token(Token = "0x4019674")]
		[FieldOffset(Offset = "0x10")]
		public static Action <>9__46_0;
	}
}
