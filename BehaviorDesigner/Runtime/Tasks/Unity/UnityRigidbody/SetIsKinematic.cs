using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013B5 RID: 5045
	[Token(Token = "0x2000D80")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150110", Offset = "0x150211")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150110", Offset = "0x150211")]
	public class SetIsKinematic : Action
	{
		// Token: 0x0600758A RID: 30090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623E")]
		[Address(RVA = "0x2993D90", Offset = "0x2993E91", VA = "0x2993D90", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x00028B78 File Offset: 0x00026D78
		[Token(Token = "0x600623F")]
		[Address(RVA = "0x2993E90", Offset = "0x2993F91", VA = "0x2993E90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006240")]
		[Address(RVA = "0x2993F90", Offset = "0x2994091", VA = "0x2993F90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006241")]
		[Address(RVA = "0x2993FE0", Offset = "0x29940E1", VA = "0x2993FE0")]
		public SetIsKinematic()
		{
		}

		// Token: 0x0401B84F RID: 112719
		[Token(Token = "0x4018270")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A3D0", Offset = "0x18A4D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B850 RID: 112720
		[Token(Token = "0x4018271")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A410", Offset = "0x18A511")]
		public SharedBool isKinematic;

		// Token: 0x0401B851 RID: 112721
		[Token(Token = "0x4018272")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B852 RID: 112722
		[Token(Token = "0x4018273")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
