using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5UI.BUTTONHINT
{
	// Token: 0x02000EA6 RID: 3750
	[Token(Token = "0x200099D")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149740", Offset = "0x149841")]
	[Serializable]
	public class ButtonGuideDataTable : ScriptableObject
	{
		// Token: 0x060061F5 RID: 25077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005123")]
		[Address(RVA = "0x21810C0", Offset = "0x21811C1", VA = "0x21810C0")]
		public ButtonGuideDataTable()
		{
		}

		// Token: 0x0400C20F RID: 49679
		[Token(Token = "0x4009196")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ButtonGuideDataTable.Data[] DataSet;

		// Token: 0x02000EA7 RID: 3751
		[Token(Token = "0x2001475")]
		[Serializable]
		public class DispSet
		{
			// Token: 0x060061F6 RID: 25078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B81")]
			[Address(RVA = "0x21810E0", Offset = "0x21811E1", VA = "0x21810E0")]
			public DispSet()
			{
			}

			// Token: 0x0400C210 RID: 49680
			[Token(Token = "0x401BC85")]
			[FieldOffset(Offset = "0x10")]
			public ButtonType buttonId;

			// Token: 0x0400C211 RID: 49681
			[Token(Token = "0x401BC86")]
			[FieldOffset(Offset = "0x14")]
			public int textId;
		}

		// Token: 0x02000EA8 RID: 3752
		[Token(Token = "0x2001476")]
		[Serializable]
		public class Data
		{
			// Token: 0x060061F7 RID: 25079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B82")]
			[Address(RVA = "0x21810D0", Offset = "0x21811D1", VA = "0x21810D0")]
			public Data()
			{
			}

			// Token: 0x0400C212 RID: 49682
			[Token(Token = "0x401BC87")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			// Token: 0x0400C213 RID: 49683
			[Token(Token = "0x401BC88")]
			[FieldOffset(Offset = "0x18")]
			public ButtonGuideDataTable.DispSet[] dispSet;
		}
	}
}
