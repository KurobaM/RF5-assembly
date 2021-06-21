using System;
using System.Collections.Generic;
using Field;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace RF5UI
{
	// Token: 0x02000E96 RID: 3734
	[Token(Token = "0x2000992")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149730", Offset = "0x149831")]
	[Serializable]
	public class DirectSignDataTable : ScriptableObject
	{
		// Token: 0x060061A4 RID: 24996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050DA")]
		[Address(RVA = "0x2182900", Offset = "0x2182A01", VA = "0x2182900")]
		public void DoDirectionSign(FocusObjectID id)
		{
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050DB")]
		[Address(RVA = "0x2182C10", Offset = "0x2182D11", VA = "0x2182C10")]
		public DirectSignDataTable()
		{
		}

		// Token: 0x0400C160 RID: 49504
		[Token(Token = "0x40090FD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public DirectSignDataTable.Data[] datas;

		// Token: 0x02000E97 RID: 3735
		[Token(Token = "0x2001470")]
		[Serializable]
		public class Data
		{
			// Token: 0x060061A6 RID: 24998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B79")]
			[Address(RVA = "0x21835E0", Offset = "0x21836E1", VA = "0x21835E0")]
			public Data()
			{
			}

			// Token: 0x0400C161 RID: 49505
			[Token(Token = "0x401BC6F")]
			[FieldOffset(Offset = "0x10")]
			public FocusObjectID id;

			// Token: 0x0400C162 RID: 49506
			[Token(Token = "0x401BC70")]
			[FieldOffset(Offset = "0x18")]
			public string placeNameId;

			// Token: 0x0400C163 RID: 49507
			[Token(Token = "0x401BC71")]
			[FieldOffset(Offset = "0x20")]
			public List<ItemID> itemIDs;

			// Token: 0x0400C164 RID: 49508
			[Token(Token = "0x401BC72")]
			[FieldOffset(Offset = "0x28")]
			public List<string> monsterNameIds;

			// Token: 0x0400C165 RID: 49509
			[Token(Token = "0x401BC73")]
			[FieldOffset(Offset = "0x30")]
			public int recommentedLevel;
		}

		// Token: 0x02000E98 RID: 3736
		[Token(Token = "0x2001471")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159A10", Offset = "0x159B11")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x060061A7 RID: 24999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B7A")]
			[Address(RVA = "0x2182C00", Offset = "0x2182D01", VA = "0x2182C00")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x060061A8 RID: 25000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B7B")]
			[Address(RVA = "0x2182D80", Offset = "0x2182E81", VA = "0x2182D80")]
			internal void <DoDirectionSign>b__0()
			{
			}

			// Token: 0x060061A9 RID: 25001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B7C")]
			[Address(RVA = "0x21830E0", Offset = "0x21831E1", VA = "0x21830E0")]
			internal void <DoDirectionSign>b__1(int select)
			{
			}

			// Token: 0x0400C166 RID: 49510
			[Token(Token = "0x401BC74")]
			[FieldOffset(Offset = "0x10")]
			public DirectSignDataTable.Data data;

			// Token: 0x0400C167 RID: 49511
			[Token(Token = "0x401BC75")]
			[FieldOffset(Offset = "0x18")]
			public UnityAction<int> <>9__1;
		}

		// Token: 0x02000E99 RID: 3737
		[Token(Token = "0x2001472")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159A20", Offset = "0x159B21")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060061AB RID: 25003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B7E")]
			[Address(RVA = "0x2182C90", Offset = "0x2182D91", VA = "0x2182C90")]
			public <>c()
			{
			}

			// Token: 0x060061AC RID: 25004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B7F")]
			[Address(RVA = "0x2182CA0", Offset = "0x2182DA1", VA = "0x2182CA0")]
			internal void <DoDirectionSign>b__2_2(bool sel)
			{
			}

			// Token: 0x060061AD RID: 25005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B80")]
			[Address(RVA = "0x2182D10", Offset = "0x2182E11", VA = "0x2182D10")]
			internal void <DoDirectionSign>b__2_3(bool sel)
			{
			}

			// Token: 0x0400C168 RID: 49512
			[Token(Token = "0x401BC76")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DirectSignDataTable.<>c <>9;

			// Token: 0x0400C169 RID: 49513
			[Token(Token = "0x401BC77")]
			[FieldOffset(Offset = "0x8")]
			public static UnityAction<bool> <>9__2_2;

			// Token: 0x0400C16A RID: 49514
			[Token(Token = "0x401BC78")]
			[FieldOffset(Offset = "0x10")]
			public static UnityAction<bool> <>9__2_3;
		}
	}
}
