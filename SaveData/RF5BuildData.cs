using System;
using BinaryStream;
using Il2CppDummyDll;
using RF5SHOP;

namespace SaveData
{
	// Token: 0x02000EC4 RID: 3780
	[Token(Token = "0x20009AD")]
	public class RF5BuildData : SaveDataValueBase
	{
		// Token: 0x060062CC RID: 25292 RVA: 0x000212A0 File Offset: 0x0001F4A0
		[Token(Token = "0x60051EB")]
		[Address(RVA = "0x1EFC950", Offset = "0x1EFCA51", VA = "0x1EFC950")]
		public bool CheckBuilder(BuilderId id)
		{
			return default(bool);
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EC")]
		[Address(RVA = "0x1EFC980", Offset = "0x1EFCA81", VA = "0x1EFC980")]
		public void SetBuilder(bool value, BuilderId id)
		{
		}

		// Token: 0x060062CE RID: 25294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051ED")]
		[Address(RVA = "0x1EFC9B0", Offset = "0x1EFCAB1", VA = "0x1EFC9B0")]
		public RF5BuildData()
		{
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EE")]
		[Address(RVA = "0x1EFCA40", Offset = "0x1EFCB41", VA = "0x1EFCA40", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x060062D0 RID: 25296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EF")]
		[Address(RVA = "0x1EFCA60", Offset = "0x1EFCB61", VA = "0x1EFCA60", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x060062D1 RID: 25297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F0")]
		[Address(RVA = "0x1EFCA70", Offset = "0x1EFCB71", VA = "0x1EFCA70", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F1")]
		[Address(RVA = "0x1EFCA80", Offset = "0x1EFCB81", VA = "0x1EFCA80", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F2")]
		[Address(RVA = "0x1EFCAA0", Offset = "0x1EFCBA1", VA = "0x1EFCAA0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C2CB RID: 49867
		[Token(Token = "0x40091FA")]
		[FieldOffset(Offset = "0x10")]
		public SaveFlagStorage SaveFlag;

		// Token: 0x02000EC5 RID: 3781
		[Token(Token = "0x2001483")]
		public enum FLAG
		{
			// Token: 0x0400C2CD RID: 49869
			[Token(Token = "0x401BCDE")]
			BuilderFlag_Head,
			// Token: 0x0400C2CE RID: 49870
			[Token(Token = "0x401BCDF")]
			BuilderFlag_Last = 128,
			// Token: 0x0400C2CF RID: 49871
			[Token(Token = "0x401BCE0")]
			Length
		}
	}
}
