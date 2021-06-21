using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D7C RID: 3452
	[Token(Token = "0x20008DA")]
	public class AimPoser : MonoBehaviour
	{
		// Token: 0x060059AA RID: 22954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A52")]
		[Address(RVA = "0x2862390", Offset = "0x2862491", VA = "0x2862390")]
		public AimPoser.Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A53")]
		[Address(RVA = "0x2862470", Offset = "0x2862571", VA = "0x2862470")]
		public void SetPoseActive(AimPoser.Pose pose)
		{
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A54")]
		[Address(RVA = "0x286C4C0", Offset = "0x286C5C1", VA = "0x286C4C0")]
		public AimPoser()
		{
		}

		// Token: 0x0400B8D7 RID: 47319
		[Token(Token = "0x4008A64")]
		[FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		// Token: 0x0400B8D8 RID: 47320
		[Token(Token = "0x4008A65")]
		[FieldOffset(Offset = "0x20")]
		public AimPoser.Pose[] poses;

		// Token: 0x02000D7D RID: 3453
		[Token(Token = "0x2001418")]
		[Serializable]
		public class Pose
		{
			// Token: 0x060059AD RID: 22957 RVA: 0x0001D880 File Offset: 0x0001BA80
			[Token(Token = "0x6007A21")]
			[Address(RVA = "0x286C220", Offset = "0x286C321", VA = "0x286C220")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			// Token: 0x060059AE RID: 22958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A22")]
			[Address(RVA = "0x286C540", Offset = "0x286C641", VA = "0x286C540")]
			public void SetAngleBuffer(float value)
			{
			}

			// Token: 0x060059AF RID: 22959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A23")]
			[Address(RVA = "0x286C550", Offset = "0x286C651", VA = "0x286C550")]
			public Pose()
			{
			}

			// Token: 0x0400B8D9 RID: 47321
			[Token(Token = "0x401BAA5")]
			[FieldOffset(Offset = "0x10")]
			public bool visualize;

			// Token: 0x0400B8DA RID: 47322
			[Token(Token = "0x401BAA6")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x0400B8DB RID: 47323
			[Token(Token = "0x401BAA7")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			// Token: 0x0400B8DC RID: 47324
			[Token(Token = "0x401BAA8")]
			[FieldOffset(Offset = "0x2C")]
			public float yaw;

			// Token: 0x0400B8DD RID: 47325
			[Token(Token = "0x401BAA9")]
			[FieldOffset(Offset = "0x30")]
			public float pitch;

			// Token: 0x0400B8DE RID: 47326
			[Token(Token = "0x401BAAA")]
			[FieldOffset(Offset = "0x34")]
			private float angleBuffer;
		}
	}
}
