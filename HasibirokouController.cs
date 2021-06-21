using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000708 RID: 1800
[Token(Token = "0x20004EE")]
public class HasibirokouController : BossMonsterContoroller
{
	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x06002D41 RID: 11585 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002D42 RID: 11586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000560")]
	public List<HasibirokouSonicWind> HasibirokouSonicWinds
	{
		[Token(Token = "0x6002628")]
		[Address(RVA = "0x24ECDF0", Offset = "0x24ECEF1", VA = "0x24ECDF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A33D0", Offset = "0x1A34D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002629")]
		[Address(RVA = "0x24ECE00", Offset = "0x24ECF01", VA = "0x24ECE00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A33E0", Offset = "0x1A34E1")]
		private set
		{
		}
	}

	// Token: 0x06002D43 RID: 11587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600262A")]
	[Address(RVA = "0x24ECE10", Offset = "0x24ECF11", VA = "0x24ECE10", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002D44 RID: 11588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600262B")]
	[Address(RVA = "0x24ECED0", Offset = "0x24ECFD1", VA = "0x24ECED0")]
	private void CreateProjectile(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002D45 RID: 11589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600262C")]
	[Address(RVA = "0x24ED250", Offset = "0x24ED351", VA = "0x24ED250")]
	private void UpdateBulletPointRotation()
	{
	}

	// Token: 0x06002D46 RID: 11590 RVA: 0x00010B30 File Offset: 0x0000ED30
	[Token(Token = "0x600262D")]
	[Address(RVA = "0x24ED450", Offset = "0x24ED551", VA = "0x24ED450")]
	private float GetAngleX(Transform transform, float min, float max)
	{
		return 0f;
	}

	// Token: 0x06002D47 RID: 11591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600262E")]
	[Address(RVA = "0x24ED600", Offset = "0x24ED701", VA = "0x24ED600", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002D48 RID: 11592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600262F")]
	[Address(RVA = "0x24EDB30", Offset = "0x24EDC31", VA = "0x24EDB30", Slot = "133")]
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002D49 RID: 11593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002630")]
	[Address(RVA = "0x24EDF50", Offset = "0x24EE051", VA = "0x24EDF50", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002D4A RID: 11594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002631")]
	[Address(RVA = "0x24EDFF0", Offset = "0x24EE0F1", VA = "0x24EDFF0")]
	public HasibirokouController()
	{
	}

	// Token: 0x040073D6 RID: 29654
	[Token(Token = "0x4006AD0")]
	[FieldOffset(Offset = "0x508")]
	[SerializeField]
	private Transform LaserPointTransform;

	// Token: 0x040073D7 RID: 29655
	[Token(Token = "0x4006AD1")]
	[FieldOffset(Offset = "0x510")]
	[SerializeField]
	private Transform[] BulletPointTransforms;

	// Token: 0x040073D8 RID: 29656
	[Token(Token = "0x4006AD2")]
	[FieldOffset(Offset = "0x518")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1697E0", Offset = "0x1698E1")]
	private List<HasibirokouSonicWind> <HasibirokouSonicWinds>k__BackingField;

	// Token: 0x040073D9 RID: 29657
	[Token(Token = "0x4006AD3")]
	[FieldOffset(Offset = "0x520")]
	private float SonicWindSweepSpeed;

	// Token: 0x02000709 RID: 1801
	[Token(Token = "0x20011A1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158450", Offset = "0x158551")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x06002D4B RID: 11595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007204")]
		[Address(RVA = "0x24ED200", Offset = "0x24ED301", VA = "0x24ED200")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007205")]
		[Address(RVA = "0x24EE090", Offset = "0x24EE191", VA = "0x24EE090")]
		internal void <CreateProjectile>b__0()
		{
		}

		// Token: 0x040073DA RID: 29658
		[Token(Token = "0x401956F")]
		[FieldOffset(Offset = "0x10")]
		public HasibirokouController <>4__this;

		// Token: 0x040073DB RID: 29659
		[Token(Token = "0x4019570")]
		[FieldOffset(Offset = "0x18")]
		public HasibirokouSonicWind wind;
	}

	// Token: 0x0200070A RID: 1802
	[Token(Token = "0x20011A2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158460", Offset = "0x158561")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x06002D4D RID: 11597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007206")]
		[Address(RVA = "0x24EDDB0", Offset = "0x24EDEB1", VA = "0x24EDDB0")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007207")]
		[Address(RVA = "0x24EE070", Offset = "0x24EE171", VA = "0x24EE070")]
		internal void <OnUniqueProjectileActionCommandInternal>b__0(float x)
		{
		}

		// Token: 0x040073DC RID: 29660
		[Token(Token = "0x4019571")]
		[FieldOffset(Offset = "0x10")]
		public ProjectileBulletBase bullet;
	}
}
