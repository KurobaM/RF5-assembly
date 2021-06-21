using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000396 RID: 918
[Token(Token = "0x20002BE")]
[Serializable]
public class MobDeployCharDataTable : ScriptableObject
{
	// Token: 0x06001715 RID: 5909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001481")]
	[Address(RVA = "0x1D79800", Offset = "0x1D79901", VA = "0x1D79800")]
	public static List<MobDeployCharData> GetList()
	{
		return null;
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001482")]
	[Address(RVA = "0x1D79910", Offset = "0x1D79A11", VA = "0x1D79910")]
	public MobDeployCharDataTable()
	{
	}

	// Token: 0x04001036 RID: 4150
	[Token(Token = "0x4000CEA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<MobDeployCharData> Chars;

	// Token: 0x04001037 RID: 4151
	[Token(Token = "0x4000CEB")]
	[FieldOffset(Offset = "0x0")]
	private static MobDeployCharDataTable _MobDeployCharDataTable;
}
