using System;
using Il2CppDummyDll;
using RF5UI;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A2C RID: 2604
[Token(Token = "0x20006D6")]
public class UIMainEventTextSet : MonoBehaviour
{
	// Token: 0x17000942 RID: 2370
	// (get) Token: 0x06004423 RID: 17443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700076E")]
	private MainEventTextConvertData MainDataConvertTable
	{
		[Token(Token = "0x600390C")]
		[Address(RVA = "0x2022AB0", Offset = "0x2022BB1", VA = "0x2022AB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06004424 RID: 17444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600390D")]
	[Address(RVA = "0x2022BB0", Offset = "0x2022CB1", VA = "0x2022BB0")]
	private void OnEnable()
	{
	}

	// Token: 0x06004425 RID: 17445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600390E")]
	[Address(RVA = "0x2022CE0", Offset = "0x2022DE1", VA = "0x2022CE0")]
	private void OnDisable()
	{
	}

	// Token: 0x06004426 RID: 17446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600390F")]
	[Address(RVA = "0x2022D20", Offset = "0x2022E21", VA = "0x2022D20")]
	public UIMainEventTextSet()
	{
	}

	// Token: 0x0400A313 RID: 41747
	[Token(Token = "0x4007B46")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text Topic;

	// Token: 0x0400A314 RID: 41748
	[Token(Token = "0x4007B47")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text Detail;

	// Token: 0x0400A315 RID: 41749
	[Token(Token = "0x4007B48")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UISubEventTextSet SubEventTextSet;

	// Token: 0x0400A316 RID: 41750
	[Token(Token = "0x4007B49")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UILoveEventTextSet LoveEventTextSet;

	// Token: 0x0400A317 RID: 41751
	[Token(Token = "0x4007B4A")]
	[FieldOffset(Offset = "0x38")]
	private MainEventTextConvertData mainDataConvertTable;
}
