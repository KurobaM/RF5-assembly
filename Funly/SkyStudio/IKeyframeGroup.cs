using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DDD RID: 3549
	[Token(Token = "0x2000909")]
	public interface IKeyframeGroup
	{
		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06005BA2 RID: 23458
		// (set) Token: 0x06005BA3 RID: 23459
		[Token(Token = "0x1700091A")]
		string name { [Token(Token = "0x6004BBD")] get; [Token(Token = "0x6004BBE")] set; }

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06005BA4 RID: 23460
		[Token(Token = "0x1700091B")]
		string id { [Token(Token = "0x6004BBF")] get; }

		// Token: 0x06005BA5 RID: 23461
		[Token(Token = "0x6004BC0")]
		void SortKeyframes();

		// Token: 0x06005BA6 RID: 23462
		[Token(Token = "0x6004BC1")]
		void TrimToSingleKeyframe();

		// Token: 0x06005BA7 RID: 23463
		[Token(Token = "0x6004BC2")]
		void RemoveKeyFrame(IBaseKeyframe keyframe);

		// Token: 0x06005BA8 RID: 23464
		[Token(Token = "0x6004BC3")]
		int GetKeyFrameCount();
	}
}
