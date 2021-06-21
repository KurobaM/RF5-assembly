using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014A8 RID: 5288
	[Token(Token = "0x2000E6E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155A50", Offset = "0x155B51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155A50", Offset = "0x155B51")]
	public class GetLayerWeight : Action
	{
		// Token: 0x060078EB RID: 30955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659F")]
		[Address(RVA = "0x28D59A0", Offset = "0x28D5AA1", VA = "0x28D59A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x0002A1E0 File Offset: 0x000283E0
		[Token(Token = "0x60065A0")]
		[Address(RVA = "0x28D5AA0", Offset = "0x28D5BA1", VA = "0x28D5AA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A1")]
		[Address(RVA = "0x28D5BB0", Offset = "0x28D5CB1", VA = "0x28D5BB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A2")]
		[Address(RVA = "0x28D5C10", Offset = "0x28D5D11", VA = "0x28D5C10")]
		public GetLayerWeight()
		{
		}

		// Token: 0x0401BBA7 RID: 113575
		[Token(Token = "0x40185A5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192B60", Offset = "0x192C61")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBA8 RID: 113576
		[Token(Token = "0x40185A6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192BA0", Offset = "0x192CA1")]
		public SharedInt index;

		// Token: 0x0401BBA9 RID: 113577
		[Token(Token = "0x40185A7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192BE0", Offset = "0x192CE1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x192BE0", Offset = "0x192CE1")]
		public SharedFloat storeValue;

		// Token: 0x0401BBAA RID: 113578
		[Token(Token = "0x40185A8")]
		[FieldOffset(Offset = "0x68")]
		private Animator animator;

		// Token: 0x0401BBAB RID: 113579
		[Token(Token = "0x40185A9")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
