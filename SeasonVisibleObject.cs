using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200058B RID: 1419
[Token(Token = "0x20003FB")]
[Serializable]
public class SeasonVisibleObject : MonoBehaviour
{
	// Token: 0x06002249 RID: 8777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CE2")]
	[Address(RVA = "0x1E2F790", Offset = "0x1E2F891", VA = "0x1E2F790")]
	private void Awake()
	{
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CE3")]
	[Address(RVA = "0x1E2F860", Offset = "0x1E2F961", VA = "0x1E2F860")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CE4")]
	[Address(RVA = "0x1E2F910", Offset = "0x1E2FA11", VA = "0x1E2F910")]
	public SeasonVisibleObject()
	{
	}

	// Token: 0x04006A8A RID: 27274
	[Token(Token = "0x400641D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Season Season;

	// Token: 0x04006A8B RID: 27275
	[Token(Token = "0x400641E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public GameObject[] SeasonGameObjects;
}
