using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DA RID: 730
[Token(Token = "0x200023A")]
[Serializable]
public class RestraintSource
{
	// Token: 0x0600137E RID: 4990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x248DAF0", Offset = "0x248DBF1", VA = "0x248DAF0")]
	public RestraintSource()
	{
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x248DB30", Offset = "0x248DC31", VA = "0x248DB30")]
	public RestraintSource(Transform source, float _weight)
	{
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x248DB80", Offset = "0x248DC81", VA = "0x248DB80")]
	public RestraintSource(RestraintSource source)
	{
	}

	// Token: 0x04000AEB RID: 2795
	[Token(Token = "0x4000887")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public Transform sourceTransform;

	// Token: 0x04000AEC RID: 2796
	[Token(Token = "0x4000888")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15F460", Offset = "0x15F561")]
	public float weight;
}
