using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200072E RID: 1838
[Token(Token = "0x20004FE")]
public class KurageController : BossMonsterContoroller
{
	// Token: 0x06002EB4 RID: 11956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002754")]
	[Address(RVA = "0x224D930", Offset = "0x224DA31", VA = "0x224D930", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002EB5 RID: 11957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002755")]
	[Address(RVA = "0x224D940", Offset = "0x224DA41", VA = "0x224D940", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002EB6 RID: 11958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002756")]
	[Address(RVA = "0x224D950", Offset = "0x224DA51", VA = "0x224D950", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002EB7 RID: 11959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002757")]
	[Address(RVA = "0x224DB10", Offset = "0x224DC11", VA = "0x224DB10", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002EB8 RID: 11960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002758")]
	[Address(RVA = "0x224C520", Offset = "0x224C621", VA = "0x224C520")]
	public void SetDisplayCharge(bool isDisplay)
	{
	}

	// Token: 0x06002EB9 RID: 11961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002759")]
	[Address(RVA = "0x224DB20", Offset = "0x224DC21", VA = "0x224DB20")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002EBA RID: 11962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600275A")]
	[Address(RVA = "0x224E530", Offset = "0x224E631", VA = "0x224E530", Slot = "133")]
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002EBB RID: 11963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600275B")]
	[Address(RVA = "0x224E5D0", Offset = "0x224E6D1", VA = "0x224E5D0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002EBC RID: 11964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600275C")]
	[Address(RVA = "0x224E760", Offset = "0x224E861", VA = "0x224E760")]
	private void JumpProc(float range, float jumpPower, float duration)
	{
	}

	// Token: 0x06002EBD RID: 11965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600275D")]
	[Address(RVA = "0x224E9F0", Offset = "0x224EAF1", VA = "0x224E9F0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002EBE RID: 11966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600275E")]
	[Address(RVA = "0x224EB20", Offset = "0x224EC21", VA = "0x224EB20", Slot = "134")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002EBF RID: 11967 RVA: 0x00010D58 File Offset: 0x0000EF58
	[Token(Token = "0x600275F")]
	[Address(RVA = "0x224E3C0", Offset = "0x224E4C1", VA = "0x224E3C0")]
	private float GetGroundPos(Vector3 pos)
	{
		return 0f;
	}

	// Token: 0x06002EC0 RID: 11968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002760")]
	[Address(RVA = "0x224EB30", Offset = "0x224EC31", VA = "0x224EB30")]
	public KurageController()
	{
	}

	// Token: 0x06002EC1 RID: 11969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002761")]
	[Address(RVA = "0x224EBC0", Offset = "0x224ECC1", VA = "0x224EBC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3B00", Offset = "0x1A3C01")]
	private void <JumpProc>b__19_0()
	{
	}

	// Token: 0x0400749A RID: 29850
	[Token(Token = "0x4006B30")]
	private const float EscapeRange = 10f;

	// Token: 0x0400749B RID: 29851
	[Token(Token = "0x4006B31")]
	private const float CloseRange = 3f;

	// Token: 0x0400749C RID: 29852
	[Token(Token = "0x4006B32")]
	[FieldOffset(Offset = "0x508")]
	[Attribute(Name = "HideInInspector", RVA = "0x1698A0", Offset = "0x1699A1")]
	public bool IsMadnessCharge;

	// Token: 0x0400749D RID: 29853
	[Token(Token = "0x4006B33")]
	[FieldOffset(Offset = "0x509")]
	public bool IsElectroCharge;

	// Token: 0x0400749E RID: 29854
	[Token(Token = "0x4006B34")]
	private const string ChargePointName_1 = "ElectroCharge_Effect";

	// Token: 0x0400749F RID: 29855
	[Token(Token = "0x4006B35")]
	private const string ChargePointName_2 = "ElectroCharge_Effect_Head";

	// Token: 0x040074A0 RID: 29856
	[Token(Token = "0x4006B36")]
	[FieldOffset(Offset = "0x510")]
	private KurageController.EffectPointController ChargePoint_1;

	// Token: 0x040074A1 RID: 29857
	[Token(Token = "0x4006B37")]
	[FieldOffset(Offset = "0x518")]
	private KurageController.EffectPointController ChargePoint_2;

	// Token: 0x040074A2 RID: 29858
	[Token(Token = "0x4006B38")]
	[FieldOffset(Offset = "0x520")]
	public float LightningCount;

	// Token: 0x040074A3 RID: 29859
	[Token(Token = "0x4006B39")]
	[FieldOffset(Offset = "0x528")]
	private List<MonsterProjectileActionScriptsController> BulletList;

	// Token: 0x0200072F RID: 1839
	[Token(Token = "0x20011B7")]
	private class EffectPointController
	{
		// Token: 0x06002EC2 RID: 11970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724B")]
		[Address(RVA = "0x224DB00", Offset = "0x224DC01", VA = "0x224DB00")]
		public EffectPointController()
		{
		}

		// Token: 0x040074A4 RID: 29860
		[Token(Token = "0x40195D3")]
		[FieldOffset(Offset = "0x10")]
		public Transform Transform;
	}

	// Token: 0x02000730 RID: 1840
	[Token(Token = "0x20011B8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158540", Offset = "0x158641")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x06002EC3 RID: 11971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724C")]
		[Address(RVA = "0x224E3B0", Offset = "0x224E4B1", VA = "0x224E3B0")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724D")]
		[Address(RVA = "0x224EBF0", Offset = "0x224ECF1", VA = "0x224EBF0")]
		internal void <CreateProjectileEvent>b__1()
		{
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724E")]
		[Address(RVA = "0x224EC90", Offset = "0x224ED91", VA = "0x224EC90")]
		internal void <CreateProjectileEvent>b__0()
		{
		}

		// Token: 0x040074A5 RID: 29861
		[Token(Token = "0x40195D4")]
		[FieldOffset(Offset = "0x10")]
		public KurageController <>4__this;

		// Token: 0x040074A6 RID: 29862
		[Token(Token = "0x40195D5")]
		[FieldOffset(Offset = "0x18")]
		public MonsterProjectileActionScriptsController projectileActionScriptsController;
	}
}
