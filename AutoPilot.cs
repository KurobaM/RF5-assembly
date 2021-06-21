using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025C RID: 604
[Token(Token = "0x20001E4")]
public class AutoPilot : MonoBehaviour
{
	// Token: 0x06000EC6 RID: 3782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D56")]
	[Address(RVA = "0x228F8E0", Offset = "0x228F9E1", VA = "0x228F8E0")]
	private void Awake()
	{
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D57")]
	[Address(RVA = "0x228F9F0", Offset = "0x228FAF1", VA = "0x228F9F0")]
	private void Update()
	{
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D58")]
	[Address(RVA = "0x228F8F0", Offset = "0x228F9F1", VA = "0x228F8F0")]
	[Attribute(Name = "ContextMenu", RVA = "0x19C110", Offset = "0x19C211")]
	private void ResetTotalWeight()
	{
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x228FB90", Offset = "0x228FC91", VA = "0x228FB90")]
	private void SetInterval()
	{
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00006A38 File Offset: 0x00004C38
	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0x228FBD0", Offset = "0x228FCD1", VA = "0x228FBD0")]
	public Vector3 InputDirection()
	{
		return default(Vector3);
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0x228FCE0", Offset = "0x228FDE1", VA = "0x228FCE0")]
	public AutoPilot()
	{
	}

	// Token: 0x04000888 RID: 2184
	[Token(Token = "0x40006D3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float IntervalBase;

	// Token: 0x04000889 RID: 2185
	[Token(Token = "0x40006D4")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float IntervalRange;

	// Token: 0x0400088A RID: 2186
	[Token(Token = "0x40006D5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int[] padPatternWeight;

	// Token: 0x0400088B RID: 2187
	[Token(Token = "0x40006D6")]
	[FieldOffset(Offset = "0x28")]
	private int totalWeight;

	// Token: 0x0400088C RID: 2188
	[Token(Token = "0x40006D7")]
	[FieldOffset(Offset = "0x2C")]
	private AutoPilot.PadPattern padPattern;

	// Token: 0x0400088D RID: 2189
	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0x30")]
	private float intervalSec;

	// Token: 0x0200025D RID: 605
	[Token(Token = "0x2001001")]
	private enum PadPattern
	{
		// Token: 0x0400088F RID: 2191
		[Token(Token = "0x4018E29")]
		NONE,
		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4018E2A")]
		LA_UP,
		// Token: 0x04000891 RID: 2193
		[Token(Token = "0x4018E2B")]
		LA_DN,
		// Token: 0x04000892 RID: 2194
		[Token(Token = "0x4018E2C")]
		LA_LT,
		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4018E2D")]
		LA_RT,
		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4018E2E")]
		LA_LU,
		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4018E2F")]
		LA_LD,
		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4018E30")]
		LA_RU,
		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4018E31")]
		LA_RD,
		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4018E32")]
		Length
	}
}
