using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DE7 RID: 3559
	[Token(Token = "0x2000913")]
	public interface IBaseKeyframe
	{
		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06005BDE RID: 23518
		[Token(Token = "0x17000923")]
		string id { [Token(Token = "0x6004BF9")] get; }

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06005BDF RID: 23519
		// (set) Token: 0x06005BE0 RID: 23520
		[Token(Token = "0x17000924")]
		float time { [Token(Token = "0x6004BFA")] get; [Token(Token = "0x6004BFB")] set; }

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06005BE1 RID: 23521
		// (set) Token: 0x06005BE2 RID: 23522
		[Token(Token = "0x17000925")]
		InterpolationCurve interpolationCurve { [Token(Token = "0x6004BFC")] get; [Token(Token = "0x6004BFD")] set; }

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06005BE3 RID: 23523
		// (set) Token: 0x06005BE4 RID: 23524
		[Token(Token = "0x17000926")]
		InterpolationDirection interpolationDirection { [Token(Token = "0x6004BFE")] get; [Token(Token = "0x6004BFF")] set; }
	}
}
