using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5UI
{
	// Token: 0x02000E89 RID: 3721
	[Token(Token = "0x2000988")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149710", Offset = "0x149811")]
	[Serializable]
	public class NextTargetDataTable : ScriptableObject
	{
		// Token: 0x06006163 RID: 24931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A0")]
		[Address(RVA = "0x1F29AD0", Offset = "0x1F29BD1", VA = "0x1F29AD0")]
		public string GetText(int value)
		{
			return null;
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A1")]
		[Address(RVA = "0x1F29C30", Offset = "0x1F29D31", VA = "0x1F29C30")]
		public NextTargetDataTable()
		{
		}

		// Token: 0x0400C10E RID: 49422
		[Token(Token = "0x40090AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int[] ConvertTextTable;
	}
}
