using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C5 RID: 709
[Token(Token = "0x200022B")]
public class SearchSphereCollider : MonoBehaviour
{
	// Token: 0x17000351 RID: 849
	// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000327")]
	public SearchSphereHitEvent m_HitEvent
	{
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x21E46C0", Offset = "0x21E47C1", VA = "0x21E46C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C770", Offset = "0x19C871")]
		get
		{
			return null;
		}
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x21E46D0", Offset = "0x21E47D1", VA = "0x21E46D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C780", Offset = "0x19C881")]
		set
		{
		}
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110B")]
	[Address(RVA = "0x21E46E0", Offset = "0x21E47E1", VA = "0x21E46E0")]
	protected void Start()
	{
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110C")]
	[Address(RVA = "0x21E4780", Offset = "0x21E4881", VA = "0x21E4780")]
	protected void FixedUpdate()
	{
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110D")]
	[Address(RVA = "0x21E4A70", Offset = "0x21E4B71", VA = "0x21E4A70")]
	protected void ResetBackupPosition(Vector3 position)
	{
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110E")]
	[Address(RVA = "0x21E47E0", Offset = "0x21E48E1", VA = "0x21E47E0")]
	protected void CheckHit()
	{
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110F")]
	[Address(RVA = "0x21E4A80", Offset = "0x21E4B81", VA = "0x21E4A80")]
	public void SetRadius(float radius)
	{
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001110")]
	[Address(RVA = "0x21E4A90", Offset = "0x21E4B91", VA = "0x21E4A90")]
	public SearchSphereCollider()
	{
	}

	// Token: 0x04000A7F RID: 2687
	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x18")]
	protected LayerMask m_HitLayerMask;

	// Token: 0x04000A80 RID: 2688
	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F1B0", Offset = "0x15F2B1")]
	private SearchSphereHitEvent <m_HitEvent>k__BackingField;

	// Token: 0x04000A81 RID: 2689
	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x28")]
	protected Vector3 m_BackupPosition;

	// Token: 0x04000A82 RID: 2690
	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public float m_Radius;

	// Token: 0x04000A83 RID: 2691
	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public Vector3 m_Center;
}
