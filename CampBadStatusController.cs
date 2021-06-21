using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A01 RID: 2561
[Token(Token = "0x20006B5")]
public class CampBadStatusController : MonoBehaviour
{
	// Token: 0x0600431E RID: 17182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600381F")]
	[Address(RVA = "0x1E79750", Offset = "0x1E79851", VA = "0x1E79750")]
	public void CheckBadStatus(CharacterStatusBase _status)
	{
	}

	// Token: 0x0600431F RID: 17183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003820")]
	[Address(RVA = "0x1E7A670", Offset = "0x1E7A771", VA = "0x1E7A670")]
	private void Clear()
	{
	}

	// Token: 0x06004320 RID: 17184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003821")]
	[Address(RVA = "0x1E7A780", Offset = "0x1E7A881", VA = "0x1E7A780")]
	private void OnDisable()
	{
	}

	// Token: 0x06004321 RID: 17185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003822")]
	[Address(RVA = "0x1E7A790", Offset = "0x1E7A891", VA = "0x1E7A790")]
	public CampBadStatusController()
	{
	}

	// Token: 0x0400A1BC RID: 41404
	[Token(Token = "0x4007A1E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CampBadStatus badStatus;

	// Token: 0x0400A1BD RID: 41405
	[Token(Token = "0x4007A1F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite[] badStatusIcon;

	// Token: 0x0400A1BE RID: 41406
	[Token(Token = "0x4007A20")]
	[FieldOffset(Offset = "0x28")]
	private string[] badStatusText;

	// Token: 0x0400A1BF RID: 41407
	[Token(Token = "0x4007A21")]
	[FieldOffset(Offset = "0x30")]
	private CampBadStatus[] badStatusBlock;

	// Token: 0x0400A1C0 RID: 41408
	[Token(Token = "0x4007A22")]
	[FieldOffset(Offset = "0x38")]
	private int badStatusCount;
}
