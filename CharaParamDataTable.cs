using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000347 RID: 839
[Token(Token = "0x2000276")]
[Serializable]
public class CharaParamDataTable
{
	// Token: 0x0600164F RID: 5711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x1E84E80", Offset = "0x1E84F81", VA = "0x1E84E80")]
	public CharaParamDataTable()
	{
	}

	// Token: 0x04000E1A RID: 3610
	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int StartLevel;

	// Token: 0x04000E1B RID: 3611
	[Token(Token = "0x4000AFC")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Exp;

	// Token: 0x04000E1C RID: 3612
	[Token(Token = "0x4000AFD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int WalkSpeed;

	// Token: 0x04000E1D RID: 3613
	[Token(Token = "0x4000AFE")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int RunSpeed;

	// Token: 0x04000E1E RID: 3614
	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Parameter StartParameter;

	// Token: 0x04000E1F RID: 3615
	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	public int StrRate;

	// Token: 0x04000E20 RID: 3616
	[Token(Token = "0x4000B01")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public int IntRate;

	// Token: 0x04000E21 RID: 3617
	[Token(Token = "0x4000B02")]
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	public int VitRate;

	// Token: 0x04000E22 RID: 3618
	[Token(Token = "0x4000B03")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	public float StrUp;

	// Token: 0x04000E23 RID: 3619
	[Token(Token = "0x4000B04")]
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	public float IntUp;

	// Token: 0x04000E24 RID: 3620
	[Token(Token = "0x4000B05")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public float VitUp;

	// Token: 0x04000E25 RID: 3621
	[Token(Token = "0x4000B06")]
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	public int AtkRate;

	// Token: 0x04000E26 RID: 3622
	[Token(Token = "0x4000B07")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	public int MAtkRate;

	// Token: 0x04000E27 RID: 3623
	[Token(Token = "0x4000B08")]
	[FieldOffset(Offset = "0xFC")]
	[SerializeField]
	public int DefRate;

	// Token: 0x04000E28 RID: 3624
	[Token(Token = "0x4000B09")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public int MDefRate;

	// Token: 0x04000E29 RID: 3625
	[Token(Token = "0x4000B0A")]
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	public int HPRate;
}
