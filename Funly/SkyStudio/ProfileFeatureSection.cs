using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DF3 RID: 3571
	[Token(Token = "0x200091B")]
	[Serializable]
	public class ProfileFeatureSection
	{
		// Token: 0x06005BFF RID: 23551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x23DA2F0", Offset = "0x23DA3F1", VA = "0x23DA2F0")]
		public ProfileFeatureSection(string sectionTitle, string sectionKey, ProfileFeatureDefinition[] featureDefinitions)
		{
		}

		// Token: 0x0400BB9B RID: 48027
		[Token(Token = "0x4008C08")]
		[FieldOffset(Offset = "0x10")]
		public string sectionTitle;

		// Token: 0x0400BB9C RID: 48028
		[Token(Token = "0x4008C09")]
		[FieldOffset(Offset = "0x18")]
		public string sectionKey;

		// Token: 0x0400BB9D RID: 48029
		[Token(Token = "0x4008C0A")]
		[FieldOffset(Offset = "0x20")]
		public string sectionIcon;

		// Token: 0x0400BB9E RID: 48030
		[Token(Token = "0x4008C0B")]
		[FieldOffset(Offset = "0x28")]
		public ProfileFeatureDefinition[] featureDefinitions;
	}
}
