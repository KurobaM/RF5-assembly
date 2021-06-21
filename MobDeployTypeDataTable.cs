using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000397 RID: 919
[Token(Token = "0x20002BF")]
[Serializable]
public class MobDeployTypeDataTable : ScriptableObject
{
	// Token: 0x06001717 RID: 5911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001483")]
	[Address(RVA = "0x1D79920", Offset = "0x1D79A21", VA = "0x1D79920")]
	public static List<HairType> GetList()
	{
		return null;
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001484")]
	[Address(RVA = "0x1D79A30", Offset = "0x1D79B31", VA = "0x1D79A30")]
	public MobDeployTypeDataTable()
	{
	}

	// Token: 0x04001038 RID: 4152
	[Token(Token = "0x4000CEC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<HairType> Types;

	// Token: 0x04001039 RID: 4153
	[Token(Token = "0x4000CED")]
	[FieldOffset(Offset = "0x0")]
	private static MobDeployTypeDataTable _MobDeployTypeDataTable;
}
