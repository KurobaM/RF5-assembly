using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCapsuleCollider
{
	// Token: 0x02001470 RID: 5232
	[Token(Token = "0x2000E36")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154550", Offset = "0x154651")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154550", Offset = "0x154651")]
	public class SetCenter : Action
	{
		// Token: 0x0600780E RID: 30734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C2")]
		[Address(RVA = "0x28E0A10", Offset = "0x28E0B11", VA = "0x28E0A10", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x00029CA0 File Offset: 0x00027EA0
		[Token(Token = "0x60064C3")]
		[Address(RVA = "0x28E0B10", Offset = "0x28E0C11", VA = "0x28E0B10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C4")]
		[Address(RVA = "0x28E0C00", Offset = "0x28E0D01", VA = "0x28E0C00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C5")]
		[Address(RVA = "0x28E0C90", Offset = "0x28E0D91", VA = "0x28E0C90")]
		public SetCenter()
		{
		}

		// Token: 0x0401BACB RID: 113355
		[Token(Token = "0x40184C9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190D70", Offset = "0x190E71")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BACC RID: 113356
		[Token(Token = "0x40184CA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190DB0", Offset = "0x190EB1")]
		public SharedVector3 center;

		// Token: 0x0401BACD RID: 113357
		[Token(Token = "0x40184CB")]
		[FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		// Token: 0x0401BACE RID: 113358
		[Token(Token = "0x40184CC")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
