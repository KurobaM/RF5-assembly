using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBoxCollider
{
	// Token: 0x02001478 RID: 5240
	[Token(Token = "0x2000E3E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154850", Offset = "0x154951")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154850", Offset = "0x154951")]
	public class SetCenter : Action
	{
		// Token: 0x0600782E RID: 30766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E2")]
		[Address(RVA = "0x28DF640", Offset = "0x28DF741", VA = "0x28DF640", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x00029D60 File Offset: 0x00027F60
		[Token(Token = "0x60064E3")]
		[Address(RVA = "0x28DF740", Offset = "0x28DF841", VA = "0x28DF740", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E4")]
		[Address(RVA = "0x28DF830", Offset = "0x28DF931", VA = "0x28DF830", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E5")]
		[Address(RVA = "0x28DF8C0", Offset = "0x28DF9C1", VA = "0x28DF8C0")]
		public SetCenter()
		{
		}

		// Token: 0x0401BAEB RID: 113387
		[Token(Token = "0x40184E9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1911A0", Offset = "0x1912A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAEC RID: 113388
		[Token(Token = "0x40184EA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1911E0", Offset = "0x1912E1")]
		public SharedVector3 center;

		// Token: 0x0401BAED RID: 113389
		[Token(Token = "0x40184EB")]
		[FieldOffset(Offset = "0x60")]
		private BoxCollider boxCollider;

		// Token: 0x0401BAEE RID: 113390
		[Token(Token = "0x40184EC")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
