using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BA9 RID: 2985
[Token(Token = "0x20007BE")]
[Attribute(Name = "RequireComponent", RVA = "0x1474C0", Offset = "0x1475C1")]
public class PhysicCullingSystem : MonoBehaviour
{
	// Token: 0x06004C65 RID: 19557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004012")]
	[Address(RVA = "0x2142580", Offset = "0x2142681", VA = "0x2142580")]
	private void Start()
	{
	}

	// Token: 0x06004C66 RID: 19558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004013")]
	[Address(RVA = "0x21427C0", Offset = "0x21428C1", VA = "0x21427C0")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06004C67 RID: 19559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004014")]
	[Address(RVA = "0x2142830", Offset = "0x2142931", VA = "0x2142830")]
	private void CheckVisibility()
	{
	}

	// Token: 0x06004C68 RID: 19560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004015")]
	[Address(RVA = "0x21428E0", Offset = "0x21429E1", VA = "0x21428E0")]
	public void Update()
	{
	}

	// Token: 0x06004C69 RID: 19561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004016")]
	[Address(RVA = "0x2142A00", Offset = "0x2142B01", VA = "0x2142A00")]
	private void StateChangedMethod(CullingGroupEvent evt)
	{
	}

	// Token: 0x06004C6A RID: 19562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004017")]
	[Address(RVA = "0x2142AB0", Offset = "0x2142BB1", VA = "0x2142AB0")]
	private void OnDisable()
	{
	}

	// Token: 0x06004C6B RID: 19563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004018")]
	[Address(RVA = "0x2142A50", Offset = "0x2142B51", VA = "0x2142A50")]
	private void StopMovement()
	{
	}

	// Token: 0x06004C6C RID: 19564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004019")]
	[Address(RVA = "0x2142880", Offset = "0x2142981", VA = "0x2142880")]
	private void StartMovement()
	{
	}

	// Token: 0x06004C6D RID: 19565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600401A")]
	[Address(RVA = "0x2142B00", Offset = "0x2142C01", VA = "0x2142B00")]
	public PhysicCullingSystem()
	{
	}

	// Token: 0x0400ADD4 RID: 44500
	[Token(Token = "0x40082FD")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176060", Offset = "0x176161")]
	public float physicDistance;

	// Token: 0x0400ADD5 RID: 44501
	[Token(Token = "0x40082FE")]
	[FieldOffset(Offset = "0x1C")]
	private float sphereSize;

	// Token: 0x0400ADD6 RID: 44502
	[Token(Token = "0x40082FF")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rigidbody_;

	// Token: 0x0400ADD7 RID: 44503
	[Token(Token = "0x4008300")]
	[FieldOffset(Offset = "0x28")]
	private CullingGroup group;

	// Token: 0x0400ADD8 RID: 44504
	[Token(Token = "0x4008301")]
	[FieldOffset(Offset = "0x30")]
	private BoundingSphere[] spheres;

	// Token: 0x0400ADD9 RID: 44505
	[Token(Token = "0x4008302")]
	[FieldOffset(Offset = "0x38")]
	private Camera mainCamera;

	// Token: 0x0400ADDA RID: 44506
	[Token(Token = "0x4008303")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HideInInspector", RVA = "0x1760A0", Offset = "0x1761A1")]
	public Vector3 velocity;

	// Token: 0x0400ADDB RID: 44507
	[Token(Token = "0x4008304")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "HideInInspector", RVA = "0x1760B0", Offset = "0x1761B1")]
	public Vector3 angularVelocity;

	// Token: 0x0400ADDC RID: 44508
	[Token(Token = "0x4008305")]
	[FieldOffset(Offset = "0x58")]
	public bool gizmo;
}
