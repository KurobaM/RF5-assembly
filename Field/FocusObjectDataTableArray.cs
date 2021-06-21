using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x020010F9 RID: 4345
	[Token(Token = "0x2000AEE")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x14A0C0", Offset = "0x14A1C1")]
	[Serializable]
	public class FocusObjectDataTableArray : ScriptableObject
	{
		// Token: 0x06006DD4 RID: 28116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B1D")]
		[Address(RVA = "0x2027DE0", Offset = "0x2027EE1", VA = "0x2027DE0")]
		public FocusObjectDataTable[] GetDataTables()
		{
			return null;
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x00025D88 File Offset: 0x00023F88
		[Token(Token = "0x6005B1E")]
		[Address(RVA = "0x2027DF0", Offset = "0x2027EF1", VA = "0x2027DF0")]
		public FocusObjectDataTable GetDataTables(int index)
		{
			return default(FocusObjectDataTable);
		}

		// Token: 0x06006DD6 RID: 28118 RVA: 0x00025DA0 File Offset: 0x00023FA0
		[Token(Token = "0x6005B1F")]
		[Address(RVA = "0x2027E40", Offset = "0x2027F41", VA = "0x2027E40")]
		public FocusObjectDataTable GetDataTables(FocusObjectID id)
		{
			return default(FocusObjectDataTable);
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B20")]
		[Address(RVA = "0x2027EF0", Offset = "0x2027FF1", VA = "0x2027EF0")]
		public FocusObjectDataTableArray()
		{
		}

		// Token: 0x040180AE RID: 98478
		[Token(Token = "0x4014B8E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public FocusObjectDataTable[] DataTables;
	}
}
