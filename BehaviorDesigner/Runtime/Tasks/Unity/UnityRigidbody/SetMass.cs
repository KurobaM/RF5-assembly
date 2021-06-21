using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013B6 RID: 5046
	[Token(Token = "0x2000D81")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150170", Offset = "0x150271")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150170", Offset = "0x150271")]
	public class SetMass : Action
	{
		// Token: 0x0600758E RID: 30094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006242")]
		[Address(RVA = "0x2993FF0", Offset = "0x29940F1", VA = "0x2993FF0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x00028B90 File Offset: 0x00026D90
		[Token(Token = "0x6006243")]
		[Address(RVA = "0x29940F0", Offset = "0x29941F1", VA = "0x29940F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006244")]
		[Address(RVA = "0x29941E0", Offset = "0x29942E1", VA = "0x29941E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006245")]
		[Address(RVA = "0x2994230", Offset = "0x2994331", VA = "0x2994230")]
		public SetMass()
		{
		}

		// Token: 0x0401B853 RID: 112723
		[Token(Token = "0x4018274")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A450", Offset = "0x18A551")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B854 RID: 112724
		[Token(Token = "0x4018275")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A490", Offset = "0x18A591")]
		public SharedFloat mass;

		// Token: 0x0401B855 RID: 112725
		[Token(Token = "0x4018276")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B856 RID: 112726
		[Token(Token = "0x4018277")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
