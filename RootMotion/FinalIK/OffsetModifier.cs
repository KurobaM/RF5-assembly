using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D93 RID: 3475
	[Token(Token = "0x20008E2")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06005A09 RID: 23049 RVA: 0x0001DA18 File Offset: 0x0001BC18
		[Token(Token = "0x170008F4")]
		protected float deltaTime
		{
			[Token(Token = "0x6004A6D")]
			[Address(RVA = "0x27C5740", Offset = "0x27C5841", VA = "0x27C5740")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06005A0A RID: 23050
		[Token(Token = "0x6004A6E")]
		protected abstract void OnModifyOffset();

		// Token: 0x06005A0B RID: 23051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6F")]
		[Address(RVA = "0x27C5770", Offset = "0x27C5871", VA = "0x27C5770", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A70")]
		[Address(RVA = "0x27C5800", Offset = "0x27C5901", VA = "0x27C5800")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AB960", Offset = "0x1ABA61")]
		private IEnumerator Initiate()
		{
			return null;
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A71")]
		[Address(RVA = "0x27C58B0", Offset = "0x27C59B1", VA = "0x27C58B0")]
		private void ModifyOffset()
		{
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A72")]
		[Address(RVA = "0x27C59C0", Offset = "0x27C5AC1", VA = "0x27C59C0")]
		protected void ApplyLimits(OffsetModifier.OffsetLimits[] limits)
		{
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A73")]
		[Address(RVA = "0x27C5D00", Offset = "0x27C5E01", VA = "0x27C5D00", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A74")]
		[Address(RVA = "0x27C5E20", Offset = "0x27C5F21", VA = "0x27C5E20")]
		protected OffsetModifier()
		{
		}

		// Token: 0x0400B94A RID: 47434
		[Token(Token = "0x4008A89")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C630", Offset = "0x17C731")]
		public float weight;

		// Token: 0x0400B94B RID: 47435
		[Token(Token = "0x4008A8A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C670", Offset = "0x17C771")]
		public FullBodyBipedIK ik;

		// Token: 0x0400B94C RID: 47436
		[Token(Token = "0x4008A8B")]
		[FieldOffset(Offset = "0x28")]
		protected float lastTime;

		// Token: 0x02000D94 RID: 3476
		[Token(Token = "0x2001421")]
		[Serializable]
		public class OffsetLimits
		{
			// Token: 0x06005A11 RID: 23057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A57")]
			[Address(RVA = "0x27C5A80", Offset = "0x27C5B81", VA = "0x27C5A80")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			// Token: 0x06005A12 RID: 23058 RVA: 0x0001DA30 File Offset: 0x0001BC30
			[Token(Token = "0x6007A58")]
			[Address(RVA = "0x27C6020", Offset = "0x27C6121", VA = "0x27C6020")]
			private float SpringAxis(float value, float min, float max)
			{
				return 0f;
			}

			// Token: 0x06005A13 RID: 23059 RVA: 0x0001DA48 File Offset: 0x0001BC48
			[Token(Token = "0x6007A59")]
			[Address(RVA = "0x27C6140", Offset = "0x27C6241", VA = "0x27C6140")]
			private float Spring(float value, float limit, bool negative)
			{
				return 0f;
			}

			// Token: 0x06005A14 RID: 23060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A5A")]
			[Address(RVA = "0x27C6220", Offset = "0x27C6321", VA = "0x27C6220")]
			public OffsetLimits()
			{
			}

			// Token: 0x0400B94D RID: 47437
			[Token(Token = "0x401BADF")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198730", Offset = "0x198831")]
			public FullBodyBipedEffector effector;

			// Token: 0x0400B94E RID: 47438
			[Token(Token = "0x401BAE0")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198770", Offset = "0x198871")]
			public float spring;

			// Token: 0x0400B94F RID: 47439
			[Token(Token = "0x401BAE1")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1987B0", Offset = "0x1988B1")]
			public bool x;

			// Token: 0x0400B950 RID: 47440
			[Token(Token = "0x401BAE2")]
			[FieldOffset(Offset = "0x19")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1987F0", Offset = "0x1988F1")]
			public bool y;

			// Token: 0x0400B951 RID: 47441
			[Token(Token = "0x401BAE3")]
			[FieldOffset(Offset = "0x1A")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198830", Offset = "0x198931")]
			public bool z;

			// Token: 0x0400B952 RID: 47442
			[Token(Token = "0x401BAE4")]
			[FieldOffset(Offset = "0x1C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198870", Offset = "0x198971")]
			public float minX;

			// Token: 0x0400B953 RID: 47443
			[Token(Token = "0x401BAE5")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1988B0", Offset = "0x1989B1")]
			public float maxX;

			// Token: 0x0400B954 RID: 47444
			[Token(Token = "0x401BAE6")]
			[FieldOffset(Offset = "0x24")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1988F0", Offset = "0x1989F1")]
			public float minY;

			// Token: 0x0400B955 RID: 47445
			[Token(Token = "0x401BAE7")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198930", Offset = "0x198A31")]
			public float maxY;

			// Token: 0x0400B956 RID: 47446
			[Token(Token = "0x401BAE8")]
			[FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198970", Offset = "0x198A71")]
			public float minZ;

			// Token: 0x0400B957 RID: 47447
			[Token(Token = "0x401BAE9")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1989B0", Offset = "0x198AB1")]
			public float maxZ;
		}

		// Token: 0x02000D95 RID: 3477
		[Token(Token = "0x2001422")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1597A0", Offset = "0x1598A1")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005A15 RID: 23061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A5B")]
			[Address(RVA = "0x27C5880", Offset = "0x27C5981", VA = "0x27C5880")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			// Token: 0x06005A16 RID: 23062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A5C")]
			[Address(RVA = "0x27C5E30", Offset = "0x27C5F31", VA = "0x27C5E30", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005A17 RID: 23063 RVA: 0x0001DA60 File Offset: 0x0001BC60
			[Token(Token = "0x6007A5D")]
			[Address(RVA = "0x27C5E40", Offset = "0x27C5F41", VA = "0x27C5E40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B81 RID: 2945
			// (get) Token: 0x06005A18 RID: 23064 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E49")]
			private object Current
			{
				[Token(Token = "0x6007A5E")]
				[Address(RVA = "0x27C5FA0", Offset = "0x27C60A1", VA = "0x27C5FA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A19 RID: 23065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A5F")]
			[Address(RVA = "0x27C5FB0", Offset = "0x27C60B1", VA = "0x27C5FB0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B82 RID: 2946
			// (get) Token: 0x06005A1A RID: 23066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E4A")]
			private object Current
			{
				[Token(Token = "0x6007A60")]
				[Address(RVA = "0x27C6010", Offset = "0x27C6111", VA = "0x27C6010", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B958 RID: 47448
			[Token(Token = "0x401BAEA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B959 RID: 47449
			[Token(Token = "0x401BAEB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B95A RID: 47450
			[Token(Token = "0x401BAEC")]
			[FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;
		}
	}
}
