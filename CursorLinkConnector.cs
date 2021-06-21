using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000942 RID: 2370
[Token(Token = "0x2000635")]
public class CursorLinkConnector : CursorLinker
{
	// Token: 0x06003EC7 RID: 16071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003434")]
	[Address(RVA = "0x20ED5E0", Offset = "0x20ED6E1", VA = "0x20ED5E0")]
	public void SetCursorLinker(CursorLinker NewLinker)
	{
	}

	// Token: 0x06003EC8 RID: 16072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003435")]
	[Address(RVA = "0x20ED5F0", Offset = "0x20ED6F1", VA = "0x20ED5F0", Slot = "5")]
	public override CursorLinker GetMyCursorLinker()
	{
		return null;
	}

	// Token: 0x06003EC9 RID: 16073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003436")]
	[Address(RVA = "0x20ED690", Offset = "0x20ED791", VA = "0x20ED690", Slot = "6")]
	public override CursorLinker GetNextObject(CursorLinker.InputMoveType _InType)
	{
		return null;
	}

	// Token: 0x06003ECA RID: 16074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003437")]
	[Address(RVA = "0x20ED730", Offset = "0x20ED831", VA = "0x20ED730")]
	public CursorLinkConnector()
	{
	}

	// Token: 0x04008064 RID: 32868
	[Token(Token = "0x40073B1")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private CursorLinker ToLinker;
}
