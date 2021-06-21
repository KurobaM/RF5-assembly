using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000105 RID: 261
[Token(Token = "0x20000CC")]
public class Wind : MonoBehaviour
{
	// Token: 0x0600059D RID: 1437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x1E50F70", Offset = "0x1E51071", VA = "0x1E50F70")]
	private void Update()
	{
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x1E510C0", Offset = "0x1E511C1", VA = "0x1E510C0")]
	public Wind()
	{
	}

	// Token: 0x040002EF RID: 751
	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_init_x;

	// Token: 0x040002F0 RID: 752
	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_init_y;

	// Token: 0x040002F1 RID: 753
	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_init_z;

	// Token: 0x040002F2 RID: 754
	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float m_time_scale_x;

	// Token: 0x040002F3 RID: 755
	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_time_scale_y;

	// Token: 0x040002F4 RID: 756
	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float m_time_scale_z;

	// Token: 0x040002F5 RID: 757
	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x0")]
	public static float m_x;

	// Token: 0x040002F6 RID: 758
	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x4")]
	public static float m_y;

	// Token: 0x040002F7 RID: 759
	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x8")]
	public static float m_z;

	// Token: 0x040002F8 RID: 760
	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x30")]
	private float m_time_x;

	// Token: 0x040002F9 RID: 761
	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x34")]
	private float m_time_y;

	// Token: 0x040002FA RID: 762
	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x38")]
	private float m_time_z;
}
