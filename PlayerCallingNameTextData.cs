using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000974 RID: 2420
[Token(Token = "0x2000657")]
public class PlayerCallingNameTextData : ScriptableObject
{
	// Token: 0x06003F93 RID: 16275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034E8")]
	[Address(RVA = "0x2144F30", Offset = "0x2145031", VA = "0x2144F30")]
	public PlayerCallingNameTextData()
	{
	}

	// Token: 0x04008376 RID: 33654
	[Token(Token = "0x4007660")]
	[FieldOffset(Offset = "0x18")]
	public PlayerCallingNameTextData.Data[] datas;

	// Token: 0x02000975 RID: 2421
	[Token(Token = "0x200129F")]
	[Serializable]
	public struct Data
	{
		// Token: 0x06003F94 RID: 16276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758F")]
		[Address(RVA = "0x2E1430", Offset = "0x2E1531", VA = "0x2E1430")]
		public void Init(int strNum)
		{
		}

		// Token: 0x04008377 RID: 33655
		[Token(Token = "0x4019979")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public int npcId;

		// Token: 0x04008378 RID: 33656
		[Token(Token = "0x401997A")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public string[] calling_L;

		// Token: 0x04008379 RID: 33657
		[Token(Token = "0x401997B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string[] called_L;

		// Token: 0x0400837A RID: 33658
		[Token(Token = "0x401997C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string[] calling_M;

		// Token: 0x0400837B RID: 33659
		[Token(Token = "0x401997D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public string[] called_M;
	}
}
