using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200031A RID: 794
[Token(Token = "0x2000256")]
public interface IStateMachine
{
	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x06001513 RID: 5395
	[Token(Token = "0x17000366")]
	MonoBehaviour Component { [Token(Token = "0x60012D7")] get; }

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06001514 RID: 5396
	[Token(Token = "0x17000367")]
	StateElement CurrentState { [Token(Token = "0x60012D8")] get; }

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x06001515 RID: 5397
	[Token(Token = "0x17000368")]
	bool IsInTransition { [Token(Token = "0x60012D9")] get; }

	// Token: 0x170003B7 RID: 951
	// (get) Token: 0x06001516 RID: 5398
	[Token(Token = "0x17000369")]
	bool IsPause { [Token(Token = "0x60012DA")] get; }
}
