using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D7A RID: 3450
	[Token(Token = "0x20008D9")]
	public class AimController : MonoBehaviour
	{
		// Token: 0x0600599D RID: 22941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4B")]
		[Address(RVA = "0x2866CD0", Offset = "0x2866DD1", VA = "0x2866CD0")]
		private void Start()
		{
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4C")]
		[Address(RVA = "0x2866F20", Offset = "0x2867021", VA = "0x2866F20")]
		private void LateUpdate()
		{
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600599F RID: 22943 RVA: 0x0001D850 File Offset: 0x0001BA50
		[Token(Token = "0x170008F1")]
		private Vector3 pivot
		{
			[Token(Token = "0x6004A4D")]
			[Address(RVA = "0x2866DD0", Offset = "0x2866ED1", VA = "0x2866DD0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060059A0 RID: 22944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4E")]
		[Address(RVA = "0x2867670", Offset = "0x2867771", VA = "0x2867670")]
		private void ApplyMinDistance()
		{
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4F")]
		[Address(RVA = "0x2867810", Offset = "0x2867911", VA = "0x2867810")]
		private void RootRotation()
		{
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A50")]
		[Address(RVA = "0x2867C40", Offset = "0x2867D41", VA = "0x2867C40")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AB8F0", Offset = "0x1AB9F1")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A51")]
		[Address(RVA = "0x2867CF0", Offset = "0x2867DF1", VA = "0x2867CF0")]
		public AimController()
		{
		}

		// Token: 0x0400B8B9 RID: 47289
		[Token(Token = "0x4008A49")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BB50", Offset = "0x17BC51")]
		public AimIK ik;

		// Token: 0x0400B8BA RID: 47290
		[Token(Token = "0x4008A4A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BB90", Offset = "0x17BC91")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17BB90", Offset = "0x17BC91")]
		public float weight;

		// Token: 0x0400B8BB RID: 47291
		[Token(Token = "0x4008A4B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17BBF0", Offset = "0x17BCF1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BBF0", Offset = "0x17BCF1")]
		public Transform target;

		// Token: 0x0400B8BC RID: 47292
		[Token(Token = "0x4008A4C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BC50", Offset = "0x17BD51")]
		public float targetSwitchSmoothTime;

		// Token: 0x0400B8BD RID: 47293
		[Token(Token = "0x4008A4D")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BC90", Offset = "0x17BD91")]
		public float weightSmoothTime;

		// Token: 0x0400B8BE RID: 47294
		[Token(Token = "0x4008A4E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17BCD0", Offset = "0x17BDD1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BCD0", Offset = "0x17BDD1")]
		public bool smoothTurnTowardsTarget;

		// Token: 0x0400B8BF RID: 47295
		[Token(Token = "0x4008A4F")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BD30", Offset = "0x17BE31")]
		public float maxRadiansDelta;

		// Token: 0x0400B8C0 RID: 47296
		[Token(Token = "0x4008A50")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BD70", Offset = "0x17BE71")]
		public float maxMagnitudeDelta;

		// Token: 0x0400B8C1 RID: 47297
		[Token(Token = "0x4008A51")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BDB0", Offset = "0x17BEB1")]
		public float slerpSpeed;

		// Token: 0x0400B8C2 RID: 47298
		[Token(Token = "0x4008A52")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BDF0", Offset = "0x17BEF1")]
		public Vector3 pivotOffsetFromRoot;

		// Token: 0x0400B8C3 RID: 47299
		[Token(Token = "0x4008A53")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BE30", Offset = "0x17BF31")]
		public float minDistance;

		// Token: 0x0400B8C4 RID: 47300
		[Token(Token = "0x4008A54")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BE70", Offset = "0x17BF71")]
		public Vector3 offset;

		// Token: 0x0400B8C5 RID: 47301
		[Token(Token = "0x4008A55")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17BEB0", Offset = "0x17BFB1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BEB0", Offset = "0x17BFB1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17BEB0", Offset = "0x17BFB1")]
		public float maxRootAngle;

		// Token: 0x0400B8C6 RID: 47302
		[Token(Token = "0x4008A56")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BF30", Offset = "0x17C031")]
		public bool turnToTarget;

		// Token: 0x0400B8C7 RID: 47303
		[Token(Token = "0x4008A57")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BF70", Offset = "0x17C071")]
		public float turnToTargetTime;

		// Token: 0x0400B8C8 RID: 47304
		[Token(Token = "0x4008A58")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17BFB0", Offset = "0x17C0B1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17BFB0", Offset = "0x17C0B1")]
		public bool useAnimatedAimDirection;

		// Token: 0x0400B8C9 RID: 47305
		[Token(Token = "0x4008A59")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C010", Offset = "0x17C111")]
		public Vector3 animatedAimDirection;

		// Token: 0x0400B8CA RID: 47306
		[Token(Token = "0x4008A5A")]
		[FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		// Token: 0x0400B8CB RID: 47307
		[Token(Token = "0x4008A5B")]
		[FieldOffset(Offset = "0x88")]
		private float switchWeight;

		// Token: 0x0400B8CC RID: 47308
		[Token(Token = "0x4008A5C")]
		[FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		// Token: 0x0400B8CD RID: 47309
		[Token(Token = "0x4008A5D")]
		[FieldOffset(Offset = "0x90")]
		private float weightV;

		// Token: 0x0400B8CE RID: 47310
		[Token(Token = "0x4008A5E")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		// Token: 0x0400B8CF RID: 47311
		[Token(Token = "0x4008A5F")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		// Token: 0x0400B8D0 RID: 47312
		[Token(Token = "0x4008A60")]
		[FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		// Token: 0x0400B8D1 RID: 47313
		[Token(Token = "0x4008A61")]
		[FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		// Token: 0x0400B8D2 RID: 47314
		[Token(Token = "0x4008A62")]
		[FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		// Token: 0x0400B8D3 RID: 47315
		[Token(Token = "0x4008A63")]
		[FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		// Token: 0x02000D7B RID: 3451
		[Token(Token = "0x2001417")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159790", Offset = "0x159891")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060059A4 RID: 22948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A1B")]
			[Address(RVA = "0x2867CC0", Offset = "0x2867DC1", VA = "0x2867CC0")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			// Token: 0x060059A5 RID: 22949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A1C")]
			[Address(RVA = "0x2867DE0", Offset = "0x2867EE1", VA = "0x2867DE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060059A6 RID: 22950 RVA: 0x0001D868 File Offset: 0x0001BA68
			[Token(Token = "0x6007A1D")]
			[Address(RVA = "0x2867DF0", Offset = "0x2867EF1", VA = "0x2867DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B73 RID: 2931
			// (get) Token: 0x060059A7 RID: 22951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E3E")]
			private object Current
			{
				[Token(Token = "0x6007A1E")]
				[Address(RVA = "0x2867F30", Offset = "0x2868031", VA = "0x2867F30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060059A8 RID: 22952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A1F")]
			[Address(RVA = "0x2867F40", Offset = "0x2868041", VA = "0x2867F40", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x060059A9 RID: 22953 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E3F")]
			private object Current
			{
				[Token(Token = "0x6007A20")]
				[Address(RVA = "0x2867FA0", Offset = "0x28680A1", VA = "0x2867FA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B8D4 RID: 47316
			[Token(Token = "0x401BAA2")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B8D5 RID: 47317
			[Token(Token = "0x401BAA3")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B8D6 RID: 47318
			[Token(Token = "0x401BAA4")]
			[FieldOffset(Offset = "0x20")]
			public AimController <>4__this;
		}
	}
}
