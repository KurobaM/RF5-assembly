using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200077F RID: 1919
[Token(Token = "0x2000520")]
public class YadokariWave : MonoBehaviour
{
	// Token: 0x060031A7 RID: 12711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029AF")]
	[Address(RVA = "0x284E4B0", Offset = "0x284E5B1", VA = "0x284E4B0")]
	public void Setup(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController)
	{
	}

	// Token: 0x060031A8 RID: 12712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029B0")]
	[Address(RVA = "0x284E4C0", Offset = "0x284E5C1", VA = "0x284E4C0")]
	private void Update()
	{
	}

	// Token: 0x060031A9 RID: 12713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029B1")]
	[Address(RVA = "0x284E550", Offset = "0x284E651", VA = "0x284E550")]
	public void End()
	{
	}

	// Token: 0x060031AA RID: 12714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029B2")]
	[Address(RVA = "0x284E6E0", Offset = "0x284E7E1", VA = "0x284E6E0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060031AB RID: 12715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029B3")]
	[Address(RVA = "0x284E7D0", Offset = "0x284E8D1", VA = "0x284E7D0")]
	public YadokariWave()
	{
	}

	// Token: 0x060031AC RID: 12716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029B4")]
	[Address(RVA = "0x284E7E0", Offset = "0x284E8E1", VA = "0x284E7E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A47C0", Offset = "0x1A48C1")]
	private void <End>b__5_0()
	{
	}

	// Token: 0x0400766C RID: 30316
	[Token(Token = "0x4006C5E")]
	private const float SCALE_DOWN_SEC = 0.8f;

	// Token: 0x0400766D RID: 30317
	[Token(Token = "0x4006C5F")]
	[FieldOffset(Offset = "0x18")]
	private bool IsEnd;

	// Token: 0x0400766E RID: 30318
	[Token(Token = "0x4006C60")]
	[FieldOffset(Offset = "0x20")]
	private MonsterProjectileActionScriptsController Projectile;
}
