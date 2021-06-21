using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x02000364 RID: 868
[Token(Token = "0x2000292")]
[Serializable]
public class DualSkillDataTable
{
	// Token: 0x0600169F RID: 5791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001410")]
	[Address(RVA = "0x1E04140", Offset = "0x1E04241", VA = "0x1E04140")]
	public static DualSkillDataTable GetDataTable(ActorID actor_id)
	{
		return null;
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x0000A098 File Offset: 0x00008298
	[Token(Token = "0x6001411")]
	[Address(RVA = "0x1E042E0", Offset = "0x1E043E1", VA = "0x1E042E0")]
	public static bool HasDataTable(ActorID actor_id)
	{
		return default(bool);
	}

	// Token: 0x060016A1 RID: 5793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001412")]
	[Address(RVA = "0x1E042D0", Offset = "0x1E043D1", VA = "0x1E042D0")]
	public DualSkillDataTable()
	{
	}

	// Token: 0x04000E9D RID: 3741
	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public TimeLine TimeLine;

	// Token: 0x04000E9E RID: 3742
	[Token(Token = "0x4000B7D")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public MagicParamID ParamID;

	// Token: 0x04000E9F RID: 3743
	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0x0")]
	private static DualSkillDataTableArray _DualSkillDataTableArray;
}
