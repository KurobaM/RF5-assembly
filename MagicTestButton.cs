using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000844 RID: 2116
[Token(Token = "0x200056D")]
public class MagicTestButton : MonoBehaviour
{
	// Token: 0x06003833 RID: 14387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EBD")]
	[Address(RVA = "0x1F15610", Offset = "0x1F15711", VA = "0x1F15610")]
	public void OnPush()
	{
	}

	// Token: 0x06003834 RID: 14388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EBE")]
	[Address(RVA = "0x1F15720", Offset = "0x1F15821", VA = "0x1F15720")]
	public void OnRelease()
	{
	}

	// Token: 0x06003835 RID: 14389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EBF")]
	[Address(RVA = "0x1F157E0", Offset = "0x1F158E1", VA = "0x1F157E0")]
	public MagicTestButton()
	{
	}

	// Token: 0x04007B45 RID: 31557
	[Token(Token = "0x4006F71")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MagicID magicId;

	// Token: 0x04007B46 RID: 31558
	[Token(Token = "0x4006F72")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Character chara;
}
