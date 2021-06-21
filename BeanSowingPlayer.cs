using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000500 RID: 1280
[Token(Token = "0x20003A7")]
public class BeanSowingPlayer : MonoBehaviour
{
	// Token: 0x06001F3E RID: 7998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABA")]
	[Address(RVA = "0x220B990", Offset = "0x220BA91", VA = "0x220B990")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06001F3F RID: 7999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0x220C0D0", Offset = "0x220C1D1", VA = "0x220C0D0")]
	public BeanSowingPlayer()
	{
	}

	// Token: 0x0400662A RID: 26154
	[Token(Token = "0x4006092")]
	[FieldOffset(Offset = "0x18")]
	private int score;

	// Token: 0x0400662B RID: 26155
	[Token(Token = "0x4006093")]
	[FieldOffset(Offset = "0x1C")]
	private int bonus;

	// Token: 0x0400662C RID: 26156
	[Token(Token = "0x4006094")]
	[FieldOffset(Offset = "0x20")]
	private BeanID currentBean;

	// Token: 0x0400662D RID: 26157
	[Token(Token = "0x4006095")]
	[FieldOffset(Offset = "0x24")]
	private BeanID pastBean;

	// Token: 0x0400662E RID: 26158
	[Token(Token = "0x4006096")]
	private const int MAX_BONUS_POINT = 65535;

	// Token: 0x0400662F RID: 26159
	[Token(Token = "0x4006097")]
	private const int MAX_SCORE = 999999;
}
