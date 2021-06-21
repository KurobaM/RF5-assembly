using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200095B RID: 2395
[Token(Token = "0x2000648")]
[Serializable]
public class AdvScriptDefCountData : ScriptableObject
{
	// Token: 0x06003F7F RID: 16255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034D6")]
	[Address(RVA = "0x2431ED0", Offset = "0x2431FD1", VA = "0x2431ED0")]
	public void Init()
	{
	}

	// Token: 0x06003F80 RID: 16256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034D7")]
	[Address(RVA = "0x2432540", Offset = "0x2432641", VA = "0x2432540")]
	public void SetScriptType(int[][] values)
	{
	}

	// Token: 0x06003F81 RID: 16257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034D8")]
	[Address(RVA = "0x24326F0", Offset = "0x24327F1", VA = "0x24326F0")]
	public AdvScriptDefCountData()
	{
	}

	// Token: 0x04008102 RID: 33026
	[Token(Token = "0x4007424")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public AdvScriptDefCountData.AdvScriptDefScriptType[] ScriptType;

	// Token: 0x04008103 RID: 33027
	[Token(Token = "0x4007425")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public AdvScriptDefCountParam[] Params;

	// Token: 0x0200095C RID: 2396
	[Token(Token = "0x2001295")]
	[Serializable]
	public class AdvScriptDefScriptType
	{
		// Token: 0x06003F82 RID: 16258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758D")]
		[Address(RVA = "0x24323A0", Offset = "0x24324A1", VA = "0x24323A0")]
		public void Init()
		{
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758E")]
		[Address(RVA = "0x2432390", Offset = "0x2432491", VA = "0x2432390")]
		public AdvScriptDefScriptType()
		{
		}

		// Token: 0x04008104 RID: 33028
		[Token(Token = "0x4019941")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int[] useType;
	}
}
