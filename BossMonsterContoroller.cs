using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006CC RID: 1740
[Token(Token = "0x20004D6")]
public class BossMonsterContoroller : MonsterControllerBase
{
	// Token: 0x170006A1 RID: 1697
	// (get) Token: 0x06002AAC RID: 10924 RVA: 0x00010668 File Offset: 0x0000E868
	// (set) Token: 0x06002AAB RID: 10923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000547")]
	private protected bool IsMadness
	{
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x2188670", Offset = "0x2188771", VA = "0x2188670")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A27D0", Offset = "0x1A28D1")]
		protected get
		{
			return default(bool);
		}
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x2188660", Offset = "0x2188761", VA = "0x2188660")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A27C0", Offset = "0x1A28C1")]
		private set
		{
		}
	}

	// Token: 0x06002AAD RID: 10925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023F4")]
	[Address(RVA = "0x2188680", Offset = "0x2188781", VA = "0x2188680")]
	public void SetFirstDeadFlag(bool isFristDead)
	{
	}

	// Token: 0x06002AAE RID: 10926 RVA: 0x00010680 File Offset: 0x0000E880
	[Token(Token = "0x60023F5")]
	[Address(RVA = "0x2188690", Offset = "0x2188791", VA = "0x2188690", Slot = "152")]
	protected override bool CanFriend()
	{
		return default(bool);
	}

	// Token: 0x06002AAF RID: 10927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023F6")]
	[Address(RVA = "0x21886B0", Offset = "0x21887B1", VA = "0x21886B0", Slot = "122")]
	protected override void DoDropItem()
	{
	}

	// Token: 0x06002AB0 RID: 10928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023F7")]
	[Address(RVA = "0x21886D0", Offset = "0x21887D1", VA = "0x21886D0", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002AB1 RID: 10929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023F8")]
	[Address(RVA = "0x21887F0", Offset = "0x21888F1", VA = "0x21887F0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002AB2 RID: 10930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023F9")]
	[Address(RVA = "0x2188A50", Offset = "0x2188B51", VA = "0x2188A50", Slot = "134")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002AB3 RID: 10931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023FA")]
	[Address(RVA = "0x2188B00", Offset = "0x2188C01", VA = "0x2188B00", Slot = "135")]
	public override void OnRelease()
	{
	}

	// Token: 0x06002AB4 RID: 10932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023FB")]
	[Address(RVA = "0x2188BB0", Offset = "0x2188CB1", VA = "0x2188BB0", Slot = "20")]
	public override void OnEvent(int index)
	{
	}

	// Token: 0x06002AB5 RID: 10933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023FC")]
	[Address(RVA = "0x2188C20", Offset = "0x2188D21", VA = "0x2188C20", Slot = "113")]
	protected override void OnTakeDamage(bool isDamage, ref DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x06002AB6 RID: 10934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023FD")]
	[Address(RVA = "0x2188CD0", Offset = "0x2188DD1", VA = "0x2188CD0", Slot = "154")]
	public virtual void CreateMadnessEffect(ParticleSystem prefab, List<string> boneNameList, float scaleValue)
	{
	}

	// Token: 0x06002AB7 RID: 10935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023FE")]
	[Address(RVA = "0x2188820", Offset = "0x2188921", VA = "0x2188820")]
	protected void DestroyProjectileList()
	{
	}

	// Token: 0x06002AB8 RID: 10936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023FF")]
	[Address(RVA = "0x21890A0", Offset = "0x21891A1", VA = "0x21890A0", Slot = "155")]
	protected virtual void OnForceDestroyProjectile(MonsterProjectileActionScriptsController projectileActionScriptsController)
	{
	}

	// Token: 0x06002AB9 RID: 10937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002400")]
	[Address(RVA = "0x21890B0", Offset = "0x21891B1", VA = "0x21890B0")]
	public BossMonsterContoroller()
	{
	}

	// Token: 0x06002ABA RID: 10938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002401")]
	[Address(RVA = "0x2189190", Offset = "0x2189291", VA = "0x2189190")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A27E0", Offset = "0x1A28E1")]
	private void <OnSetup>b__12_0(MonsterProjectileActionScriptsController projectileActionScriptsController, int _)
	{
	}

	// Token: 0x06002ABB RID: 10939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002402")]
	[Address(RVA = "0x21892A0", Offset = "0x21893A1", VA = "0x21892A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A27F0", Offset = "0x1A28F1")]
	private void <OnSetup>b__12_1(BulletBase bullet)
	{
	}

	// Token: 0x04007269 RID: 29289
	[Token(Token = "0x4006A01")]
	[FieldOffset(Offset = "0x4E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1695D0", Offset = "0x1696D1")]
	private bool <IsMadness>k__BackingField;

	// Token: 0x0400726A RID: 29290
	[Token(Token = "0x4006A02")]
	[FieldOffset(Offset = "0x4E9")]
	protected bool IsCreateMadnessEffect;

	// Token: 0x0400726B RID: 29291
	[Token(Token = "0x4006A03")]
	[FieldOffset(Offset = "0x4EA")]
	protected bool IsFirstDead;

	// Token: 0x0400726C RID: 29292
	[Token(Token = "0x4006A04")]
	[FieldOffset(Offset = "0x4F0")]
	protected List<ParticleSystem> MadnessEffectList;

	// Token: 0x0400726D RID: 29293
	[Token(Token = "0x4006A05")]
	[FieldOffset(Offset = "0x4F8")]
	protected List<MonsterProjectileActionScriptsController> MonsterProjectileList;

	// Token: 0x0400726E RID: 29294
	[Token(Token = "0x4006A06")]
	[FieldOffset(Offset = "0x500")]
	private List<BulletBase> BulletBaseList;

	// Token: 0x020006CD RID: 1741
	[Token(Token = "0x200117E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158350", Offset = "0x158451")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x06002ABC RID: 10940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A4")]
		[Address(RVA = "0x2189290", Offset = "0x2189391", VA = "0x2189290")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A5")]
		[Address(RVA = "0x21893B0", Offset = "0x21894B1", VA = "0x21893B0")]
		internal void <OnSetup>b__2()
		{
		}

		// Token: 0x0400726F RID: 29295
		[Token(Token = "0x40194D6")]
		[FieldOffset(Offset = "0x10")]
		public MonsterProjectileActionScriptsController projectileActionScriptsController;

		// Token: 0x04007270 RID: 29296
		[Token(Token = "0x40194D7")]
		[FieldOffset(Offset = "0x18")]
		public BossMonsterContoroller <>4__this;
	}

	// Token: 0x020006CE RID: 1742
	[Token(Token = "0x200117F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158360", Offset = "0x158461")]
	private sealed class <>c__DisplayClass12_1
	{
		// Token: 0x06002ABE RID: 10942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A6")]
		[Address(RVA = "0x21893A0", Offset = "0x21894A1", VA = "0x21893A0")]
		public <>c__DisplayClass12_1()
		{
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A7")]
		[Address(RVA = "0x2189450", Offset = "0x2189551", VA = "0x2189450")]
		internal void <OnSetup>b__3()
		{
		}

		// Token: 0x04007271 RID: 29297
		[Token(Token = "0x40194D8")]
		[FieldOffset(Offset = "0x10")]
		public BulletBase bullet;

		// Token: 0x04007272 RID: 29298
		[Token(Token = "0x40194D9")]
		[FieldOffset(Offset = "0x18")]
		public BossMonsterContoroller <>4__this;
	}
}
