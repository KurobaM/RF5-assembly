using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000B15 RID: 2837
[Token(Token = "0x2000763")]
public class ItemIconLoader : MonoBehaviour
{
	// Token: 0x06004978 RID: 18808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D70")]
	[Address(RVA = "0x208C500", Offset = "0x208C601", VA = "0x208C500")]
	public void SetLoadIcon(ItemID itemID)
	{
	}

	// Token: 0x06004979 RID: 18809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D71")]
	[Address(RVA = "0x208C770", Offset = "0x208C871", VA = "0x208C770")]
	public void SetLoadIcon(string iconName)
	{
	}

	// Token: 0x0600497A RID: 18810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D72")]
	[Address(RVA = "0x208CDC0", Offset = "0x208CEC1", VA = "0x208CDC0")]
	public ItemIconLoader()
	{
	}

	// Token: 0x0400A945 RID: 43333
	[Token(Token = "0x4007F80")]
	[FieldOffset(Offset = "0x18")]
	private Image Image;

	// Token: 0x0400A946 RID: 43334
	[Token(Token = "0x4007F81")]
	[FieldOffset(Offset = "0x20")]
	private ItemID loadingItemId;
}
