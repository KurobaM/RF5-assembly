using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013AE RID: 5038
	[Token(Token = "0x2000D79")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FE70", Offset = "0x14FF71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FE70", Offset = "0x14FF71")]
	public class MoveRotation : Action
	{
		// Token: 0x0600756E RID: 30062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006222")]
		[Address(RVA = "0x2992CC0", Offset = "0x2992DC1", VA = "0x2992CC0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00028AD0 File Offset: 0x00026CD0
		[Token(Token = "0x6006223")]
		[Address(RVA = "0x2992DC0", Offset = "0x2992EC1", VA = "0x2992DC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006224")]
		[Address(RVA = "0x2992EB0", Offset = "0x2992FB1", VA = "0x2992EB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006225")]
		[Address(RVA = "0x2992F40", Offset = "0x2993041", VA = "0x2992F40")]
		public MoveRotation()
		{
		}

		// Token: 0x0401B833 RID: 112691
		[Token(Token = "0x4018254")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A050", Offset = "0x18A151")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B834 RID: 112692
		[Token(Token = "0x4018255")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A090", Offset = "0x18A191")]
		public SharedQuaternion rotation;

		// Token: 0x0401B835 RID: 112693
		[Token(Token = "0x4018256")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B836 RID: 112694
		[Token(Token = "0x4018257")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
