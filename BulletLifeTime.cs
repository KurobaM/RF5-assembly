using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200018F RID: 399
[Token(Token = "0x200013A")]
[Serializable]
public class BulletLifeTime : BulletSubModule
{
	// Token: 0x06000836 RID: 2102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000706")]
	[Address(RVA = "0x21975B0", Offset = "0x21976B1", VA = "0x21975B0", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000707")]
	[Address(RVA = "0x2197670", Offset = "0x2197771", VA = "0x2197670", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000708")]
	[Address(RVA = "0x21976B0", Offset = "0x21977B1", VA = "0x21976B0", Slot = "12")]
	public override void DoExtension(BulletBase bullet)
	{
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000709")]
	[Address(RVA = "0x21976F0", Offset = "0x21977F1", VA = "0x21976F0")]
	public BulletLifeTime()
	{
	}

	// Token: 0x040004D7 RID: 1239
	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float maxDuration;
}
