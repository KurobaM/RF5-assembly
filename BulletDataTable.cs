using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000345 RID: 837
[Token(Token = "0x2000274")]
[Serializable]
public class BulletDataTable
{
	// Token: 0x06001649 RID: 5705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x2193DE0", Offset = "0x2193EE1", VA = "0x2193DE0")]
	public static BulletDataTable GetDataTable(BulletID bulletId)
	{
		return null;
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x00009EA0 File Offset: 0x000080A0
	[Token(Token = "0x60013BC")]
	[Address(RVA = "0x2193F80", Offset = "0x2194081", VA = "0x2193F80")]
	public static bool HasDataTable(BulletID bulletId)
	{
		return default(bool);
	}

	// Token: 0x0600164B RID: 5707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BD")]
	[Address(RVA = "0x2193F70", Offset = "0x2194071", VA = "0x2193F70")]
	public BulletDataTable()
	{
	}

	// Token: 0x04000E18 RID: 3608
	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public BulletData Data;

	// Token: 0x04000E19 RID: 3609
	[Token(Token = "0x4000AFA")]
	[FieldOffset(Offset = "0x0")]
	private static BulletDataTableArray _BulletDataTableArray;
}
