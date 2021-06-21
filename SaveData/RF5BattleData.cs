using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EC3 RID: 3779
	[Token(Token = "0x20009AC")]
	public class RF5BattleData : SaveDataValueBase
	{
		// Token: 0x060062C6 RID: 25286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E5")]
		[Address(RVA = "0x1EFC520", Offset = "0x1EFC621", VA = "0x1EFC520")]
		public RF5BattleData()
		{
		}

		// Token: 0x060062C7 RID: 25287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E6")]
		[Address(RVA = "0x1EFC550", Offset = "0x1EFC651", VA = "0x1EFC550", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x060062C8 RID: 25288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E7")]
		[Address(RVA = "0x1EFC670", Offset = "0x1EFC771", VA = "0x1EFC670", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E8")]
		[Address(RVA = "0x1EFC680", Offset = "0x1EFC781", VA = "0x1EFC680", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E9")]
		[Address(RVA = "0x1EFC690", Offset = "0x1EFC791", VA = "0x1EFC690", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EA")]
		[Address(RVA = "0x1EFC7B0", Offset = "0x1EFC8B1", VA = "0x1EFC7B0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C2CA RID: 49866
		[Token(Token = "0x40091F9")]
		[FieldOffset(Offset = "0x10")]
		public PartyData[] PartyDatas;
	}
}
