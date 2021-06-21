using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CEB RID: 3307
	[Token(Token = "0x2000883")]
	[Attribute(Name = "RequireComponent", RVA = "0x147D40", Offset = "0x147E41")]
	[Attribute(Name = "RequireComponent", RVA = "0x147D40", Offset = "0x147E41")]
	public abstract class CharacterBase : MonoBehaviour
	{
		// Token: 0x06005484 RID: 21636
		[Token(Token = "0x600466E")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		// Token: 0x06005485 RID: 21637 RVA: 0x0001BD50 File Offset: 0x00019F50
		[Token(Token = "0x600466F")]
		[Address(RVA = "0x29AEB80", Offset = "0x29AEC81", VA = "0x29AEB80")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004670")]
		[Address(RVA = "0x29AED10", Offset = "0x29AEE11", VA = "0x29AED10", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x0001BD68 File Offset: 0x00019F68
		[Token(Token = "0x6004671")]
		[Address(RVA = "0x29AEEE0", Offset = "0x29AEFE1", VA = "0x29AEEE0", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x0001BD80 File Offset: 0x00019F80
		[Token(Token = "0x6004672")]
		[Address(RVA = "0x29AF170", Offset = "0x29AF271", VA = "0x29AF170")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return 0f;
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004673")]
		[Address(RVA = "0x29AF240", Offset = "0x29AF341", VA = "0x29AF240")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004674")]
		[Address(RVA = "0x29AF430", Offset = "0x29AF531", VA = "0x29AF430")]
		protected void ScaleCapsule(float mlp)
		{
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004675")]
		[Address(RVA = "0x29AF5E0", Offset = "0x29AF6E1", VA = "0x29AF5E0")]
		protected void HighFriction()
		{
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004676")]
		[Address(RVA = "0x29AF610", Offset = "0x29AF711", VA = "0x29AF610")]
		protected void ZeroFriction()
		{
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x0001BD98 File Offset: 0x00019F98
		[Token(Token = "0x6004677")]
		[Address(RVA = "0x29AF640", Offset = "0x29AF741", VA = "0x29AF640")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return 0f;
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004678")]
		[Address(RVA = "0x29AF750", Offset = "0x29AF851", VA = "0x29AF750")]
		protected CharacterBase()
		{
		}

		// Token: 0x0400B3C1 RID: 46017
		[Token(Token = "0x40086FF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1782C0", Offset = "0x1783C1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1782C0", Offset = "0x1783C1")]
		public Transform gravityTarget;

		// Token: 0x0400B3C2 RID: 46018
		[Token(Token = "0x4008700")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178320", Offset = "0x178421")]
		public float gravityMultiplier;

		// Token: 0x0400B3C3 RID: 46019
		[Token(Token = "0x4008701")]
		[FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		// Token: 0x0400B3C4 RID: 46020
		[Token(Token = "0x4008702")]
		[FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		// Token: 0x0400B3C5 RID: 46021
		[Token(Token = "0x4008703")]
		[FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		// Token: 0x0400B3C6 RID: 46022
		[Token(Token = "0x4008704")]
		[FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		// Token: 0x0400B3C7 RID: 46023
		[Token(Token = "0x4008705")]
		[FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		// Token: 0x0400B3C8 RID: 46024
		[Token(Token = "0x4008706")]
		[FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		// Token: 0x0400B3C9 RID: 46025
		[Token(Token = "0x4008707")]
		[FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		// Token: 0x0400B3CA RID: 46026
		[Token(Token = "0x4008708")]
		[FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		// Token: 0x0400B3CB RID: 46027
		[Token(Token = "0x4008709")]
		protected const float half = 0.5f;

		// Token: 0x0400B3CC RID: 46028
		[Token(Token = "0x400870A")]
		[FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		// Token: 0x0400B3CD RID: 46029
		[Token(Token = "0x400870B")]
		[FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		// Token: 0x0400B3CE RID: 46030
		[Token(Token = "0x400870C")]
		[FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;
	}
}
