using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x0200115F RID: 4447
	[Token(Token = "0x2000B37")]
	[Serializable]
	public class DoorDataTableArray : DataTableArrayBase<Place, DoorDataTable, SerializedDoorDataTable>
	{
		// Token: 0x06007073 RID: 28787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0x1DA3BA0", Offset = "0x1DA3CA1", VA = "0x1DA3BA0")]
		public DoorDataTableArray()
		{
		}

		// Token: 0x040182CB RID: 99019
		[Token(Token = "0x4014D3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public AnimationCurve ShareCurve;
	}
}
