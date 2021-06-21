using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B43 RID: 2883
[Token(Token = "0x2000786")]
public class DynamicBoneColliderBase : MonoBehaviour
{
	// Token: 0x06004A53 RID: 19027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E40")]
	[Address(RVA = "0x22A9A20", Offset = "0x22A9B21", VA = "0x22A9A20", Slot = "4")]
	public virtual void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	// Token: 0x06004A54 RID: 19028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E41")]
	[Address(RVA = "0x22A99A0", Offset = "0x22A9AA1", VA = "0x22A99A0")]
	public DynamicBoneColliderBase()
	{
	}

	// Token: 0x0400AA89 RID: 43657
	[Token(Token = "0x4008099")]
	[FieldOffset(Offset = "0x18")]
	public DynamicBoneColliderBase.Direction m_Direction;

	// Token: 0x0400AA8A RID: 43658
	[Token(Token = "0x400809A")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 m_Center;

	// Token: 0x0400AA8B RID: 43659
	[Token(Token = "0x400809B")]
	[FieldOffset(Offset = "0x28")]
	public DynamicBoneColliderBase.Bound m_Bound;

	// Token: 0x02000B44 RID: 2884
	[Token(Token = "0x200133F")]
	public enum Direction
	{
		// Token: 0x0400AA8D RID: 43661
		[Token(Token = "0x401B654")]
		X,
		// Token: 0x0400AA8E RID: 43662
		[Token(Token = "0x401B655")]
		Y,
		// Token: 0x0400AA8F RID: 43663
		[Token(Token = "0x401B656")]
		Z
	}

	// Token: 0x02000B45 RID: 2885
	[Token(Token = "0x2001340")]
	public enum Bound
	{
		// Token: 0x0400AA91 RID: 43665
		[Token(Token = "0x401B658")]
		Outside,
		// Token: 0x0400AA92 RID: 43666
		[Token(Token = "0x401B659")]
		Inside
	}
}
