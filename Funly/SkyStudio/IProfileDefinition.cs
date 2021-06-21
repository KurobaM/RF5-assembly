using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DFE RID: 3582
	[Token(Token = "0x2000926")]
	public interface IProfileDefinition
	{
		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06005C12 RID: 23570
		[Token(Token = "0x1700092A")]
		string shaderName { [Token(Token = "0x6004C2D")] get; }

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06005C13 RID: 23571
		[Token(Token = "0x1700092B")]
		ProfileFeatureSection[] features { [Token(Token = "0x6004C2E")] get; }

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06005C14 RID: 23572
		[Token(Token = "0x1700092C")]
		ProfileGroupSection[] groups { [Token(Token = "0x6004C2F")] get; }

		// Token: 0x06005C15 RID: 23573
		[Token(Token = "0x6004C30")]
		ProfileFeatureDefinition GetFeatureDefinition(string featureKey);
	}
}
