using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001343 RID: 4931
	[Token(Token = "0x2000D0E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D600", Offset = "0x14D701")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D600", Offset = "0x14D701")]
	public class SetUpVector : Action
	{
		// Token: 0x060073F1 RID: 29681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A5")]
		[Address(RVA = "0x299F540", Offset = "0x299F641", VA = "0x299F540", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x000280C8 File Offset: 0x000262C8
		[Token(Token = "0x60060A6")]
		[Address(RVA = "0x299F640", Offset = "0x299F741", VA = "0x299F640", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A7")]
		[Address(RVA = "0x299F730", Offset = "0x299F831", VA = "0x299F730", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A8")]
		[Address(RVA = "0x299F7C0", Offset = "0x299F8C1", VA = "0x299F7C0")]
		public SetUpVector()
		{
		}

		// Token: 0x0401B6E4 RID: 112356
		[Token(Token = "0x4018105")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1866B0", Offset = "0x1867B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6E5 RID: 112357
		[Token(Token = "0x4018106")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1866F0", Offset = "0x1867F1")]
		public SharedVector3 position;

		// Token: 0x0401B6E6 RID: 112358
		[Token(Token = "0x4018107")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6E7 RID: 112359
		[Token(Token = "0x4018108")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
