using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace RootMotion.Demos
{
	// Token: 0x02000CF7 RID: 3319
	[Token(Token = "0x200088A")]
	[Serializable]
	public class Navigator
	{
		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060054BD RID: 21693 RVA: 0x0001BEA0 File Offset: 0x0001A0A0
		// (set) Token: 0x060054BE RID: 21694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089F")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60046A1")]
			[Address(RVA = "0x29BB6A0", Offset = "0x29BB7A1", VA = "0x29BB6A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9940", Offset = "0x1A9A41")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60046A2")]
			[Address(RVA = "0x29BB6B0", Offset = "0x29BB7B1", VA = "0x29BB6B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9950", Offset = "0x1A9A51")]
			private set
			{
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060054BF RID: 21695 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		// (set) Token: 0x060054C0 RID: 21696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A0")]
		public Navigator.State state
		{
			[Token(Token = "0x60046A3")]
			[Address(RVA = "0x29BB6C0", Offset = "0x29BB7C1", VA = "0x29BB6C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9960", Offset = "0x1A9A61")]
			get
			{
				return Navigator.State.Idle;
			}
			[Token(Token = "0x60046A4")]
			[Address(RVA = "0x29BB6D0", Offset = "0x29BB7D1", VA = "0x29BB6D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9970", Offset = "0x1A9A71")]
			private set
			{
			}
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A5")]
		[Address(RVA = "0x29BB6E0", Offset = "0x29BB7E1", VA = "0x29BB6E0")]
		public void Initiate(Transform transform)
		{
		}

		// Token: 0x060054C2 RID: 21698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A6")]
		[Address(RVA = "0x29BB7E0", Offset = "0x29BB8E1", VA = "0x29BB7E0")]
		public void Update(Vector3 targetPosition)
		{
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A7")]
		[Address(RVA = "0x29BBDF0", Offset = "0x29BBEF1", VA = "0x29BBDF0")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x0001BED0 File Offset: 0x0001A0D0
		[Token(Token = "0x60046A8")]
		[Address(RVA = "0x29BBEC0", Offset = "0x29BBFC1", VA = "0x29BBEC0")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A9")]
		[Address(RVA = "0x29BBCA0", Offset = "0x29BBDA1", VA = "0x29BBCA0")]
		private void Stop()
		{
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x0001BEE8 File Offset: 0x0001A0E8
		[Token(Token = "0x60046AA")]
		[Address(RVA = "0x29BBD20", Offset = "0x29BBE21", VA = "0x29BBD20")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return 0f;
		}

		// Token: 0x060054C7 RID: 21703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046AB")]
		[Address(RVA = "0x29BC000", Offset = "0x29BC101", VA = "0x29BC000")]
		public void Visualize()
		{
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046AC")]
		[Address(RVA = "0x29BC1D0", Offset = "0x29BC2D1", VA = "0x29BC1D0")]
		public Navigator()
		{
		}

		// Token: 0x0400B439 RID: 46137
		[Token(Token = "0x400875F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178680", Offset = "0x178781")]
		public bool activeTargetSeeking;

		// Token: 0x0400B43A RID: 46138
		[Token(Token = "0x4008760")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1786C0", Offset = "0x1787C1")]
		public float cornerRadius;

		// Token: 0x0400B43B RID: 46139
		[Token(Token = "0x4008761")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178700", Offset = "0x178801")]
		public float recalculateOnPathDistance;

		// Token: 0x0400B43C RID: 46140
		[Token(Token = "0x4008762")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178740", Offset = "0x178841")]
		public float maxSampleDistance;

		// Token: 0x0400B43D RID: 46141
		[Token(Token = "0x4008763")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178780", Offset = "0x178881")]
		public float nextPathInterval;

		// Token: 0x0400B43E RID: 46142
		[Token(Token = "0x4008764")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1787C0", Offset = "0x1788C1")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		// Token: 0x0400B43F RID: 46143
		[Token(Token = "0x4008765")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1787D0", Offset = "0x1788D1")]
		private Navigator.State <state>k__BackingField;

		// Token: 0x0400B440 RID: 46144
		[Token(Token = "0x4008766")]
		[FieldOffset(Offset = "0x38")]
		private Transform transform;

		// Token: 0x0400B441 RID: 46145
		[Token(Token = "0x4008767")]
		[FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		// Token: 0x0400B442 RID: 46146
		[Token(Token = "0x4008768")]
		[FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		// Token: 0x0400B443 RID: 46147
		[Token(Token = "0x4008769")]
		[FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		// Token: 0x0400B444 RID: 46148
		[Token(Token = "0x400876A")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		// Token: 0x0400B445 RID: 46149
		[Token(Token = "0x400876B")]
		[FieldOffset(Offset = "0x64")]
		private bool initiated;

		// Token: 0x0400B446 RID: 46150
		[Token(Token = "0x400876C")]
		[FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		// Token: 0x02000CF8 RID: 3320
		[Token(Token = "0x20013E6")]
		public enum State
		{
			// Token: 0x0400B448 RID: 46152
			[Token(Token = "0x401B91F")]
			Idle,
			// Token: 0x0400B449 RID: 46153
			[Token(Token = "0x401B920")]
			Seeking,
			// Token: 0x0400B44A RID: 46154
			[Token(Token = "0x401B921")]
			OnPath
		}
	}
}
