using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D57 RID: 3415
	[Token(Token = "0x20008C9")]
	public class TwistRelaxer : MonoBehaviour
	{
		// Token: 0x0600587D RID: 22653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004962")]
		[Address(RVA = "0x27CFC60", Offset = "0x27CFD61", VA = "0x27CFC60")]
		public void Relax()
		{
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004963")]
		[Address(RVA = "0x27D0040", Offset = "0x27D0141", VA = "0x27D0040")]
		private void Start()
		{
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004964")]
		[Address(RVA = "0x27D04F0", Offset = "0x27D05F1", VA = "0x27D04F0")]
		private void OnPostUpdate()
		{
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004965")]
		[Address(RVA = "0x27D0580", Offset = "0x27D0681", VA = "0x27D0580")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004966")]
		[Address(RVA = "0x27D0610", Offset = "0x27D0711", VA = "0x27D0610")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005882 RID: 22658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004967")]
		[Address(RVA = "0x27D0740", Offset = "0x27D0841", VA = "0x27D0740")]
		public TwistRelaxer()
		{
		}

		// Token: 0x0400B7D5 RID: 47061
		[Token(Token = "0x40089B7")]
		[FieldOffset(Offset = "0x18")]
		public IK ik;

		// Token: 0x0400B7D6 RID: 47062
		[Token(Token = "0x40089B8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17AF00", Offset = "0x17B001")]
		public Transform parent;

		// Token: 0x0400B7D7 RID: 47063
		[Token(Token = "0x40089B9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17AF40", Offset = "0x17B041")]
		public Transform child;

		// Token: 0x0400B7D8 RID: 47064
		[Token(Token = "0x40089BA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17AF80", Offset = "0x17B081")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AF80", Offset = "0x17B081")]
		public float weight;

		// Token: 0x0400B7D9 RID: 47065
		[Token(Token = "0x40089BB")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17AFE0", Offset = "0x17B0E1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AFE0", Offset = "0x17B0E1")]
		public float parentChildCrossfade;

		// Token: 0x0400B7DA RID: 47066
		[Token(Token = "0x40089BC")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B040", Offset = "0x17B141")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17B040", Offset = "0x17B141")]
		public float twistAngleOffset;

		// Token: 0x0400B7DB RID: 47067
		[Token(Token = "0x40089BD")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		// Token: 0x0400B7DC RID: 47068
		[Token(Token = "0x40089BE")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		// Token: 0x0400B7DD RID: 47069
		[Token(Token = "0x40089BF")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		// Token: 0x0400B7DE RID: 47070
		[Token(Token = "0x40089C0")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;
	}
}
