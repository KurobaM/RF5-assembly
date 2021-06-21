using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A44 RID: 2628
[Token(Token = "0x20006E9")]
public class UICheckOnBackRune : MonoBehaviour
{
	// Token: 0x060044B3 RID: 17587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003990")]
	[Address(RVA = "0x2002FE0", Offset = "0x20030E1", VA = "0x2002FE0")]
	private void OnEnable()
	{
	}

	// Token: 0x060044B4 RID: 17588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003991")]
	[Address(RVA = "0x20031F0", Offset = "0x20032F1", VA = "0x20031F0")]
	public UICheckOnBackRune()
	{
	}

	// Token: 0x0400A38C RID: 41868
	[Token(Token = "0x4007BB2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject BackRuneParent;

	// Token: 0x0400A38D RID: 41869
	[Token(Token = "0x4007BB3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UICheckOnBackRune.LinkSet[] LinkSetsTop;

	// Token: 0x0400A38E RID: 41870
	[Token(Token = "0x4007BB4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UICheckOnBackRune.LinkSet[] LinkSetsButtom;

	// Token: 0x02000A45 RID: 2629
	[Token(Token = "0x20012DD")]
	[Serializable]
	private struct LinkSet
	{
		// Token: 0x0400A38F RID: 41871
		[Token(Token = "0x401B43D")]
		[FieldOffset(Offset = "0x0")]
		public ButtonLinker top;

		// Token: 0x0400A390 RID: 41872
		[Token(Token = "0x401B43E")]
		[FieldOffset(Offset = "0x8")]
		public ButtonLinker buttom;
	}
}
