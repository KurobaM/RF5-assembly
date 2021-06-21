using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200075F RID: 1887
[Token(Token = "0x2000512")]
public class ReviatanWave : MonoBehaviour
{
	// Token: 0x0600307A RID: 12410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028BA")]
	[Address(RVA = "0x2490E90", Offset = "0x2490F91", VA = "0x2490E90")]
	public void Setup(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController)
	{
	}

	// Token: 0x0600307B RID: 12411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028BB")]
	[Address(RVA = "0x2492880", Offset = "0x2492981", VA = "0x2492880")]
	private void Update()
	{
	}

	// Token: 0x0600307C RID: 12412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028BC")]
	[Address(RVA = "0x24929B0", Offset = "0x2492AB1", VA = "0x24929B0")]
	public void End()
	{
	}

	// Token: 0x0600307D RID: 12413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028BD")]
	[Address(RVA = "0x2492B40", Offset = "0x2492C41", VA = "0x2492B40")]
	public ReviatanWave()
	{
	}

	// Token: 0x0600307E RID: 12414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028BE")]
	[Address(RVA = "0x2492B50", Offset = "0x2492C51", VA = "0x2492B50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A42B0", Offset = "0x1A43B1")]
	private void <Setup>b__3_0(Collider _)
	{
	}

	// Token: 0x0600307F RID: 12415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028BF")]
	[Address(RVA = "0x2492B60", Offset = "0x2492C61", VA = "0x2492B60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A42C0", Offset = "0x1A43C1")]
	private void <End>b__5_0()
	{
	}

	// Token: 0x040075D8 RID: 30168
	[Token(Token = "0x4006C07")]
	private const float SCALE_DOWN_SEC = 0.8f;

	// Token: 0x040075D9 RID: 30169
	[Token(Token = "0x4006C08")]
	[FieldOffset(Offset = "0x18")]
	private bool IsEnd;

	// Token: 0x040075DA RID: 30170
	[Token(Token = "0x4006C09")]
	[FieldOffset(Offset = "0x20")]
	private MonsterProjectileActionScriptsController Projectile;
}
