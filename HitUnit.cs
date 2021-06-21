using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200060B RID: 1547
[Token(Token = "0x200045A")]
[Serializable]
public class HitUnit
{
	// Token: 0x06002653 RID: 9811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002057")]
	[Address(RVA = "0x24F87B0", Offset = "0x24F88B1", VA = "0x24F87B0")]
	public HitUnit(HitSystem hitSystem)
	{
	}

	// Token: 0x06002654 RID: 9812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002058")]
	[Address(RVA = "0x24F8A00", Offset = "0x24F8B01", VA = "0x24F8A00")]
	public void CheckTime()
	{
	}

	// Token: 0x06002655 RID: 9813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002059")]
	[Address(RVA = "0x24F8A10", Offset = "0x24F8B11", VA = "0x24F8A10")]
	public void Copy(HitUnit unit)
	{
	}

	// Token: 0x06002656 RID: 9814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600205A")]
	[Address(RVA = "0x24F8BD0", Offset = "0x24F8CD1", VA = "0x24F8BD0")]
	public void OnHitTriggerEnter(Collider collider)
	{
	}

	// Token: 0x06002657 RID: 9815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600205B")]
	[Address(RVA = "0x24F8870", Offset = "0x24F8971", VA = "0x24F8870")]
	[Attribute(Name = "ContextMenu", RVA = "0x1A1AA0", Offset = "0x1A1BA1")]
	public void ResetHitUnit()
	{
	}

	// Token: 0x04006D75 RID: 28021
	[Token(Token = "0x400667A")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public HitSystem HitSystem;

	// Token: 0x04006D76 RID: 28022
	[Token(Token = "0x400667B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public HitData HitData;

	// Token: 0x04006D77 RID: 28023
	[Token(Token = "0x400667C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float StartSec;

	// Token: 0x04006D78 RID: 28024
	[Token(Token = "0x400667D")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float EndSec;

	// Token: 0x04006D79 RID: 28025
	[Token(Token = "0x400667E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x168270", Offset = "0x168371")]
	public int HitGroup;

	// Token: 0x04006D7A RID: 28026
	[Token(Token = "0x400667F")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float EnableSec;

	// Token: 0x04006D7B RID: 28027
	[Token(Token = "0x4006680")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public HitOptionParamID HitOptionParamID;

	// Token: 0x04006D7C RID: 28028
	[Token(Token = "0x4006681")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public HitOption hitOption;

	// Token: 0x04006D7D RID: 28029
	[Token(Token = "0x4006682")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public HitEffectBase[] HitEffects;

	// Token: 0x04006D7E RID: 28030
	[Token(Token = "0x4006683")]
	[FieldOffset(Offset = "0x48")]
	public HitUnit.STATE State;

	// Token: 0x0200060C RID: 1548
	[Token(Token = "0x200113A")]
	public enum STATE
	{
		// Token: 0x04006D80 RID: 28032
		[Token(Token = "0x401936F")]
		END,
		// Token: 0x04006D81 RID: 28033
		[Token(Token = "0x4019370")]
		IDLE,
		// Token: 0x04006D82 RID: 28034
		[Token(Token = "0x4019371")]
		HIT,
		// Token: 0x04006D83 RID: 28035
		[Token(Token = "0x4019372")]
		Length
	}
}
