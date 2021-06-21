using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000871 RID: 2161
[Token(Token = "0x2000595")]
[Serializable]
public class NpcPlaceDataTable : MonoBehaviour
{
	// Token: 0x06003937 RID: 14647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FBB")]
	[Address(RVA = "0x1F4EE70", Offset = "0x1F4EF71", VA = "0x1F4EE70")]
	public static NpcPlaceTable GetTable(NpcPlaceType type)
	{
		return null;
	}

	// Token: 0x06003938 RID: 14648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FBC")]
	[Address(RVA = "0x1F53BA0", Offset = "0x1F53CA1", VA = "0x1F53BA0")]
	private void Update()
	{
	}

	// Token: 0x06003939 RID: 14649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FBD")]
	[Address(RVA = "0x1F53C20", Offset = "0x1F53D21", VA = "0x1F53C20")]
	public NpcPlaceDataTable()
	{
	}

	// Token: 0x04007C7E RID: 31870
	[Token(Token = "0x4007091")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private NpcPlaceTable[] npcPlaceTable;

	// Token: 0x04007C7F RID: 31871
	[Token(Token = "0x4007092")]
	[FieldOffset(Offset = "0x0")]
	public static NpcPlaceTable[] NpcPlaceTables;
}
