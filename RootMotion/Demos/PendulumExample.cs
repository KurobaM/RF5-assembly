using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CCF RID: 3279
	[Token(Token = "0x200086C")]
	[Attribute(Name = "RequireComponent", RVA = "0x147B10", Offset = "0x147C11")]
	public class PendulumExample : MonoBehaviour
	{
		// Token: 0x0600540F RID: 21519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004616")]
		[Address(RVA = "0x285EE10", Offset = "0x285EF11", VA = "0x285EE10")]
		private void Start()
		{
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004617")]
		[Address(RVA = "0x285F160", Offset = "0x285F261", VA = "0x285F160")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004618")]
		[Address(RVA = "0x285F8B0", Offset = "0x285F9B1", VA = "0x285F8B0")]
		public PendulumExample()
		{
		}

		// Token: 0x0400B330 RID: 45872
		[Token(Token = "0x400868E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177DC0", Offset = "0x177EC1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177DC0", Offset = "0x177EC1")]
		public float weight;

		// Token: 0x0400B331 RID: 45873
		[Token(Token = "0x400868F")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177E20", Offset = "0x177F21")]
		public float hangingDistanceMlp;

		// Token: 0x0400B332 RID: 45874
		[Token(Token = "0x4008690")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177E60", Offset = "0x177F61")]
		[Attribute(Name = "HideInInspector", RVA = "0x177E60", Offset = "0x177F61")]
		public Vector3 rootTargetPosition;

		// Token: 0x0400B333 RID: 45875
		[Token(Token = "0x4008691")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177EB0", Offset = "0x177FB1")]
		[Attribute(Name = "HideInInspector", RVA = "0x177EB0", Offset = "0x177FB1")]
		public Quaternion rootTargetRotation;

		// Token: 0x0400B334 RID: 45876
		[Token(Token = "0x4008692")]
		[FieldOffset(Offset = "0x40")]
		public Transform target;

		// Token: 0x0400B335 RID: 45877
		[Token(Token = "0x4008693")]
		[FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		// Token: 0x0400B336 RID: 45878
		[Token(Token = "0x4008694")]
		[FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		// Token: 0x0400B337 RID: 45879
		[Token(Token = "0x4008695")]
		[FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		// Token: 0x0400B338 RID: 45880
		[Token(Token = "0x4008696")]
		[FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		// Token: 0x0400B339 RID: 45881
		[Token(Token = "0x4008697")]
		[FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		// Token: 0x0400B33A RID: 45882
		[Token(Token = "0x4008698")]
		[FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		// Token: 0x0400B33B RID: 45883
		[Token(Token = "0x4008699")]
		[FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		// Token: 0x0400B33C RID: 45884
		[Token(Token = "0x400869A")]
		[FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		// Token: 0x0400B33D RID: 45885
		[Token(Token = "0x400869B")]
		[FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		// Token: 0x0400B33E RID: 45886
		[Token(Token = "0x400869C")]
		[FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		// Token: 0x0400B33F RID: 45887
		[Token(Token = "0x400869D")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		// Token: 0x0400B340 RID: 45888
		[Token(Token = "0x400869E")]
		[FieldOffset(Offset = "0xB4")]
		private float lastWeight;
	}
}
