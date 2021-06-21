using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200070E RID: 1806
[Token(Token = "0x20004F2")]
public class HekatonkeilController : BossMonsterContoroller
{
	// Token: 0x06002D7F RID: 11647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002662")]
	[Address(RVA = "0x24F2380", Offset = "0x24F2481", VA = "0x24F2380", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002D80 RID: 11648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002663")]
	[Address(RVA = "0x24F2430", Offset = "0x24F2531", VA = "0x24F2430", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002D81 RID: 11649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002664")]
	[Address(RVA = "0x24F2600", Offset = "0x24F2701", VA = "0x24F2600")]
	public void ReSetProjectile()
	{
	}

	// Token: 0x06002D82 RID: 11650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002665")]
	[Address(RVA = "0x24F2610", Offset = "0x24F2711", VA = "0x24F2610", Slot = "133")]
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002D83 RID: 11651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002666")]
	[Address(RVA = "0x24F2AD0", Offset = "0x24F2BD1", VA = "0x24F2AD0")]
	public HekatonkeilController()
	{
	}

	// Token: 0x06002D84 RID: 11652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002667")]
	[Address(RVA = "0x24F2AE0", Offset = "0x24F2BE1", VA = "0x24F2AE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3510", Offset = "0x1A3611")]
	private void <OnSetup>b__6_0(ParticleSystem particle)
	{
	}

	// Token: 0x040073EA RID: 29674
	[Token(Token = "0x4006AE1")]
	private const float THROW_THRESHOLD = 0.2f;

	// Token: 0x040073EB RID: 29675
	[Token(Token = "0x4006AE2")]
	[FieldOffset(Offset = "0x508")]
	private ParticleSystem OmenParticleSystem;

	// Token: 0x040073EC RID: 29676
	[Token(Token = "0x4006AE3")]
	[FieldOffset(Offset = "0x510")]
	private int FootStepCount;

	// Token: 0x040073ED RID: 29677
	[Token(Token = "0x4006AE4")]
	[FieldOffset(Offset = "0x514")]
	private int FootStepCountMax;

	// Token: 0x040073EE RID: 29678
	[Token(Token = "0x4006AE5")]
	[FieldOffset(Offset = "0x518")]
	private int RoundCount;

	// Token: 0x040073EF RID: 29679
	[Token(Token = "0x4006AE6")]
	[FieldOffset(Offset = "0x51C")]
	private int RoundCountMax;
}
