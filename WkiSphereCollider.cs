using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005B5 RID: 1461
[Token(Token = "0x2000417")]
public class WkiSphereCollider : MonoBehaviour
{
	// Token: 0x060023C1 RID: 9153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E07")]
	[Address(RVA = "0x1E51150", Offset = "0x1E51251", VA = "0x1E51150")]
	protected void Start()
	{
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E08")]
	[Address(RVA = "0x1E51200", Offset = "0x1E51301", VA = "0x1E51200")]
	protected void OnEnable()
	{
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E09")]
	[Address(RVA = "0x1E51240", Offset = "0x1E51341", VA = "0x1E51240")]
	public void OnFixeUpdate()
	{
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E0A")]
	[Address(RVA = "0x1E51530", Offset = "0x1E51631", VA = "0x1E51530")]
	protected void ResetBackupPosition(Vector3 position)
	{
	}

	// Token: 0x060023C5 RID: 9157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E0B")]
	[Address(RVA = "0x1E512A0", Offset = "0x1E513A1", VA = "0x1E512A0")]
	protected void CheckHit()
	{
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E0C")]
	[Address(RVA = "0x1E51540", Offset = "0x1E51641", VA = "0x1E51540")]
	public void SetRadius(float radius)
	{
	}

	// Token: 0x060023C7 RID: 9159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E0D")]
	[Address(RVA = "0x1E51550", Offset = "0x1E51651", VA = "0x1E51550")]
	public WkiSphereCollider()
	{
	}

	// Token: 0x04006B6A RID: 27498
	[Token(Token = "0x40064C1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float m_Radius;

	// Token: 0x04006B6B RID: 27499
	[Token(Token = "0x40064C2")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public Vector3 m_Center;

	// Token: 0x04006B6C RID: 27500
	[Token(Token = "0x40064C3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public WkiHitEvent m_HitEvent;

	// Token: 0x04006B6D RID: 27501
	[Token(Token = "0x40064C4")]
	[FieldOffset(Offset = "0x30")]
	protected LayerMask m_HitLayerMask;

	// Token: 0x04006B6E RID: 27502
	[Token(Token = "0x40064C5")]
	[FieldOffset(Offset = "0x34")]
	protected Vector3 m_BackupPosition;
}
