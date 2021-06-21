using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AB RID: 427
[Token(Token = "0x200014F")]
public interface IPlayerCamera
{
	// Token: 0x060008E1 RID: 2273
	[Token(Token = "0x60007A6")]
	void PreUpdate();

	// Token: 0x060008E2 RID: 2274
	[Token(Token = "0x60007A7")]
	void FrameUpdate();

	// Token: 0x060008E3 RID: 2275
	[Token(Token = "0x60007A8")]
	void TimeStepUpdate();

	// Token: 0x060008E4 RID: 2276
	[Token(Token = "0x60007A9")]
	void CameraReset(Quaternion? resetRotation);

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x060008E5 RID: 2277
	// (set) Token: 0x060008E6 RID: 2278
	[Token(Token = "0x1700019A")]
	float DistanceOffset { [Token(Token = "0x60007AA")] get; [Token(Token = "0x60007AB")] set; }
}
