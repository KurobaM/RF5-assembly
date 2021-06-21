using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5UI
{
	// Token: 0x02000E88 RID: 3720
	[Token(Token = "0x2000987")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149700", Offset = "0x149801")]
	[Serializable]
	public class MainEventTextConvertData : ScriptableObject
	{
		// Token: 0x06006160 RID: 24928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509D")]
		[Address(RVA = "0x2183C90", Offset = "0x2183D91", VA = "0x2183C90")]
		public string GetTopicText(int value)
		{
			return null;
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509E")]
		[Address(RVA = "0x2183E40", Offset = "0x2183F41", VA = "0x2183E40")]
		public string GetDetailText(int value)
		{
			return null;
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600509F")]
		[Address(RVA = "0x2183FF0", Offset = "0x21840F1", VA = "0x2183FF0")]
		public MainEventTextConvertData()
		{
		}

		// Token: 0x0400C10D RID: 49421
		[Token(Token = "0x40090AE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int[] ConvertTextTable;
	}
}
