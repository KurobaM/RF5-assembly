using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000911 RID: 2321
[Token(Token = "0x2000617")]
public abstract class AdvCharaAnim : MonoBehaviour
{
	// Token: 0x06003CCE RID: 15566
	[Token(Token = "0x600331F")]
	public abstract void PlayAnim();

	// Token: 0x06003CCF RID: 15567
	[Token(Token = "0x6003320")]
	public abstract void EndAnim();

	// Token: 0x06003CD0 RID: 15568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003321")]
	[Address(RVA = "0x1D591B0", Offset = "0x1D592B1", VA = "0x1D591B0")]
	protected AdvCharaAnim()
	{
	}

	// Token: 0x04007F2C RID: 32556
	[Token(Token = "0x40072CE")]
	[FieldOffset(Offset = "0x18")]
	public AdvCharaImageControl.CharaAnimateType Type;
}
