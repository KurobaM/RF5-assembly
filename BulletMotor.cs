using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000198 RID: 408
[Token(Token = "0x2000143")]
public class BulletMotor : MonoBehaviour, IBulletModule
{
	// Token: 0x1700019E RID: 414
	// (get) Token: 0x0600085C RID: 2140 RVA: 0x00004CC8 File Offset: 0x00002EC8
	// (set) Token: 0x0600085D RID: 2141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000189")]
	public Vector3 velocity
	{
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x2193D00", Offset = "0x2193E01", VA = "0x2193D00")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x2193D20", Offset = "0x2193E21", VA = "0x2193D20")]
		set
		{
		}
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072E")]
	[Address(RVA = "0x2191DA0", Offset = "0x2191EA1", VA = "0x2191DA0")]
	public void Stop()
	{
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072F")]
	[Address(RVA = "0x218F7A0", Offset = "0x218F8A1", VA = "0x218F7A0", Slot = "4")]
	public void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000730")]
	[Address(RVA = "0x2190110", Offset = "0x2190211", VA = "0x2190110", Slot = "5")]
	public void OnUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000731")]
	[Address(RVA = "0x218F940", Offset = "0x218FA41", VA = "0x218F940", Slot = "6")]
	public void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x2191E40", Offset = "0x2191F41", VA = "0x2191E40")]
	public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
	{
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x2198D20", Offset = "0x2198E21", VA = "0x2198D20")]
	private void ApplyMovement(BulletBase bullet, MovementVelocity velocity, Vector3 desiredVelocity, float acceleration, float deltaTime)
	{
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00004CE0 File Offset: 0x00002EE0
	[Token(Token = "0x6000734")]
	[Address(RVA = "0x2198F50", Offset = "0x2199051", VA = "0x2198F50")]
	public Vector3 MoveDeltaPosition(BulletBase bullet, Vector3 deltaPosition, float deltaTime)
	{
		return default(Vector3);
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x21990A0", Offset = "0x21991A1", VA = "0x21990A0")]
	private void UpdateGrounder(BulletBase bullet, Vector3 deltaPosition)
	{
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000736")]
	[Address(RVA = "0x21996A0", Offset = "0x21997A1", VA = "0x21996A0")]
	public BulletMotor()
	{
	}

	// Token: 0x040004EC RID: 1260
	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x0")]
	private static float kGrounderMaxHeight;

	// Token: 0x040004ED RID: 1261
	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x4")]
	private static float kGrounderStepOffset;

	// Token: 0x040004EE RID: 1262
	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x8")]
	private static float kGrounderKickback;

	// Token: 0x040004EF RID: 1263
	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public BulletMotorType type;

	// Token: 0x040004F0 RID: 1264
	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float maxSpeed;

	// Token: 0x040004F1 RID: 1265
	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float minSpeed;

	// Token: 0x040004F2 RID: 1266
	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float acceleration;

	// Token: 0x040004F3 RID: 1267
	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x28")]
	private MovementVelocity m_Velocity;
}
