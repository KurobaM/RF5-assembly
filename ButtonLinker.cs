using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000938 RID: 2360
[Token(Token = "0x200062D")]
public class ButtonLinker : CursorLinker
{
	// Token: 0x06003E6D RID: 15981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033E1")]
	[Address(RVA = "0x219B200", Offset = "0x219B301", VA = "0x219B200")]
	public void ClearLink()
	{
	}

	// Token: 0x06003E6E RID: 15982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033E2")]
	[Address(RVA = "0x219B260", Offset = "0x219B361", VA = "0x219B260")]
	public void AddLink(CursorLinker.InputMoveType _type, GameObject _moveToButton)
	{
	}

	// Token: 0x06003E6F RID: 15983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033E3")]
	[Address(RVA = "0x219B3B0", Offset = "0x219B4B1", VA = "0x219B3B0", Slot = "6")]
	public override CursorLinker GetNextObject(CursorLinker.InputMoveType _InType)
	{
		return null;
	}

	// Token: 0x06003E70 RID: 15984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033E4")]
	[Address(RVA = "0x219B5D0", Offset = "0x219B6D1", VA = "0x219B5D0", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06003E71 RID: 15985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033E5")]
	[Address(RVA = "0x219B650", Offset = "0x219B751", VA = "0x219B650")]
	public ButtonLinker()
	{
	}

	// Token: 0x0400802A RID: 32810
	[Token(Token = "0x4007380")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<ButtonLinker.LinkObject> LinkObjectList;

	// Token: 0x0400802B RID: 32811
	[Token(Token = "0x4007381")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ButtonGuideId ButtonGuideId;

	// Token: 0x02000939 RID: 2361
	[Token(Token = "0x200128D")]
	[Serializable]
	public struct LinkObject
	{
		// Token: 0x06003E72 RID: 15986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007570")]
		[Address(RVA = "0x2E16C0", Offset = "0x2E17C1", VA = "0x2E16C0")]
		public LinkObject(CursorLinker.InputMoveType _type, GameObject _moveToButton)
		{
		}

		// Token: 0x0400802C RID: 32812
		[Token(Token = "0x401990D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public CursorLinker.InputMoveType type;

		// Token: 0x0400802D RID: 32813
		[Token(Token = "0x401990E")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public GameObject moveToButton;
	}
}
