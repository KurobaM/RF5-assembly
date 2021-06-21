using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000DA7 RID: 3495
	[Token(Token = "0x20008EA")]
	public class VRIKRootController : MonoBehaviour
	{
		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06005A57 RID: 23127 RVA: 0x0001DB08 File Offset: 0x0001BD08
		// (set) Token: 0x06005A58 RID: 23128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008FB")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6004A9C")]
			[Address(RVA = "0x27D5440", Offset = "0x27D5541", VA = "0x27D5440")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABA40", Offset = "0x1ABB41")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004A9D")]
			[Address(RVA = "0x27D5450", Offset = "0x27D5551", VA = "0x27D5450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABA50", Offset = "0x1ABB51")]
			private set
			{
			}
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9E")]
		[Address(RVA = "0x27D5460", Offset = "0x27D5561", VA = "0x27D5460")]
		private void Awake()
		{
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9F")]
		[Address(RVA = "0x27D3D80", Offset = "0x27D3E81", VA = "0x27D3D80")]
		public void Calibrate()
		{
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA0")]
		[Address(RVA = "0x27D4F20", Offset = "0x27D5021", VA = "0x27D4F20")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		// Token: 0x06005A5C RID: 23132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA1")]
		[Address(RVA = "0x27D5560", Offset = "0x27D5661", VA = "0x27D5560")]
		private void OnPreUpdate()
		{
		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA2")]
		[Address(RVA = "0x27D5A10", Offset = "0x27D5B11", VA = "0x27D5A10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA3")]
		[Address(RVA = "0x27D5B30", Offset = "0x27D5C31", VA = "0x27D5B30")]
		public VRIKRootController()
		{
		}

		// Token: 0x0400B9BC RID: 47548
		[Token(Token = "0x4008AB0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17CA90", Offset = "0x17CB91")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		// Token: 0x0400B9BD RID: 47549
		[Token(Token = "0x4008AB1")]
		[FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		// Token: 0x0400B9BE RID: 47550
		[Token(Token = "0x4008AB2")]
		[FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		// Token: 0x0400B9BF RID: 47551
		[Token(Token = "0x4008AB3")]
		[FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		// Token: 0x0400B9C0 RID: 47552
		[Token(Token = "0x4008AB4")]
		[FieldOffset(Offset = "0x40")]
		private VRIK ik;
	}
}
