using System;
using System.Collections.Generic;
using Field;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x0200116B RID: 4459
	[Token(Token = "0x2000B41")]
	[Serializable]
	public class EnvironmentSoundDataTableArray : ScriptableObject
	{
		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06007099 RID: 28825 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600709A RID: 28826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B25")]
		private Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>> DataTablesByType
		{
			[Token(Token = "0x6005D58")]
			[Address(RVA = "0x1DA44F0", Offset = "0x1DA45F1", VA = "0x1DA44F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF440", Offset = "0x1AF541")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005D59")]
			[Address(RVA = "0x1DA4500", Offset = "0x1DA4601", VA = "0x1DA4500")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF450", Offset = "0x1AF551")]
			set
			{
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x0600709B RID: 28827 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600709C RID: 28828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B26")]
		private Dictionary<FieldSceneId, List<EnvironmentSoundDataTable>> DataTablesBySceneID
		{
			[Token(Token = "0x6005D5A")]
			[Address(RVA = "0x1DA4510", Offset = "0x1DA4611", VA = "0x1DA4510")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF460", Offset = "0x1AF561")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005D5B")]
			[Address(RVA = "0x1DA4520", Offset = "0x1DA4621", VA = "0x1DA4520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF470", Offset = "0x1AF571")]
			set
			{
			}
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0x1DA4530", Offset = "0x1DA4631", VA = "0x1DA4530")]
		private void Init()
		{
		}

		// Token: 0x0600709E RID: 28830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0x1DA47A0", Offset = "0x1DA48A1", VA = "0x1DA47A0")]
		public EnvironmentSoundDataTable[] GetDataTables(EnvironmentSoundType type)
		{
			return null;
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D5E")]
		[Address(RVA = "0x1DA4950", Offset = "0x1DA4A51", VA = "0x1DA4950")]
		public EnvironmentSoundDataTable[] GetDataTables(FieldSceneId id)
		{
			return null;
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5F")]
		[Address(RVA = "0x1DA4A40", Offset = "0x1DA4B41", VA = "0x1DA4A40")]
		public EnvironmentSoundDataTableArray()
		{
		}

		// Token: 0x040182DB RID: 99035
		[Token(Token = "0x4014D49")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public EnvironmentSoundDataTable[] DataTables;

		// Token: 0x040182DC RID: 99036
		[Token(Token = "0x4014D4A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181800", Offset = "0x181901")]
		private Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>> <DataTablesByType>k__BackingField;

		// Token: 0x040182DD RID: 99037
		[Token(Token = "0x4014D4B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181810", Offset = "0x181911")]
		private Dictionary<FieldSceneId, List<EnvironmentSoundDataTable>> <DataTablesBySceneID>k__BackingField;

		// Token: 0x040182DE RID: 99038
		[Token(Token = "0x4014D4C")]
		[FieldOffset(Offset = "0x30")]
		private bool IsInit;
	}
}
