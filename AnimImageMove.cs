using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000021 RID: 33
[Token(Token = "0x2000020")]
public class AnimImageMove : MonoBehaviour
{
	// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2435B90", Offset = "0x2435C91", VA = "0x2435B90")]
	private void Start()
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2435E80", Offset = "0x2435F81", VA = "0x2435E80")]
	private void Update()
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2436280", Offset = "0x2436381", VA = "0x2436280")]
	public void DublicatePlaySelf()
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x24364A0", Offset = "0x24365A1", VA = "0x24364A0")]
	public AnimImageMove()
	{
	}

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float LifeTime;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector2 MoveRangeMin;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector2 MoveRangeMax;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector2 MoveSpeed;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector2 Force;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve XCurve;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AnimationCurve YCurve;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AnimationCurve FadeColorCurve;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve ScaleCurve;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Vector2 GenerateRange;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x68")]
	private Vector2 MoveRange;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 CurveRate;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 StartScale;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x84")]
	private float nowTime;

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x88")]
	private Image Image;

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x90")]
	private Vector2 basePos;
}
