using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000390 RID: 912
[Token(Token = "0x20002B8")]
[Serializable]
public class MagicTarget
{
	// Token: 0x0600170B RID: 5899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001477")]
	[Address(RVA = "0x1F15600", Offset = "0x1F15701", VA = "0x1F15600")]
	public MagicTarget()
	{
	}

	// Token: 0x04000FFA RID: 4090
	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public TargetType Type;

	// Token: 0x04000FFB RID: 4091
	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float Radius;

	// Token: 0x04000FFC RID: 4092
	[Token(Token = "0x4000CB0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public TargetAlliance Alliance;

	// Token: 0x04000FFD RID: 4093
	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public bool InSelf;

	// Token: 0x04000FFE RID: 4094
	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int Max;
}
