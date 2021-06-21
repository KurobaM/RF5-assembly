using System;
using Il2CppDummyDll;
using UnityEngine;
using XftWeapon;

// Token: 0x02000624 RID: 1572
[Token(Token = "0x2000470")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x1461F0", Offset = "0x1462F1")]
public class EquipCollision : MonoBehaviour
{
	// Token: 0x17000637 RID: 1591
	// (get) Token: 0x060026CF RID: 9935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004F5")]
	public EquipCollisionHitEvent OnHitEvent
	{
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x22B6E60", Offset = "0x22B6F61", VA = "0x22B6E60")]
		get
		{
			return null;
		}
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020C6")]
	[Address(RVA = "0x22B6E70", Offset = "0x22B6F71", VA = "0x22B6E70")]
	private void Start()
	{
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020C7")]
	[Address(RVA = "0x22B6F10", Offset = "0x22B7011", VA = "0x22B6F10")]
	public void Setup(Vector3 center, Vector3 size)
	{
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020C8")]
	[Address(RVA = "0x22B7110", Offset = "0x22B7211", VA = "0x22B7110")]
	public void Activate()
	{
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020C9")]
	[Address(RVA = "0x22B7130", Offset = "0x22B7231", VA = "0x22B7130")]
	public void Deactivate()
	{
	}

	// Token: 0x060026D4 RID: 9940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020CA")]
	[Address(RVA = "0x22B73B0", Offset = "0x22B74B1", VA = "0x22B73B0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020CB")]
	[Address(RVA = "0x22B7420", Offset = "0x22B7521", VA = "0x22B7420")]
	public EquipCollision()
	{
	}

	// Token: 0x04006DAD RID: 28077
	[Token(Token = "0x40066A1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private BoxCollider m_BoxCollider;

	// Token: 0x04006DAE RID: 28078
	[Token(Token = "0x40066A2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private XWeaponTrail m_XWeaponTrail;

	// Token: 0x04006DAF RID: 28079
	[Token(Token = "0x40066A3")]
	[FieldOffset(Offset = "0x28")]
	private EquipCollisionHitEvent m_OnHitEvent;
}
