using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x02001160 RID: 4448
	[Token(Token = "0x2000B38")]
	[Serializable]
	public class DropCapDataTableArray : ScriptableObject, ISerializationCallbackReceiver
	{
		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06007074 RID: 28788 RVA: 0x00026D00 File Offset: 0x00024F00
		// (set) Token: 0x06007075 RID: 28789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1D")]
		public int NoDropTresureCap
		{
			[Token(Token = "0x6005D3B")]
			[Address(RVA = "0x1DA3BF0", Offset = "0x1DA3CF1", VA = "0x1DA3BF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF340", Offset = "0x1AF441")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005D3C")]
			[Address(RVA = "0x1DA3C00", Offset = "0x1DA3D01", VA = "0x1DA3C00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF350", Offset = "0x1AF451")]
			private set
			{
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06007076 RID: 28790 RVA: 0x00026D18 File Offset: 0x00024F18
		// (set) Token: 0x06007077 RID: 28791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1E")]
		public int HiDropCap
		{
			[Token(Token = "0x6005D3D")]
			[Address(RVA = "0x1DA3C10", Offset = "0x1DA3D11", VA = "0x1DA3C10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF360", Offset = "0x1AF461")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005D3E")]
			[Address(RVA = "0x1DA3C20", Offset = "0x1DA3D21", VA = "0x1DA3C20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF370", Offset = "0x1AF471")]
			private set
			{
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06007078 RID: 28792 RVA: 0x00026D30 File Offset: 0x00024F30
		// (set) Token: 0x06007079 RID: 28793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1F")]
		public int Legendary
		{
			[Token(Token = "0x6005D3F")]
			[Address(RVA = "0x1DA3C30", Offset = "0x1DA3D31", VA = "0x1DA3C30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF380", Offset = "0x1AF481")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005D40")]
			[Address(RVA = "0x1DA3C40", Offset = "0x1DA3D41", VA = "0x1DA3C40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF390", Offset = "0x1AF491")]
			private set
			{
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x0600707A RID: 28794 RVA: 0x00026D48 File Offset: 0x00024F48
		// (set) Token: 0x0600707B RID: 28795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B20")]
		public int NoDropCap
		{
			[Token(Token = "0x6005D41")]
			[Address(RVA = "0x1DA3C50", Offset = "0x1DA3D51", VA = "0x1DA3C50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF3A0", Offset = "0x1AF4A1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005D42")]
			[Address(RVA = "0x1DA3C60", Offset = "0x1DA3D61", VA = "0x1DA3C60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF3B0", Offset = "0x1AF4B1")]
			private set
			{
			}
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D43")]
		[Address(RVA = "0x1DA3C70", Offset = "0x1DA3D71", VA = "0x1DA3C70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x0600707D RID: 28797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D44")]
		[Address(RVA = "0x1DA3D10", Offset = "0x1DA3E11", VA = "0x1DA3D10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x0600707E RID: 28798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D45")]
		[Address(RVA = "0x1DA3D20", Offset = "0x1DA3E21", VA = "0x1DA3D20")]
		public DropCapDataTableArray()
		{
		}

		// Token: 0x040182CC RID: 99020
		[Token(Token = "0x4014D40")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public DropCapDataTable[] DataTables;

		// Token: 0x040182CD RID: 99021
		[Token(Token = "0x4014D41")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181770", Offset = "0x181871")]
		private int <NoDropTresureCap>k__BackingField;

		// Token: 0x040182CE RID: 99022
		[Token(Token = "0x4014D42")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181780", Offset = "0x181881")]
		private int <HiDropCap>k__BackingField;

		// Token: 0x040182CF RID: 99023
		[Token(Token = "0x4014D43")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181790", Offset = "0x181891")]
		private int <Legendary>k__BackingField;

		// Token: 0x040182D0 RID: 99024
		[Token(Token = "0x4014D44")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1817A0", Offset = "0x1818A1")]
		private int <NoDropCap>k__BackingField;
	}
}
