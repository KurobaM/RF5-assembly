using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D81 RID: 3457
	[Token(Token = "0x20008DC")]
	public class BodyTilt : OffsetModifier
	{
		// Token: 0x060059B6 RID: 22966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A57")]
		[Address(RVA = "0x286E680", Offset = "0x286E781", VA = "0x286E680", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A58")]
		[Address(RVA = "0x286E6D0", Offset = "0x286E7D1", VA = "0x286E6D0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A59")]
		[Address(RVA = "0x286E910", Offset = "0x286EA11", VA = "0x286E910")]
		public BodyTilt()
		{
		}

		// Token: 0x0400B8EB RID: 47339
		[Token(Token = "0x4008A67")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C090", Offset = "0x17C191")]
		public float tiltSpeed;

		// Token: 0x0400B8EC RID: 47340
		[Token(Token = "0x4008A68")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C0D0", Offset = "0x17C1D1")]
		public float tiltSensitivity;

		// Token: 0x0400B8ED RID: 47341
		[Token(Token = "0x4008A69")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C110", Offset = "0x17C211")]
		public OffsetPose poseLeft;

		// Token: 0x0400B8EE RID: 47342
		[Token(Token = "0x4008A6A")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C150", Offset = "0x17C251")]
		public OffsetPose poseRight;

		// Token: 0x0400B8EF RID: 47343
		[Token(Token = "0x4008A6B")]
		[FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		// Token: 0x0400B8F0 RID: 47344
		[Token(Token = "0x4008A6C")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;
	}
}
