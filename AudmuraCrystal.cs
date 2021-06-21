using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006BD RID: 1725
[Token(Token = "0x20004D0")]
public class AudmuraCrystal : CharacterBase
{
	// Token: 0x17000698 RID: 1688
	// (get) Token: 0x06002A1F RID: 10783 RVA: 0x000104E8 File Offset: 0x0000E6E8
	[Token(Token = "0x17000540")]
	public override Alliance Alliance
	{
		[Token(Token = "0x600237A")]
		[Address(RVA = "0x228E4E0", Offset = "0x228E5E1", VA = "0x228E4E0", Slot = "8")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x17000699 RID: 1689
	// (get) Token: 0x06002A20 RID: 10784 RVA: 0x00010500 File Offset: 0x0000E700
	[Token(Token = "0x17000541")]
	public override Vector3 GetTakeLockonPos
	{
		[Token(Token = "0x600237B")]
		[Address(RVA = "0x228E4F0", Offset = "0x228E5F1", VA = "0x228E4F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06002A21 RID: 10785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600237C")]
	[Address(RVA = "0x228E5D0", Offset = "0x228E6D1", VA = "0x228E5D0", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002A22 RID: 10786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600237D")]
	[Address(RVA = "0x228DC20", Offset = "0x228DD21", VA = "0x228DC20")]
	public void CreateEffect(bool isVariation)
	{
	}

	// Token: 0x06002A23 RID: 10787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600237E")]
	[Address(RVA = "0x228E610", Offset = "0x228E711", VA = "0x228E610")]
	public void Setup(MonsterProjectileActionScriptsController projectile, int maxHP)
	{
	}

	// Token: 0x06002A24 RID: 10788 RVA: 0x00010518 File Offset: 0x0000E718
	[Token(Token = "0x600237F")]
	[Address(RVA = "0x228E800", Offset = "0x228E901", VA = "0x228E800", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
	{
		return default(bool);
	}

	// Token: 0x06002A25 RID: 10789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002380")]
	[Address(RVA = "0x228E080", Offset = "0x228E181", VA = "0x228E080")]
	public void End()
	{
	}

	// Token: 0x06002A26 RID: 10790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002381")]
	[Address(RVA = "0x228E8F0", Offset = "0x228E9F1", VA = "0x228E8F0")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x06002A27 RID: 10791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002382")]
	[Address(RVA = "0x228EAA0", Offset = "0x228EBA1", VA = "0x228EAA0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06002A28 RID: 10792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002383")]
	[Address(RVA = "0x228EC00", Offset = "0x228ED01", VA = "0x228EC00")]
	public AudmuraCrystal()
	{
	}

	// Token: 0x06002A29 RID: 10793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002384")]
	[Address(RVA = "0x228EC10", Offset = "0x228ED11", VA = "0x228EC10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2610", Offset = "0x1A2711")]
	private void <CreateEffect>b__10_0(ParticleSystem particle)
	{
	}

	// Token: 0x06002A2A RID: 10794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002385")]
	[Address(RVA = "0x228ED70", Offset = "0x228EE71", VA = "0x228ED70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2620", Offset = "0x1A2721")]
	private void <CreateEffect>b__10_1(ParticleSystem particle)
	{
	}

	// Token: 0x06002A2B RID: 10795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002386")]
	[Address(RVA = "0x228EEF0", Offset = "0x228EFF1", VA = "0x228EEF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2630", Offset = "0x1A2731")]
	private void <CreateEffect>b__10_2(ParticleSystem particle)
	{
	}

	// Token: 0x06002A2C RID: 10796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002387")]
	[Address(RVA = "0x228F050", Offset = "0x228F151", VA = "0x228F050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2640", Offset = "0x1A2741")]
	private void <CreateEffect>b__10_3(ParticleSystem particle)
	{
	}

	// Token: 0x06002A2D RID: 10797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002388")]
	[Address(RVA = "0x228F1D0", Offset = "0x228F2D1", VA = "0x228F1D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2650", Offset = "0x1A2751")]
	private void <Setup>b__11_0(Collider other)
	{
	}

	// Token: 0x06002A2E RID: 10798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002389")]
	[Address(RVA = "0x228F300", Offset = "0x228F401", VA = "0x228F300")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2660", Offset = "0x1A2761")]
	private void <Setup>b__11_1()
	{
	}

	// Token: 0x04007212 RID: 29202
	[Token(Token = "0x40069D1")]
	[FieldOffset(Offset = "0x68")]
	private MonsterProjectileActionScriptsController MonsterProjectileActionScriptsController;

	// Token: 0x04007213 RID: 29203
	[Token(Token = "0x40069D2")]
	[FieldOffset(Offset = "0x70")]
	private InstantCountStatus Status;

	// Token: 0x04007214 RID: 29204
	[Token(Token = "0x40069D3")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private ParticleSystem CrystalPartileSystem;

	// Token: 0x04007215 RID: 29205
	[Token(Token = "0x40069D4")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private ParticleSystem EndParticleSystem;

	// Token: 0x04007216 RID: 29206
	[Token(Token = "0x40069D5")]
	[FieldOffset(Offset = "0x88")]
	private bool isHit;
}
