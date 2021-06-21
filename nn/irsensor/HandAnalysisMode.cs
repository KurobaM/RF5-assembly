using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x0200150E RID: 5390
	[Token(Token = "0x2000EC9")]
	public enum HandAnalysisMode
	{
		// Token: 0x0401BD93 RID: 114067
		[Token(Token = "0x401873C")]
		None,
		// Token: 0x0401BD94 RID: 114068
		[Token(Token = "0x401873D")]
		Silhouette,
		// Token: 0x0401BD95 RID: 114069
		[Token(Token = "0x401873E")]
		Image,
		// Token: 0x0401BD96 RID: 114070
		[Token(Token = "0x401873F")]
		SilhouetteAndImage,
		// Token: 0x0401BD97 RID: 114071
		[Token(Token = "0x4018740")]
		SilhouetteOnly
	}
}
