using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000341 RID: 833
[Token(Token = "0x2000270")]
[Serializable]
public class BitParam
{
	// Token: 0x06001643 RID: 5699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x2456180", Offset = "0x2456281", VA = "0x2456180")]
	public BitParam()
	{
	}

	// Token: 0x04000DB1 RID: 3505
	[Token(Token = "0x4000A92")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public BulletID BulletID;

	// Token: 0x04000DB2 RID: 3506
	[Token(Token = "0x4000A93")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public bool OneShot;

	// Token: 0x04000DB3 RID: 3507
	[Token(Token = "0x4000A94")]
	[FieldOffset(Offset = "0x15")]
	[SerializeField]
	public bool Homing;

	// Token: 0x04000DB4 RID: 3508
	[Token(Token = "0x4000A95")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public BitShotToward ShotToward;

	// Token: 0x04000DB5 RID: 3509
	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public BitShotTiming ShotTiming;

	// Token: 0x04000DB6 RID: 3510
	[Token(Token = "0x4000A97")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float ShotCoolTime;

	// Token: 0x04000DB7 RID: 3511
	[Token(Token = "0x4000A98")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float LifeTime;

	// Token: 0x04000DB8 RID: 3512
	[Token(Token = "0x4000A99")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float MaxDistance;

	// Token: 0x04000DB9 RID: 3513
	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float SearchRange;

	// Token: 0x04000DBA RID: 3514
	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float SearchAngle;
}
