using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D21 RID: 3361
	[Token(Token = "0x20008AB")]
	[Attribute(Name = "RequireComponent", RVA = "0x148510", Offset = "0x148611")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148510", Offset = "0x148611")]
	public class CCDIKJ : MonoBehaviour
	{
		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06005625 RID: 22053 RVA: 0x0001C530 File Offset: 0x0001A730
		// (set) Token: 0x06005626 RID: 22054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B7")]
		public bool initiated
		{
			[Token(Token = "0x60047D1")]
			[Address(RVA = "0x286EB00", Offset = "0x286EC01", VA = "0x286EB00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAB60", Offset = "0x1AAC61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047D2")]
			[Address(RVA = "0x286EB10", Offset = "0x286EC11", VA = "0x286EB10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAB70", Offset = "0x1AAC71")]
			private set
			{
			}
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D3")]
		[Address(RVA = "0x286EB20", Offset = "0x286EC21", VA = "0x286EB20")]
		private void OnEnable()
		{
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D4")]
		[Address(RVA = "0x286F2E0", Offset = "0x286F3E1", VA = "0x286F2E0")]
		private void Update()
		{
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D5")]
		[Address(RVA = "0x286F470", Offset = "0x286F571", VA = "0x286F470")]
		private void OnDisable()
		{
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D6")]
		[Address(RVA = "0x286F590", Offset = "0x286F691", VA = "0x286F590")]
		public CCDIKJ()
		{
		}

		// Token: 0x0400B563 RID: 46435
		[Token(Token = "0x4008845")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179E50", Offset = "0x179F51")]
		public Transform target;

		// Token: 0x0400B564 RID: 46436
		[Token(Token = "0x4008846")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179E90", Offset = "0x179F91")]
		[Attribute(Name = "RangeAttribute", RVA = "0x179E90", Offset = "0x179F91")]
		public float weight;

		// Token: 0x0400B565 RID: 46437
		[Token(Token = "0x4008847")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179EF0", Offset = "0x179FF1")]
		public float tolerance;

		// Token: 0x0400B566 RID: 46438
		[Token(Token = "0x4008848")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179F30", Offset = "0x17A031")]
		public int maxIterations;

		// Token: 0x0400B567 RID: 46439
		[Token(Token = "0x4008849")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179F70", Offset = "0x17A071")]
		public bool useRotationLimits;

		// Token: 0x0400B568 RID: 46440
		[Token(Token = "0x400884A")]
		[FieldOffset(Offset = "0x2D")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179FB0", Offset = "0x17A0B1")]
		public bool XY;

		// Token: 0x0400B569 RID: 46441
		[Token(Token = "0x400884B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179FF0", Offset = "0x17A0F1")]
		public Transform[] bones;

		// Token: 0x0400B56A RID: 46442
		[Token(Token = "0x400884C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17A030", Offset = "0x17A131")]
		private bool <initiated>k__BackingField;

		// Token: 0x0400B56B RID: 46443
		[Token(Token = "0x400884D")]
		[FieldOffset(Offset = "0x40")]
		private Animator animator;

		// Token: 0x0400B56C RID: 46444
		[Token(Token = "0x400884E")]
		[FieldOffset(Offset = "0x48")]
		private PlayableGraph graph;

		// Token: 0x0400B56D RID: 46445
		[Token(Token = "0x400884F")]
		[FieldOffset(Offset = "0x58")]
		private AnimationScriptPlayable IKPlayable;

		// Token: 0x0400B56E RID: 46446
		[Token(Token = "0x4008850")]
		[FieldOffset(Offset = "0x68")]
		private CCDIKJob job;
	}
}
