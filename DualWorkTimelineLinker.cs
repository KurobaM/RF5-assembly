using System;
using DualWork;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008C8 RID: 2248
[Token(Token = "0x20005D6")]
public class DualWorkTimelineLinker : MonoBehaviour
{
	// Token: 0x06003B66 RID: 15206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031C8")]
	[Address(RVA = "0x1E0E140", Offset = "0x1E0E241", VA = "0x1E0E140")]
	private void Reset()
	{
	}

	// Token: 0x06003B67 RID: 15207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031C9")]
	[Address(RVA = "0x1E0E1F0", Offset = "0x1E0E2F1", VA = "0x1E0E1F0")]
	public DualWorkTimelineLinker()
	{
	}

	// Token: 0x04007E2C RID: 32300
	[Token(Token = "0x40071E6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public DualWorkSetup MainTimeline;

	// Token: 0x04007E2D RID: 32301
	[Token(Token = "0x40071E7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public UIDualWork UITimeline;

	// Token: 0x04007E2E RID: 32302
	[Token(Token = "0x40071E8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public DualWorkTrackMute[] TrackMuteArray;
}
