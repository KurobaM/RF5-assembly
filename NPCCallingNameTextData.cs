using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200096F RID: 2415
[Token(Token = "0x2000654")]
public class NPCCallingNameTextData : ScriptableObject
{
	// Token: 0x06003F8F RID: 16271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034E4")]
	[Address(RVA = "0x1E22330", Offset = "0x1E22431", VA = "0x1E22330")]
	public NPCCallingNameTextData()
	{
	}

	// Token: 0x0400836D RID: 33645
	[Token(Token = "0x400765D")]
	[FieldOffset(Offset = "0x18")]
	public NPCCallingNameTextData.Data[] datas;

	// Token: 0x02000970 RID: 2416
	[Token(Token = "0x200129D")]
	[Serializable]
	public struct Data
	{
		// Token: 0x0400836E RID: 33646
		[Token(Token = "0x4019973")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public int npcId;

		// Token: 0x0400836F RID: 33647
		[Token(Token = "0x4019974")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public string[] str;
	}
}
