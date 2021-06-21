using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014A9 RID: 5289
	[Token(Token = "0x2000E6F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155AB0", Offset = "0x155BB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155AB0", Offset = "0x155BB1")]
	public class GetSpeed : Action
	{
		// Token: 0x060078EF RID: 30959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A3")]
		[Address(RVA = "0x28D5C20", Offset = "0x28D5D21", VA = "0x28D5C20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x0002A1F8 File Offset: 0x000283F8
		[Token(Token = "0x60065A4")]
		[Address(RVA = "0x28D5D20", Offset = "0x28D5E21", VA = "0x28D5D20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A5")]
		[Address(RVA = "0x28D5E10", Offset = "0x28D5F11", VA = "0x28D5E10", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A6")]
		[Address(RVA = "0x28D5E60", Offset = "0x28D5F61", VA = "0x28D5E60")]
		public GetSpeed()
		{
		}

		// Token: 0x0401BBAC RID: 113580
		[Token(Token = "0x40185AA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192C30", Offset = "0x192D31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBAD RID: 113581
		[Token(Token = "0x40185AB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192C70", Offset = "0x192D71")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x192C70", Offset = "0x192D71")]
		public SharedFloat storeValue;

		// Token: 0x0401BBAE RID: 113582
		[Token(Token = "0x40185AC")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BBAF RID: 113583
		[Token(Token = "0x40185AD")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
