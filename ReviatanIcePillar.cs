using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200075E RID: 1886
[Token(Token = "0x2000511")]
public class ReviatanIcePillar : MonoBehaviour
{
	// Token: 0x0600306F RID: 12399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028AF")]
	[Address(RVA = "0x2492180", Offset = "0x2492281", VA = "0x2492180")]
	private void OnDestroy()
	{
	}

	// Token: 0x06003070 RID: 12400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028B0")]
	[Address(RVA = "0x24921A0", Offset = "0x24922A1", VA = "0x24921A0")]
	private void Start()
	{
	}

	// Token: 0x06003071 RID: 12401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028B1")]
	[Address(RVA = "0x2491B10", Offset = "0x2491C11", VA = "0x2491B10")]
	public void Setup(MonsterProjectileActionScriptsController projectile, Action destoryCallback)
	{
	}

	// Token: 0x06003072 RID: 12402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028B2")]
	[Address(RVA = "0x2492220", Offset = "0x2492321", VA = "0x2492220")]
	private void Update()
	{
	}

	// Token: 0x06003073 RID: 12403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028B3")]
	[Address(RVA = "0x2490AD0", Offset = "0x2490BD1", VA = "0x2490AD0")]
	public void End()
	{
	}

	// Token: 0x06003074 RID: 12404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028B4")]
	[Address(RVA = "0x24922E0", Offset = "0x24923E1", VA = "0x24922E0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06003075 RID: 12405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028B5")]
	[Address(RVA = "0x2492400", Offset = "0x2492501", VA = "0x2492400")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x06003076 RID: 12406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028B6")]
	[Address(RVA = "0x24925B0", Offset = "0x24926B1", VA = "0x24925B0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06003077 RID: 12407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028B7")]
	[Address(RVA = "0x2492710", Offset = "0x2492811", VA = "0x2492710")]
	public ReviatanIcePillar()
	{
	}

	// Token: 0x06003078 RID: 12408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028B8")]
	[Address(RVA = "0x2492720", Offset = "0x2492821", VA = "0x2492720")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4290", Offset = "0x1A4391")]
	private void <Setup>b__9_0(Collider other)
	{
	}

	// Token: 0x06003079 RID: 12409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028B9")]
	[Address(RVA = "0x2492850", Offset = "0x2492951", VA = "0x2492850")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A42A0", Offset = "0x1A43A1")]
	private void <Setup>b__9_1()
	{
	}

	// Token: 0x040075D1 RID: 30161
	[Token(Token = "0x4006C00")]
	[FieldOffset(Offset = "0x18")]
	private MonsterProjectileActionScriptsController Projectile;

	// Token: 0x040075D2 RID: 30162
	[Token(Token = "0x4006C01")]
	[FieldOffset(Offset = "0x20")]
	private Collider Collider;

	// Token: 0x040075D3 RID: 30163
	[Token(Token = "0x4006C02")]
	private const float HIT_END_TIME = 1f;

	// Token: 0x040075D4 RID: 30164
	[Token(Token = "0x4006C03")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ParticleSystem EndParticle;

	// Token: 0x040075D5 RID: 30165
	[Token(Token = "0x4006C04")]
	[FieldOffset(Offset = "0x30")]
	private float EndTime;

	// Token: 0x040075D6 RID: 30166
	[Token(Token = "0x4006C05")]
	[FieldOffset(Offset = "0x38")]
	private Action DestroyCallback;

	// Token: 0x040075D7 RID: 30167
	[Token(Token = "0x4006C06")]
	[FieldOffset(Offset = "0x40")]
	private bool isHit;
}
