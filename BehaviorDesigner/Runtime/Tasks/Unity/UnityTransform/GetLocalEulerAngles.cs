using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200132C RID: 4908
	[Token(Token = "0x2000CF7")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CD60", Offset = "0x14CE61")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CD60", Offset = "0x14CE61")]
	public class GetLocalEulerAngles : Action
	{
		// Token: 0x06007395 RID: 29589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006049")]
		[Address(RVA = "0x299B980", Offset = "0x299BA81", VA = "0x299B980", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x00027EA0 File Offset: 0x000260A0
		[Token(Token = "0x600604A")]
		[Address(RVA = "0x299BA80", Offset = "0x299BB81", VA = "0x299BA80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604B")]
		[Address(RVA = "0x299BB70", Offset = "0x299BC71", VA = "0x299BB70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604C")]
		[Address(RVA = "0x299BC00", Offset = "0x299BD01", VA = "0x299BC00")]
		public GetLocalEulerAngles()
		{
		}

		// Token: 0x0401B683 RID: 112259
		[Token(Token = "0x40180A4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185960", Offset = "0x185A61")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B684 RID: 112260
		[Token(Token = "0x40180A5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1859A0", Offset = "0x185AA1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1859A0", Offset = "0x185AA1")]
		public SharedVector3 storeValue;

		// Token: 0x0401B685 RID: 112261
		[Token(Token = "0x40180A6")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B686 RID: 112262
		[Token(Token = "0x40180A7")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
