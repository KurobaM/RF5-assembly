using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D4A RID: 3402
	[Token(Token = "0x20008C7")]
	[Serializable]
	public class IKSolverTrigonometric : IKSolver
	{
		// Token: 0x060057C8 RID: 22472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492D")]
		[Address(RVA = "0x2581250", Offset = "0x2581351", VA = "0x2581250")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492E")]
		[Address(RVA = "0x2581440", Offset = "0x2581541", VA = "0x2581440")]
		public void SetBendPlaneToCurrent()
		{
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492F")]
		[Address(RVA = "0x2581600", Offset = "0x2581701", VA = "0x2581600")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004930")]
		[Address(RVA = "0x2581620", Offset = "0x2581721", VA = "0x2581620")]
		public void SetIKRotationWeight(float weight)
		{
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		[Token(Token = "0x6004931")]
		[Address(RVA = "0x25816B0", Offset = "0x25817B1", VA = "0x25816B0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
		[Token(Token = "0x6004932")]
		[Address(RVA = "0x25816C0", Offset = "0x25817C1", VA = "0x25816C0")]
		public float GetIKRotationWeight()
		{
			return 0f;
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004933")]
		[Address(RVA = "0x25816D0", Offset = "0x25817D1", VA = "0x25816D0", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004934")]
		[Address(RVA = "0x2581800", Offset = "0x2581901", VA = "0x2581800", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004935")]
		[Address(RVA = "0x2581920", Offset = "0x2581A21", VA = "0x2581920", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004936")]
		[Address(RVA = "0x25819F0", Offset = "0x2581AF1", VA = "0x25819F0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x0001CDE8 File Offset: 0x0001AFE8
		[Token(Token = "0x6004937")]
		[Address(RVA = "0x2581A50", Offset = "0x2581B51", VA = "0x2581A50", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x0001CE00 File Offset: 0x0001B000
		[Token(Token = "0x6004938")]
		[Address(RVA = "0x2581E60", Offset = "0x2581F61", VA = "0x2581E60")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004939")]
		[Address(RVA = "0x2581EE0", Offset = "0x2581FE1", VA = "0x2581EE0")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x0001CE18 File Offset: 0x0001B018
		[Token(Token = "0x600493A")]
		[Address(RVA = "0x2582480", Offset = "0x2582581", VA = "0x2582480")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493B")]
		[Address(RVA = "0x25826B0", Offset = "0x25827B1", VA = "0x25826B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x0001CE30 File Offset: 0x0001B030
		[Token(Token = "0x600493C")]
		[Address(RVA = "0x2582880", Offset = "0x2582981", VA = "0x2582880")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493D")]
		[Address(RVA = "0x25827F0", Offset = "0x25828F1", VA = "0x25827F0")]
		private void InitiateBones()
		{
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493E")]
		[Address(RVA = "0x2582B40", Offset = "0x2582C41", VA = "0x2582B40", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493F")]
		[Address(RVA = "0x2583620", Offset = "0x2583721", VA = "0x2583620", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004940")]
		[Address(RVA = "0x2583630", Offset = "0x2583731", VA = "0x2583630", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004941")]
		[Address(RVA = "0x2583640", Offset = "0x2583741", VA = "0x2583640", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x0001CE48 File Offset: 0x0001B048
		[Token(Token = "0x6004942")]
		[Address(RVA = "0x2583240", Offset = "0x2583341", VA = "0x2583240")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004943")]
		[Address(RVA = "0x257E460", Offset = "0x257E561", VA = "0x257E460")]
		public IKSolverTrigonometric()
		{
		}

		// Token: 0x0400B6ED RID: 46829
		[Token(Token = "0x400898A")]
		[FieldOffset(Offset = "0x58")]
		public Transform target;

		// Token: 0x0400B6EE RID: 46830
		[Token(Token = "0x400898B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17ACB0", Offset = "0x17ADB1")]
		public float IKRotationWeight;

		// Token: 0x0400B6EF RID: 46831
		[Token(Token = "0x400898C")]
		[FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		// Token: 0x0400B6F0 RID: 46832
		[Token(Token = "0x400898D")]
		[FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		// Token: 0x0400B6F1 RID: 46833
		[Token(Token = "0x400898E")]
		[FieldOffset(Offset = "0x80")]
		public IKSolverTrigonometric.TrigonometricBone bone1;

		// Token: 0x0400B6F2 RID: 46834
		[Token(Token = "0x400898F")]
		[FieldOffset(Offset = "0x88")]
		public IKSolverTrigonometric.TrigonometricBone bone2;

		// Token: 0x0400B6F3 RID: 46835
		[Token(Token = "0x4008990")]
		[FieldOffset(Offset = "0x90")]
		public IKSolverTrigonometric.TrigonometricBone bone3;

		// Token: 0x0400B6F4 RID: 46836
		[Token(Token = "0x4008991")]
		[FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		// Token: 0x0400B6F5 RID: 46837
		[Token(Token = "0x4008992")]
		[FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		// Token: 0x02000D4B RID: 3403
		[Token(Token = "0x20013FC")]
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone
		{
			// Token: 0x060057DF RID: 22495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007965")]
			[Address(RVA = "0x25829A0", Offset = "0x2582AA1", VA = "0x25829A0")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			// Token: 0x060057E0 RID: 22496 RVA: 0x0001CE60 File Offset: 0x0001B060
			[Token(Token = "0x6007966")]
			[Address(RVA = "0x2583560", Offset = "0x2583661", VA = "0x2583560")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			// Token: 0x060057E1 RID: 22497 RVA: 0x0001CE78 File Offset: 0x0001B078
			[Token(Token = "0x6007967")]
			[Address(RVA = "0x257CEB0", Offset = "0x257CFB1", VA = "0x257CEB0")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			// Token: 0x060057E2 RID: 22498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007968")]
			[Address(RVA = "0x2583650", Offset = "0x2583751", VA = "0x2583650")]
			public TrigonometricBone()
			{
			}

			// Token: 0x0400B6F6 RID: 46838
			[Token(Token = "0x401B9A7")]
			[FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			// Token: 0x0400B6F7 RID: 46839
			[Token(Token = "0x401B9A8")]
			[FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;
		}
	}
}
