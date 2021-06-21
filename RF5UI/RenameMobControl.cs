using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RF5UI
{
	// Token: 0x02000E9D RID: 3741
	[Token(Token = "0x2000995")]
	public class RenameMobControl
	{
		// Token: 0x060061D5 RID: 25045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005103")]
		[Address(RVA = "0x1F2A8E0", Offset = "0x1F2A9E1", VA = "0x1F2A8E0")]
		public void DoOpenChoice()
		{
		}

		// Token: 0x060061D6 RID: 25046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005104")]
		[Address(RVA = "0x1F2B180", Offset = "0x1F2B281", VA = "0x1F2B180")]
		private string GetNowName(UINamingWindow.NamingId namingId)
		{
			return null;
		}

		// Token: 0x060061D7 RID: 25047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005105")]
		[Address(RVA = "0x1F2B210", Offset = "0x1F2B311", VA = "0x1F2B210")]
		private void CallbackSelect(int select)
		{
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005106")]
		[Address(RVA = "0x1F2B330", Offset = "0x1F2B431", VA = "0x1F2B330")]
		private void CallbackEndNaming(string name)
		{
		}

		// Token: 0x060061D9 RID: 25049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005107")]
		[Address(RVA = "0x1F2B5E0", Offset = "0x1F2B6E1", VA = "0x1F2B5E0")]
		public RenameMobControl()
		{
		}

		// Token: 0x0400C192 RID: 49554
		[Token(Token = "0x400911F")]
		[FieldOffset(Offset = "0x10")]
		private List<UINamingWindow.NamingId> idlist;

		// Token: 0x0400C193 RID: 49555
		[Token(Token = "0x4009120")]
		[FieldOffset(Offset = "0x18")]
		private UINamingWindow.NamingId selectedId;
	}
}
