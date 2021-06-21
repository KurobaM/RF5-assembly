using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DF0 RID: 3568
	[Token(Token = "0x2000919")]
	public class ProfileGroupSection
	{
		// Token: 0x06005BFA RID: 23546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x23DAA30", Offset = "0x23DAB31", VA = "0x23DAA30")]
		public ProfileGroupSection(string sectionTitle, string sectionKey, string sectionIcon, string dependsOnFeature, bool dependsOnValue, ProfileGroupDefinition[] groups)
		{
		}

		// Token: 0x0400BB84 RID: 48004
		[Token(Token = "0x4008BF5")]
		[FieldOffset(Offset = "0x10")]
		public string sectionTitle;

		// Token: 0x0400BB85 RID: 48005
		[Token(Token = "0x4008BF6")]
		[FieldOffset(Offset = "0x18")]
		public string sectionIcon;

		// Token: 0x0400BB86 RID: 48006
		[Token(Token = "0x4008BF7")]
		[FieldOffset(Offset = "0x20")]
		public string sectionKey;

		// Token: 0x0400BB87 RID: 48007
		[Token(Token = "0x4008BF8")]
		[FieldOffset(Offset = "0x28")]
		public string dependsOnFeature;

		// Token: 0x0400BB88 RID: 48008
		[Token(Token = "0x4008BF9")]
		[FieldOffset(Offset = "0x30")]
		public bool dependsOnValue;

		// Token: 0x0400BB89 RID: 48009
		[Token(Token = "0x4008BFA")]
		[FieldOffset(Offset = "0x38")]
		public ProfileGroupDefinition[] groups;
	}
}
