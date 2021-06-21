using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A00 RID: 2560
[Token(Token = "0x20006B4")]
public class CampBadStatus : MonoBehaviour
{
	// Token: 0x0600431C RID: 17180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600381D")]
	[Address(RVA = "0x1E796F0", Offset = "0x1E797F1", VA = "0x1E796F0")]
	public void Setup(Sprite _sprite, string _text)
	{
	}

	// Token: 0x0600431D RID: 17181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600381E")]
	[Address(RVA = "0x1E79740", Offset = "0x1E79841", VA = "0x1E79740")]
	public CampBadStatus()
	{
	}

	// Token: 0x0400A1BA RID: 41402
	[Token(Token = "0x4007A1C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image icon;

	// Token: 0x0400A1BB RID: 41403
	[Token(Token = "0x4007A1D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text text;
}
