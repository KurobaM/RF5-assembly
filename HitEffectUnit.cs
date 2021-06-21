using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000605 RID: 1541
[Token(Token = "0x2000456")]
[Serializable]
public class HitEffectUnit : HitEffectBase
{
	// Token: 0x06002625 RID: 9765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600202D")]
	[Address(RVA = "0x24F6420", Offset = "0x24F6521", VA = "0x24F6420")]
	public HitEffectUnit()
	{
	}

	// Token: 0x06002626 RID: 9766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600202E")]
	[Address(RVA = "0x24F64F0", Offset = "0x24F65F1", VA = "0x24F64F0")]
	public void Start()
	{
	}

	// Token: 0x06002627 RID: 9767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600202F")]
	[Address(RVA = "0x24F6510", Offset = "0x24F6611", VA = "0x24F6510")]
	public void End()
	{
	}

	// Token: 0x06002628 RID: 9768 RVA: 0x0000F150 File Offset: 0x0000D350
	[Token(Token = "0x6002030")]
	[Address(RVA = "0x24F6520", Offset = "0x24F6621", VA = "0x24F6520")]
	public bool Update(float time)
	{
		return default(bool);
	}

	// Token: 0x06002629 RID: 9769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002031")]
	[Address(RVA = "0x24F6560", Offset = "0x24F6661", VA = "0x24F6560")]
	public void Copy(HitEffectUnit effectUnit)
	{
	}

	// Token: 0x04006D5E RID: 27998
	[Token(Token = "0x4006668")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public float StartSec;

	// Token: 0x04006D5F RID: 27999
	[Token(Token = "0x4006669")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public HumanJointIDEnum Joint;

	// Token: 0x04006D60 RID: 28000
	[Token(Token = "0x400666A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public bool IsWorld;

	// Token: 0x04006D61 RID: 28001
	[Token(Token = "0x400666B")]
	[FieldOffset(Offset = "0x54")]
	public HitEffectUnit.STATE State;

	// Token: 0x02000606 RID: 1542
	[Token(Token = "0x2001138")]
	public enum STATE
	{
		// Token: 0x04006D63 RID: 28003
		[Token(Token = "0x401936A")]
		END,
		// Token: 0x04006D64 RID: 28004
		[Token(Token = "0x401936B")]
		IDLE,
		// Token: 0x04006D65 RID: 28005
		[Token(Token = "0x401936C")]
		DISP,
		// Token: 0x04006D66 RID: 28006
		[Token(Token = "0x401936D")]
		Length
	}
}
