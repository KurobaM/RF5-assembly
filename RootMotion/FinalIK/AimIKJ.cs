using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D1F RID: 3359
	[Token(Token = "0x20008A9")]
	[Attribute(Name = "RequireComponent", RVA = "0x148480", Offset = "0x148581")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148480", Offset = "0x148581")]
	public class AimIKJ : MonoBehaviour
	{
		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0600560F RID: 22031 RVA: 0x0001C488 File Offset: 0x0001A688
		// (set) Token: 0x06005610 RID: 22032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B4")]
		public bool initiated
		{
			[Token(Token = "0x60047BB")]
			[Address(RVA = "0x28681D0", Offset = "0x28682D1", VA = "0x28681D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAB40", Offset = "0x1AAC41")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047BC")]
			[Address(RVA = "0x28681E0", Offset = "0x28682E1", VA = "0x28681E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAB50", Offset = "0x1AAC51")]
			private set
			{
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06005611 RID: 22033 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		// (set) Token: 0x06005612 RID: 22034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B5")]
		public Vector3 axis
		{
			[Token(Token = "0x60047BD")]
			[Address(RVA = "0x28681F0", Offset = "0x28682F1", VA = "0x28681F0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60047BE")]
			[Address(RVA = "0x2868230", Offset = "0x2868331", VA = "0x2868230")]
			set
			{
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06005613 RID: 22035 RVA: 0x0001C4B8 File Offset: 0x0001A6B8
		// (set) Token: 0x06005614 RID: 22036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B6")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x60047BF")]
			[Address(RVA = "0x2868240", Offset = "0x2868341", VA = "0x2868240")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60047C0")]
			[Address(RVA = "0x2868280", Offset = "0x2868381", VA = "0x2868280")]
			set
			{
			}
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C1")]
		[Address(RVA = "0x2868290", Offset = "0x2868391", VA = "0x2868290")]
		private void OnEnable()
		{
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C2")]
		[Address(RVA = "0x2869090", Offset = "0x2869191", VA = "0x2869090")]
		private void Update()
		{
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C3")]
		[Address(RVA = "0x2869450", Offset = "0x2869551", VA = "0x2869450")]
		private void OnDisable()
		{
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C4")]
		[Address(RVA = "0x2869560", Offset = "0x2869661", VA = "0x2869560")]
		public AimIKJ()
		{
		}

		// Token: 0x0400B52B RID: 46379
		[Token(Token = "0x400880D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179900", Offset = "0x179A01")]
		public Transform target;

		// Token: 0x0400B52C RID: 46380
		[Token(Token = "0x400880E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179940", Offset = "0x179A41")]
		public Transform poleTarget;

		// Token: 0x0400B52D RID: 46381
		[Token(Token = "0x400880F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179980", Offset = "0x179A81")]
		public Transform aimTransform;

		// Token: 0x0400B52E RID: 46382
		[Token(Token = "0x4008810")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x1799C0", Offset = "0x179AC1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1799C0", Offset = "0x179AC1")]
		public float axisX;

		// Token: 0x0400B52F RID: 46383
		[Token(Token = "0x4008811")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179A10", Offset = "0x179B11")]
		public float axisY;

		// Token: 0x0400B530 RID: 46384
		[Token(Token = "0x4008812")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179A50", Offset = "0x179B51")]
		public float axisZ;

		// Token: 0x0400B531 RID: 46385
		[Token(Token = "0x4008813")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x179A90", Offset = "0x179B91")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179A90", Offset = "0x179B91")]
		public float poleAxisX;

		// Token: 0x0400B532 RID: 46386
		[Token(Token = "0x4008814")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179AE0", Offset = "0x179BE1")]
		public float poleAxisY;

		// Token: 0x0400B533 RID: 46387
		[Token(Token = "0x4008815")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179B20", Offset = "0x179C21")]
		public float poleAxisZ;

		// Token: 0x0400B534 RID: 46388
		[Token(Token = "0x4008816")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x179B60", Offset = "0x179C61")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179B60", Offset = "0x179C61")]
		[Attribute(Name = "RangeAttribute", RVA = "0x179B60", Offset = "0x179C61")]
		public float weight;

		// Token: 0x0400B535 RID: 46389
		[Token(Token = "0x4008817")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179BD0", Offset = "0x179CD1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x179BD0", Offset = "0x179CD1")]
		public float poleWeight;

		// Token: 0x0400B536 RID: 46390
		[Token(Token = "0x4008818")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179C30", Offset = "0x179D31")]
		public float tolerance;

		// Token: 0x0400B537 RID: 46391
		[Token(Token = "0x4008819")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179C70", Offset = "0x179D71")]
		public int maxIterations;

		// Token: 0x0400B538 RID: 46392
		[Token(Token = "0x400881A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179CB0", Offset = "0x179DB1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x179CB0", Offset = "0x179DB1")]
		public float clampWeight;

		// Token: 0x0400B539 RID: 46393
		[Token(Token = "0x400881B")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179D10", Offset = "0x179E11")]
		[Attribute(Name = "RangeAttribute", RVA = "0x179D10", Offset = "0x179E11")]
		public int clampSmoothing;

		// Token: 0x0400B53A RID: 46394
		[Token(Token = "0x400881C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179D70", Offset = "0x179E71")]
		public bool useRotationLimits;

		// Token: 0x0400B53B RID: 46395
		[Token(Token = "0x400881D")]
		[FieldOffset(Offset = "0x61")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179DB0", Offset = "0x179EB1")]
		public bool XY;

		// Token: 0x0400B53C RID: 46396
		[Token(Token = "0x400881E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x179DF0", Offset = "0x179EF1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179DF0", Offset = "0x179EF1")]
		public Transform[] bones;

		// Token: 0x0400B53D RID: 46397
		[Token(Token = "0x400881F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x179E40", Offset = "0x179F41")]
		private bool <initiated>k__BackingField;

		// Token: 0x0400B53E RID: 46398
		[Token(Token = "0x4008820")]
		[FieldOffset(Offset = "0x78")]
		private Animator animator;

		// Token: 0x0400B53F RID: 46399
		[Token(Token = "0x4008821")]
		[FieldOffset(Offset = "0x80")]
		private PlayableGraph graph;

		// Token: 0x0400B540 RID: 46400
		[Token(Token = "0x4008822")]
		[FieldOffset(Offset = "0x90")]
		private AnimationScriptPlayable IKPlayable;

		// Token: 0x0400B541 RID: 46401
		[Token(Token = "0x4008823")]
		[FieldOffset(Offset = "0xA0")]
		private AimIKJob job;
	}
}
