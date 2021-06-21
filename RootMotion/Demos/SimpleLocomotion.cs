using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CF0 RID: 3312
	[Token(Token = "0x2000885")]
	[Attribute(Name = "RequireComponent", RVA = "0x147DD0", Offset = "0x147ED1")]
	public class SimpleLocomotion : MonoBehaviour
	{
		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060054A7 RID: 21671 RVA: 0x0001BE40 File Offset: 0x0001A040
		// (set) Token: 0x060054A8 RID: 21672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089E")]
		public bool isGrounded
		{
			[Token(Token = "0x600468B")]
			[Address(RVA = "0x28625E0", Offset = "0x28626E1", VA = "0x28625E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9920", Offset = "0x1A9A21")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600468C")]
			[Address(RVA = "0x28625F0", Offset = "0x28626F1", VA = "0x28625F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9930", Offset = "0x1A9A31")]
			private set
			{
			}
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468D")]
		[Address(RVA = "0x2862600", Offset = "0x2862701", VA = "0x2862600")]
		private void Start()
		{
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468E")]
		[Address(RVA = "0x28626A0", Offset = "0x28627A1", VA = "0x28626A0")]
		private void Update()
		{
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468F")]
		[Address(RVA = "0x2862E30", Offset = "0x2862F31", VA = "0x2862E30")]
		private void LateUpdate()
		{
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004690")]
		[Address(RVA = "0x2862700", Offset = "0x2862801", VA = "0x2862700")]
		private void Rotate()
		{
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004691")]
		[Address(RVA = "0x2862B80", Offset = "0x2862C81", VA = "0x2862B80")]
		private void Move()
		{
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x0001BE58 File Offset: 0x0001A058
		[Token(Token = "0x6004692")]
		[Address(RVA = "0x2862E70", Offset = "0x2862F71", VA = "0x2862E70")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x0001BE70 File Offset: 0x0001A070
		[Token(Token = "0x6004693")]
		[Address(RVA = "0x2862F70", Offset = "0x2863071", VA = "0x2862F70")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004694")]
		[Address(RVA = "0x2863010", Offset = "0x2863111", VA = "0x2863010")]
		public SimpleLocomotion()
		{
		}

		// Token: 0x0400B417 RID: 46103
		[Token(Token = "0x4008745")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1784F0", Offset = "0x1785F1")]
		public CameraController cameraController;

		// Token: 0x0400B418 RID: 46104
		[Token(Token = "0x4008746")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178530", Offset = "0x178631")]
		public float accelerationTime;

		// Token: 0x0400B419 RID: 46105
		[Token(Token = "0x4008747")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178570", Offset = "0x178671")]
		public float turnTime;

		// Token: 0x0400B41A RID: 46106
		[Token(Token = "0x4008748")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1785B0", Offset = "0x1786B1")]
		public bool walkByDefault;

		// Token: 0x0400B41B RID: 46107
		[Token(Token = "0x4008749")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1785F0", Offset = "0x1786F1")]
		public SimpleLocomotion.RotationMode rotationMode;

		// Token: 0x0400B41C RID: 46108
		[Token(Token = "0x400874A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178630", Offset = "0x178731")]
		public float moveSpeed;

		// Token: 0x0400B41D RID: 46109
		[Token(Token = "0x400874B")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x178670", Offset = "0x178771")]
		private bool <isGrounded>k__BackingField;

		// Token: 0x0400B41E RID: 46110
		[Token(Token = "0x400874C")]
		[FieldOffset(Offset = "0x38")]
		private Animator animator;

		// Token: 0x0400B41F RID: 46111
		[Token(Token = "0x400874D")]
		[FieldOffset(Offset = "0x40")]
		private float speed;

		// Token: 0x0400B420 RID: 46112
		[Token(Token = "0x400874E")]
		[FieldOffset(Offset = "0x44")]
		private float angleVel;

		// Token: 0x0400B421 RID: 46113
		[Token(Token = "0x400874F")]
		[FieldOffset(Offset = "0x48")]
		private float speedVel;

		// Token: 0x0400B422 RID: 46114
		[Token(Token = "0x4008750")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		// Token: 0x0400B423 RID: 46115
		[Token(Token = "0x4008751")]
		[FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		// Token: 0x02000CF1 RID: 3313
		[Token(Token = "0x20013E4")]
		[Serializable]
		public enum RotationMode
		{
			// Token: 0x0400B425 RID: 46117
			[Token(Token = "0x401B917")]
			Smooth,
			// Token: 0x0400B426 RID: 46118
			[Token(Token = "0x401B918")]
			Linear
		}
	}
}
