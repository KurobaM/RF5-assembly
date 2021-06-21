using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D92 RID: 3474
	[Token(Token = "0x20008E1")]
	public class LookAtController : MonoBehaviour
	{
		// Token: 0x06005A03 RID: 23043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A67")]
		[Address(RVA = "0x27C46E0", Offset = "0x27C47E1", VA = "0x27C46E0")]
		private void Start()
		{
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x27C4920", Offset = "0x27C4A21", VA = "0x27C4920")]
		private void LateUpdate()
		{
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06005A05 RID: 23045 RVA: 0x0001DA00 File Offset: 0x0001BC00
		[Token(Token = "0x170008F3")]
		private Vector3 pivot
		{
			[Token(Token = "0x6004A69")]
			[Address(RVA = "0x27C47D0", Offset = "0x27C48D1", VA = "0x27C47D0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06005A06 RID: 23046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0x27C4FF0", Offset = "0x27C50F1", VA = "0x27C4FF0")]
		private void ApplyMinDistance()
		{
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6B")]
		[Address(RVA = "0x27C5190", Offset = "0x27C5291", VA = "0x27C5190")]
		private void RootRotation()
		{
		}

		// Token: 0x06005A08 RID: 23048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x27C54B0", Offset = "0x27C55B1", VA = "0x27C54B0")]
		public LookAtController()
		{
		}

		// Token: 0x0400B936 RID: 47414
		[Token(Token = "0x4008A75")]
		[FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		// Token: 0x0400B937 RID: 47415
		[Token(Token = "0x4008A76")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17C310", Offset = "0x17C411")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C310", Offset = "0x17C411")]
		public Transform target;

		// Token: 0x0400B938 RID: 47416
		[Token(Token = "0x4008A77")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17C370", Offset = "0x17C471")]
		public float weight;

		// Token: 0x0400B939 RID: 47417
		[Token(Token = "0x4008A78")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		// Token: 0x0400B93A RID: 47418
		[Token(Token = "0x4008A79")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C390", Offset = "0x17C491")]
		public float targetSwitchSmoothTime;

		// Token: 0x0400B93B RID: 47419
		[Token(Token = "0x4008A7A")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C3D0", Offset = "0x17C4D1")]
		public float weightSmoothTime;

		// Token: 0x0400B93C RID: 47420
		[Token(Token = "0x4008A7B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17C410", Offset = "0x17C511")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C410", Offset = "0x17C511")]
		public bool smoothTurnTowardsTarget;

		// Token: 0x0400B93D RID: 47421
		[Token(Token = "0x4008A7C")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C470", Offset = "0x17C571")]
		public float maxRadiansDelta;

		// Token: 0x0400B93E RID: 47422
		[Token(Token = "0x4008A7D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C4B0", Offset = "0x17C5B1")]
		public float maxMagnitudeDelta;

		// Token: 0x0400B93F RID: 47423
		[Token(Token = "0x4008A7E")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C4F0", Offset = "0x17C5F1")]
		public float slerpSpeed;

		// Token: 0x0400B940 RID: 47424
		[Token(Token = "0x4008A7F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C530", Offset = "0x17C631")]
		public Vector3 pivotOffsetFromRoot;

		// Token: 0x0400B941 RID: 47425
		[Token(Token = "0x4008A80")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C570", Offset = "0x17C671")]
		public float minDistance;

		// Token: 0x0400B942 RID: 47426
		[Token(Token = "0x4008A81")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17C5B0", Offset = "0x17C6B1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C5B0", Offset = "0x17C6B1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17C5B0", Offset = "0x17C6B1")]
		public float maxRootAngle;

		// Token: 0x0400B943 RID: 47427
		[Token(Token = "0x4008A82")]
		[FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		// Token: 0x0400B944 RID: 47428
		[Token(Token = "0x4008A83")]
		[FieldOffset(Offset = "0x70")]
		private float switchWeight;

		// Token: 0x0400B945 RID: 47429
		[Token(Token = "0x4008A84")]
		[FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		// Token: 0x0400B946 RID: 47430
		[Token(Token = "0x4008A85")]
		[FieldOffset(Offset = "0x78")]
		private float weightV;

		// Token: 0x0400B947 RID: 47431
		[Token(Token = "0x4008A86")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		// Token: 0x0400B948 RID: 47432
		[Token(Token = "0x4008A87")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		// Token: 0x0400B949 RID: 47433
		[Token(Token = "0x4008A88")]
		[FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;
	}
}
