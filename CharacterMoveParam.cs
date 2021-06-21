using System;
using Il2CppDummyDll;

// Token: 0x0200034D RID: 845
[Token(Token = "0x200027C")]
[Serializable]
public class CharacterMoveParam
{
	// Token: 0x06001657 RID: 5719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x1E8F980", Offset = "0x1E8FA81", VA = "0x1E8F980")]
	public CharacterMoveParam()
	{
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x1E8F990", Offset = "0x1E8FA91", VA = "0x1E8F990")]
	public CharacterMoveParam(float speed, float acceleration, float deceleration, float rotate)
	{
	}

	// Token: 0x04000E32 RID: 3634
	[Token(Token = "0x4000B13")]
	[FieldOffset(Offset = "0x10")]
	public float SpeedMax;

	// Token: 0x04000E33 RID: 3635
	[Token(Token = "0x4000B14")]
	[FieldOffset(Offset = "0x14")]
	public float SpeedMin;

	// Token: 0x04000E34 RID: 3636
	[Token(Token = "0x4000B15")]
	[FieldOffset(Offset = "0x18")]
	public float AccelerationMax;

	// Token: 0x04000E35 RID: 3637
	[Token(Token = "0x4000B16")]
	[FieldOffset(Offset = "0x1C")]
	public float AccelerationMin;

	// Token: 0x04000E36 RID: 3638
	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0x20")]
	public float Deceleration;

	// Token: 0x04000E37 RID: 3639
	[Token(Token = "0x4000B18")]
	[FieldOffset(Offset = "0x24")]
	public float RotateSpeedMax;

	// Token: 0x04000E38 RID: 3640
	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0x28")]
	public float RotateSpeedMin;
}
