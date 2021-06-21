using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000918 RID: 2328
[Token(Token = "0x200061B")]
public class AdvEmoconControl : MonoBehaviour
{
	// Token: 0x06003D1D RID: 15645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600336B")]
	[Address(RVA = "0x1D59BF0", Offset = "0x1D59CF1", VA = "0x1D59BF0")]
	public void PlayEmo(int no, int loop = 0)
	{
	}

	// Token: 0x06003D1E RID: 15646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600336C")]
	[Address(RVA = "0x1D5A4E0", Offset = "0x1D5A5E1", VA = "0x1D5A4E0")]
	public void SetEndLoop(int no)
	{
	}

	// Token: 0x06003D1F RID: 15647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600336D")]
	[Address(RVA = "0x1D5A670", Offset = "0x1D5A771", VA = "0x1D5A670")]
	public void ForceEndAll()
	{
	}

	// Token: 0x06003D20 RID: 15648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600336E")]
	[Address(RVA = "0x1D5D7F0", Offset = "0x1D5D8F1", VA = "0x1D5D7F0")]
	public AdvEmoconControl()
	{
	}

	// Token: 0x04007F76 RID: 32630
	[Token(Token = "0x4007307")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Animator> EmoconAnimators;
}
