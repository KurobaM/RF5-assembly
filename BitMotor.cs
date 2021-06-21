using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F4 RID: 500
[Token(Token = "0x2000192")]
public class BitMotor : MonoBehaviour
{
	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00005220 File Offset: 0x00003420
	// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BC")]
	public float LocomotionValue
	{
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x2455B80", Offset = "0x2455C81", VA = "0x2455B80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B070", Offset = "0x19B171")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x2455B90", Offset = "0x2455C91", VA = "0x2455B90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B080", Offset = "0x19B181")]
		protected set
		{
		}
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00005238 File Offset: 0x00003438
	// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BD")]
	public Vector3 velocity
	{
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x2455BA0", Offset = "0x2455CA1", VA = "0x2455BA0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x2455BC0", Offset = "0x2455CC1", VA = "0x2455BC0")]
		set
		{
		}
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x2455BF0", Offset = "0x2455CF1", VA = "0x2455BF0")]
	public void Awake()
	{
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x24540C0", Offset = "0x24541C1", VA = "0x24540C0")]
	public void Stop()
	{
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x24532E0", Offset = "0x24533E1", VA = "0x24532E0")]
	public void Move(Vector3 direction, float speedRate, bool rotateToward = true)
	{
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x2453F70", Offset = "0x2454071", VA = "0x2453F70")]
	public void Rotate(Vector3 direction)
	{
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x2455F00", Offset = "0x2456001", VA = "0x2455F00")]
	public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
	{
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x2455C80", Offset = "0x2455D81", VA = "0x2455C80")]
	private void ApplyMovement(MovementVelocity velocity, Vector3 desiredVelocity, float deltaTime)
	{
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x00005250 File Offset: 0x00003450
	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x2455F20", Offset = "0x2456021", VA = "0x2455F20")]
	public Vector3 MoveDeltaPosition(Vector3 deltaPosition, float deltaTime)
	{
		return default(Vector3);
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x24560C0", Offset = "0x24561C1", VA = "0x24560C0")]
	public BitMotor()
	{
	}

	// Token: 0x04000672 RID: 1650
	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float maxSpeed;

	// Token: 0x04000673 RID: 1651
	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float minSpeed;

	// Token: 0x04000674 RID: 1652
	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float acceleration;

	// Token: 0x04000675 RID: 1653
	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float deceleration;

	// Token: 0x04000676 RID: 1654
	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float rotateSpeed;

	// Token: 0x04000677 RID: 1655
	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0x30")]
	protected MovementVelocity m_Velocity;

	// Token: 0x04000678 RID: 1656
	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D1B0", Offset = "0x15D2B1")]
	private float <LocomotionValue>k__BackingField;
}
