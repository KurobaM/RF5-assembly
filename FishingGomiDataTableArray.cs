using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000374 RID: 884
[Token(Token = "0x20002A0")]
[Serializable]
public class FishingGomiDataTableArray : ScriptableObject
{
	// Token: 0x060016C5 RID: 5829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001436")]
	[Address(RVA = "0x1EC8130", Offset = "0x1EC8231", VA = "0x1EC8130")]
	public FishingGomiDataTableArray()
	{
	}

	// Token: 0x04000F24 RID: 3876
	[Token(Token = "0x4000BEC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public FishingGomiDataTable[] DataTables;
}
