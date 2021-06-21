using System;
using Il2CppDummyDll;

namespace Loader
{
	// Token: 0x02001019 RID: 4121
	[Token(Token = "0x2000A70")]
	[Serializable]
	public class AssetInfo
	{
		// Token: 0x060067D4 RID: 26580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566D")]
		[Address(RVA = "0x2311B30", Offset = "0x2311C31", VA = "0x2311B30")]
		public AssetInfo()
		{
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566E")]
		[Address(RVA = "0x2311B40", Offset = "0x2311C41", VA = "0x2311B40")]
		public AssetInfo(AssetInfo info)
		{
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566F")]
		[Address(RVA = "0x2311BF0", Offset = "0x2311CF1", VA = "0x2311BF0")]
		public void Initialize()
		{
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005670")]
		[Address(RVA = "0x2311CB0", Offset = "0x2311DB1", VA = "0x2311CB0")]
		public void SetAddress(string region, int id, string key, bool switching)
		{
		}

		// Token: 0x0400C74E RID: 51022
		[Token(Token = "0x40093E6")]
		[FieldOffset(Offset = "0x10")]
		public int Id;

		// Token: 0x0400C74F RID: 51023
		[Token(Token = "0x40093E7")]
		[FieldOffset(Offset = "0x18")]
		public string Key;

		// Token: 0x0400C750 RID: 51024
		[Token(Token = "0x40093E8")]
		[FieldOffset(Offset = "0x20")]
		public string Address;

		// Token: 0x0400C751 RID: 51025
		[Token(Token = "0x40093E9")]
		[FieldOffset(Offset = "0x28")]
		public string Region;

		// Token: 0x0400C752 RID: 51026
		[Token(Token = "0x40093EA")]
		[FieldOffset(Offset = "0x30")]
		public bool Switching;

		// Token: 0x0400C753 RID: 51027
		[Token(Token = "0x40093EB")]
		[FieldOffset(Offset = "0x38")]
		public string Label;

		// Token: 0x0400C754 RID: 51028
		[Token(Token = "0x40093EC")]
		[FieldOffset(Offset = "0x40")]
		public string Group;

		// Token: 0x0400C755 RID: 51029
		[Token(Token = "0x40093ED")]
		[FieldOffset(Offset = "0x48")]
		public string Guid;

		// Token: 0x0400C756 RID: 51030
		[Token(Token = "0x40093EE")]
		[FieldOffset(Offset = "0x50")]
		public string Path;
	}
}
