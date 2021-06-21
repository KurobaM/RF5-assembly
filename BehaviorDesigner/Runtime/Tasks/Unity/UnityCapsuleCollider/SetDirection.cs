using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCapsuleCollider
{
	// Token: 0x02001471 RID: 5233
	[Token(Token = "0x2000E37")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1545B0", Offset = "0x1546B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1545B0", Offset = "0x1546B1")]
	public class SetDirection : Action
	{
		// Token: 0x06007812 RID: 30738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C6")]
		[Address(RVA = "0x28E0CA0", Offset = "0x28E0DA1", VA = "0x28E0CA0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x00029CB8 File Offset: 0x00027EB8
		[Token(Token = "0x60064C7")]
		[Address(RVA = "0x28E0DA0", Offset = "0x28E0EA1", VA = "0x28E0DA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C8")]
		[Address(RVA = "0x28E0EA0", Offset = "0x28E0FA1", VA = "0x28E0EA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C9")]
		[Address(RVA = "0x28E0EF0", Offset = "0x28E0FF1", VA = "0x28E0EF0")]
		public SetDirection()
		{
		}

		// Token: 0x0401BACF RID: 113359
		[Token(Token = "0x40184CD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190DF0", Offset = "0x190EF1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAD0 RID: 113360
		[Token(Token = "0x40184CE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190E30", Offset = "0x190F31")]
		public SharedInt direction;

		// Token: 0x0401BAD1 RID: 113361
		[Token(Token = "0x40184CF")]
		[FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		// Token: 0x0401BAD2 RID: 113362
		[Token(Token = "0x40184D0")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
