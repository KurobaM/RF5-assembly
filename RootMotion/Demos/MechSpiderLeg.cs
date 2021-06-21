using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CAF RID: 3247
	[Token(Token = "0x2000854")]
	public class MechSpiderLeg : MonoBehaviour
	{
		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06005395 RID: 21397 RVA: 0x0001BBA0 File Offset: 0x00019DA0
		[Token(Token = "0x17000896")]
		public bool isStepping
		{
			[Token(Token = "0x60045AF")]
			[Address(RVA = "0x29B8F70", Offset = "0x29B9071", VA = "0x29B8F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06005396 RID: 21398 RVA: 0x0001BBB8 File Offset: 0x00019DB8
		// (set) Token: 0x06005397 RID: 21399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000897")]
		public Vector3 position
		{
			[Token(Token = "0x60045B0")]
			[Address(RVA = "0x29B8B00", Offset = "0x29B8C01", VA = "0x29B8B00")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60045B1")]
			[Address(RVA = "0x29B8F90", Offset = "0x29B9091", VA = "0x29B8F90")]
			set
			{
			}
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B2")]
		[Address(RVA = "0x29B8FE0", Offset = "0x29B90E1", VA = "0x29B8FE0")]
		private void Awake()
		{
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x29B9270", Offset = "0x29B9371", VA = "0x29B9270")]
		private void AfterIK()
		{
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x29B9490", Offset = "0x29B9591", VA = "0x29B9490")]
		private void Start()
		{
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x29B9860", Offset = "0x29B9961", VA = "0x29B9860")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B6")]
		[Address(RVA = "0x29B9C60", Offset = "0x29B9D61", VA = "0x29B9C60")]
		private void UpdatePosition(float distance)
		{
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x29B9ED0", Offset = "0x29B9FD1", VA = "0x29B9ED0")]
		private void Update()
		{
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B8")]
		[Address(RVA = "0x29B9790", Offset = "0x29B9891", VA = "0x29B9790")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A96D0", Offset = "0x1A97D1")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B9")]
		[Address(RVA = "0x29BA1D0", Offset = "0x29BA2D1", VA = "0x29BA1D0")]
		public MechSpiderLeg()
		{
		}

		// Token: 0x0400B269 RID: 45673
		[Token(Token = "0x40085EE")]
		[FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		// Token: 0x0400B26A RID: 45674
		[Token(Token = "0x40085EF")]
		[FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		// Token: 0x0400B26B RID: 45675
		[Token(Token = "0x40085F0")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		// Token: 0x0400B26C RID: 45676
		[Token(Token = "0x40085F1")]
		[FieldOffset(Offset = "0x34")]
		public float minDelay;

		// Token: 0x0400B26D RID: 45677
		[Token(Token = "0x40085F2")]
		[FieldOffset(Offset = "0x38")]
		public float maxOffset;

		// Token: 0x0400B26E RID: 45678
		[Token(Token = "0x40085F3")]
		[FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		// Token: 0x0400B26F RID: 45679
		[Token(Token = "0x40085F4")]
		[FieldOffset(Offset = "0x40")]
		public float footHeight;

		// Token: 0x0400B270 RID: 45680
		[Token(Token = "0x40085F5")]
		[FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		// Token: 0x0400B271 RID: 45681
		[Token(Token = "0x40085F6")]
		[FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		// Token: 0x0400B272 RID: 45682
		[Token(Token = "0x40085F7")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		// Token: 0x0400B273 RID: 45683
		[Token(Token = "0x40085F8")]
		[FieldOffset(Offset = "0x58")]
		public Transform foot;

		// Token: 0x0400B274 RID: 45684
		[Token(Token = "0x40085F9")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		// Token: 0x0400B275 RID: 45685
		[Token(Token = "0x40085FA")]
		[FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		// Token: 0x0400B276 RID: 45686
		[Token(Token = "0x40085FB")]
		[FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		// Token: 0x0400B277 RID: 45687
		[Token(Token = "0x40085FC")]
		[FieldOffset(Offset = "0x78")]
		private IK ik;

		// Token: 0x0400B278 RID: 45688
		[Token(Token = "0x40085FD")]
		[FieldOffset(Offset = "0x80")]
		private float stepProgress;

		// Token: 0x0400B279 RID: 45689
		[Token(Token = "0x40085FE")]
		[FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		// Token: 0x0400B27A RID: 45690
		[Token(Token = "0x40085FF")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		// Token: 0x0400B27B RID: 45691
		[Token(Token = "0x4008600")]
		[FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		// Token: 0x0400B27C RID: 45692
		[Token(Token = "0x4008601")]
		[FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		// Token: 0x0400B27D RID: 45693
		[Token(Token = "0x4008602")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		// Token: 0x0400B27E RID: 45694
		[Token(Token = "0x4008603")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		// Token: 0x02000CB0 RID: 3248
		[Token(Token = "0x20013D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159730", Offset = "0x159831")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060053A0 RID: 21408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B0")]
			[Address(RVA = "0x29BA1A0", Offset = "0x29BA2A1", VA = "0x29BA1A0")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			// Token: 0x060053A1 RID: 21409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B1")]
			[Address(RVA = "0x29BA290", Offset = "0x29BA391", VA = "0x29BA290", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060053A2 RID: 21410 RVA: 0x0001BBE8 File Offset: 0x00019DE8
			[Token(Token = "0x60078B2")]
			[Address(RVA = "0x29BA2A0", Offset = "0x29BA3A1", VA = "0x29BA2A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000ACF RID: 2767
			// (get) Token: 0x060053A3 RID: 21411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DF4")]
			private object Current
			{
				[Token(Token = "0x60078B3")]
				[Address(RVA = "0x29BA6D0", Offset = "0x29BA7D1", VA = "0x29BA6D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060053A4 RID: 21412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B4")]
			[Address(RVA = "0x29BA6E0", Offset = "0x29BA7E1", VA = "0x29BA6E0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000AD0 RID: 2768
			// (get) Token: 0x060053A5 RID: 21413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DF5")]
			private object Current
			{
				[Token(Token = "0x60078B5")]
				[Address(RVA = "0x29BA740", Offset = "0x29BA841", VA = "0x29BA740", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B27F RID: 45695
			[Token(Token = "0x401B8BF")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B280 RID: 45696
			[Token(Token = "0x401B8C0")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B281 RID: 45697
			[Token(Token = "0x401B8C1")]
			[FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			// Token: 0x0400B282 RID: 45698
			[Token(Token = "0x401B8C2")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			// Token: 0x0400B283 RID: 45699
			[Token(Token = "0x401B8C3")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;
		}
	}
}
