using System;
using Il2CppDummyDll;
using Loader.ID;

// Token: 0x020003B5 RID: 949
[Token(Token = "0x20002DB")]
public class PreloadMasterDataLoader : DataLoader<MasterPreload, PreloadMasterDataLoader>
{
	// Token: 0x1700041B RID: 1051
	// (get) Token: 0x06001755 RID: 5973 RVA: 0x0000A308 File Offset: 0x00008508
	[Token(Token = "0x170003B1")]
	protected override int LoadPriority
	{
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x280AEB0", Offset = "0x280AFB1", VA = "0x280AEB0", Slot = "5")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C0")]
	[Address(RVA = "0x280AEC0", Offset = "0x280AFC1", VA = "0x280AEC0")]
	public PreloadMasterDataLoader()
	{
	}
}
