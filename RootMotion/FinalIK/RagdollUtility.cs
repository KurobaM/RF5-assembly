using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D6F RID: 3439
	[Token(Token = "0x20008D3")]
	[Attribute(Name = "RequireComponent", RVA = "0x148720", Offset = "0x148821")]
	public class RagdollUtility : MonoBehaviour
	{
		// Token: 0x06005940 RID: 22848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A02")]
		[Address(RVA = "0x27C7520", Offset = "0x27C7621", VA = "0x27C7520")]
		public void EnableRagdoll()
		{
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A03")]
		[Address(RVA = "0x27C75F0", Offset = "0x27C76F1", VA = "0x27C75F0")]
		public void DisableRagdoll()
		{
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A04")]
		[Address(RVA = "0x27C77D0", Offset = "0x27C78D1", VA = "0x27C77D0")]
		public void Start()
		{
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A05")]
		[Address(RVA = "0x27C7750", Offset = "0x27C7851", VA = "0x27C7750")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AB460", Offset = "0x1AB561")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A06")]
		[Address(RVA = "0x27C7E60", Offset = "0x27C7F61", VA = "0x27C7E60")]
		private void Update()
		{
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A07")]
		[Address(RVA = "0x27C80B0", Offset = "0x27C81B1", VA = "0x27C80B0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A08")]
		[Address(RVA = "0x27C81D0", Offset = "0x27C82D1", VA = "0x27C81D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A09")]
		[Address(RVA = "0x27C8500", Offset = "0x27C8601", VA = "0x27C8500")]
		private void AfterLastIK()
		{
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0A")]
		[Address(RVA = "0x27C8250", Offset = "0x27C8351", VA = "0x27C8250")]
		private void AfterAnimation()
		{
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0B")]
		[Address(RVA = "0x27C8460", Offset = "0x27C8561", VA = "0x27C8460")]
		private void OnFinalPose()
		{
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0C")]
		[Address(RVA = "0x27C85B0", Offset = "0x27C86B1", VA = "0x27C85B0")]
		private void RagdollEnabler()
		{
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x0600594B RID: 22859 RVA: 0x0001D5B0 File Offset: 0x0001B7B0
		[Token(Token = "0x170008EC")]
		private bool isRagdoll
		{
			[Token(Token = "0x6004A0D")]
			[Address(RVA = "0x27C7560", Offset = "0x27C7661", VA = "0x27C7560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0E")]
		[Address(RVA = "0x27C8540", Offset = "0x27C8641", VA = "0x27C8540")]
		private void RecordVelocities()
		{
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x0600594D RID: 22861 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
		[Token(Token = "0x170008ED")]
		private bool ikUsed
		{
			[Token(Token = "0x6004A0F")]
			[Address(RVA = "0x27C8300", Offset = "0x27C8401", VA = "0x27C8300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A10")]
		[Address(RVA = "0x27C76A0", Offset = "0x27C77A1", VA = "0x27C76A0")]
		private void StoreLocalState()
		{
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A11")]
		[Address(RVA = "0x27C8150", Offset = "0x27C8251", VA = "0x27C8150")]
		private void FixTransforms(float weight)
		{
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A12")]
		[Address(RVA = "0x27C8D90", Offset = "0x27C8E91", VA = "0x27C8D90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A13")]
		[Address(RVA = "0x27C8EC0", Offset = "0x27C8FC1", VA = "0x27C8EC0")]
		public RagdollUtility()
		{
		}

		// Token: 0x0400B87D RID: 47229
		[Token(Token = "0x4008A24")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B840", Offset = "0x17B941")]
		public IK ik;

		// Token: 0x0400B87E RID: 47230
		[Token(Token = "0x4008A25")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B880", Offset = "0x17B981")]
		public float ragdollToAnimationTime;

		// Token: 0x0400B87F RID: 47231
		[Token(Token = "0x4008A26")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B8C0", Offset = "0x17B9C1")]
		public bool applyIkOnRagdoll;

		// Token: 0x0400B880 RID: 47232
		[Token(Token = "0x4008A27")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B900", Offset = "0x17BA01")]
		public float applyVelocity;

		// Token: 0x0400B881 RID: 47233
		[Token(Token = "0x4008A28")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B940", Offset = "0x17BA41")]
		public float applyAngularVelocity;

		// Token: 0x0400B882 RID: 47234
		[Token(Token = "0x4008A29")]
		[FieldOffset(Offset = "0x30")]
		private Animator animator;

		// Token: 0x0400B883 RID: 47235
		[Token(Token = "0x4008A2A")]
		[FieldOffset(Offset = "0x38")]
		private RagdollUtility.Rigidbone[] rigidbones;

		// Token: 0x0400B884 RID: 47236
		[Token(Token = "0x4008A2B")]
		[FieldOffset(Offset = "0x40")]
		private RagdollUtility.Child[] children;

		// Token: 0x0400B885 RID: 47237
		[Token(Token = "0x4008A2C")]
		[FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		// Token: 0x0400B886 RID: 47238
		[Token(Token = "0x4008A2D")]
		[FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		// Token: 0x0400B887 RID: 47239
		[Token(Token = "0x4008A2E")]
		[FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		// Token: 0x0400B888 RID: 47240
		[Token(Token = "0x4008A2F")]
		[FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		// Token: 0x0400B889 RID: 47241
		[Token(Token = "0x4008A30")]
		[FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		// Token: 0x0400B88A RID: 47242
		[Token(Token = "0x4008A31")]
		[FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		// Token: 0x0400B88B RID: 47243
		[Token(Token = "0x4008A32")]
		[FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		// Token: 0x0400B88C RID: 47244
		[Token(Token = "0x4008A33")]
		[FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		// Token: 0x02000D70 RID: 3440
		[Token(Token = "0x2001412")]
		public class Rigidbone
		{
			// Token: 0x06005952 RID: 22866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A07")]
			[Address(RVA = "0x27C7C00", Offset = "0x27C7D01", VA = "0x27C7C00")]
			public Rigidbone(Rigidbody r)
			{
			}

			// Token: 0x06005953 RID: 22867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A08")]
			[Address(RVA = "0x27C8A00", Offset = "0x27C8B01", VA = "0x27C8A00")]
			public void RecordVelocity()
			{
			}

			// Token: 0x06005954 RID: 22868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A09")]
			[Address(RVA = "0x27C87D0", Offset = "0x27C88D1", VA = "0x27C87D0")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}

			// Token: 0x0400B88D RID: 47245
			[Token(Token = "0x401BA8B")]
			[FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			// Token: 0x0400B88E RID: 47246
			[Token(Token = "0x401BA8C")]
			[FieldOffset(Offset = "0x18")]
			public Transform t;

			// Token: 0x0400B88F RID: 47247
			[Token(Token = "0x401BA8D")]
			[FieldOffset(Offset = "0x20")]
			public Collider collider;

			// Token: 0x0400B890 RID: 47248
			[Token(Token = "0x401BA8E")]
			[FieldOffset(Offset = "0x28")]
			public Joint joint;

			// Token: 0x0400B891 RID: 47249
			[Token(Token = "0x401BA8F")]
			[FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			// Token: 0x0400B892 RID: 47250
			[Token(Token = "0x401BA90")]
			[FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			// Token: 0x0400B893 RID: 47251
			[Token(Token = "0x401BA91")]
			[FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			// Token: 0x0400B894 RID: 47252
			[Token(Token = "0x401BA92")]
			[FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			// Token: 0x0400B895 RID: 47253
			[Token(Token = "0x401BA93")]
			[FieldOffset(Offset = "0x58")]
			public float deltaTime;

			// Token: 0x0400B896 RID: 47254
			[Token(Token = "0x401BA94")]
			[FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			// Token: 0x0400B897 RID: 47255
			[Token(Token = "0x401BA95")]
			[FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;
		}

		// Token: 0x02000D71 RID: 3441
		[Token(Token = "0x2001413")]
		public class Child
		{
			// Token: 0x06005955 RID: 22869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A0A")]
			[Address(RVA = "0x27C7DB0", Offset = "0x27C7EB1", VA = "0x27C7DB0")]
			public Child(Transform transform)
			{
			}

			// Token: 0x06005956 RID: 22870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A0B")]
			[Address(RVA = "0x27C8BC0", Offset = "0x27C8CC1", VA = "0x27C8BC0")]
			public void FixTransform(float weight)
			{
			}

			// Token: 0x06005957 RID: 22871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A0C")]
			[Address(RVA = "0x27C8B60", Offset = "0x27C8C61", VA = "0x27C8B60")]
			public void StoreLocalState()
			{
			}

			// Token: 0x0400B898 RID: 47256
			[Token(Token = "0x401BA96")]
			[FieldOffset(Offset = "0x10")]
			public Transform t;

			// Token: 0x0400B899 RID: 47257
			[Token(Token = "0x401BA97")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			// Token: 0x0400B89A RID: 47258
			[Token(Token = "0x401BA98")]
			[FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;
		}

		// Token: 0x02000D72 RID: 3442
		[Token(Token = "0x2001414")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159780", Offset = "0x159881")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005958 RID: 22872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A0D")]
			[Address(RVA = "0x27C7E30", Offset = "0x27C7F31", VA = "0x27C7E30")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			// Token: 0x06005959 RID: 22873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A0E")]
			[Address(RVA = "0x27C8FD0", Offset = "0x27C90D1", VA = "0x27C8FD0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600595A RID: 22874 RVA: 0x0001D5E0 File Offset: 0x0001B7E0
			[Token(Token = "0x6007A0F")]
			[Address(RVA = "0x27C8FE0", Offset = "0x27C90E1", VA = "0x27C8FE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x0600595B RID: 22875 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E37")]
			private object Current
			{
				[Token(Token = "0x6007A10")]
				[Address(RVA = "0x27C9240", Offset = "0x27C9341", VA = "0x27C9240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600595C RID: 22876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A11")]
			[Address(RVA = "0x27C9250", Offset = "0x27C9351", VA = "0x27C9250", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x0600595D RID: 22877 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E38")]
			private object Current
			{
				[Token(Token = "0x6007A12")]
				[Address(RVA = "0x27C92B0", Offset = "0x27C93B1", VA = "0x27C92B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B89B RID: 47259
			[Token(Token = "0x401BA99")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B89C RID: 47260
			[Token(Token = "0x401BA9A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B89D RID: 47261
			[Token(Token = "0x401BA9B")]
			[FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;
		}
	}
}
