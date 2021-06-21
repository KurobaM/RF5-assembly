using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBoxCollider
{
	// Token: 0x02001479 RID: 5241
	[Token(Token = "0x2000E3F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1548B0", Offset = "0x1549B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1548B0", Offset = "0x1549B1")]
	public class SetSize : Action
	{
		// Token: 0x06007832 RID: 30770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E6")]
		[Address(RVA = "0x28DF8D0", Offset = "0x28DF9D1", VA = "0x28DF8D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x00029D78 File Offset: 0x00027F78
		[Token(Token = "0x60064E7")]
		[Address(RVA = "0x28DF9D0", Offset = "0x28DFAD1", VA = "0x28DF9D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007834 RID: 30772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E8")]
		[Address(RVA = "0x28DFAC0", Offset = "0x28DFBC1", VA = "0x28DFAC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E9")]
		[Address(RVA = "0x28DFB50", Offset = "0x28DFC51", VA = "0x28DFB50")]
		public SetSize()
		{
		}

		// Token: 0x0401BAEF RID: 113391
		[Token(Token = "0x40184ED")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191220", Offset = "0x191321")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAF0 RID: 113392
		[Token(Token = "0x40184EE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191260", Offset = "0x191361")]
		public SharedVector3 size;

		// Token: 0x0401BAF1 RID: 113393
		[Token(Token = "0x40184EF")]
		[FieldOffset(Offset = "0x60")]
		private BoxCollider boxCollider;

		// Token: 0x0401BAF2 RID: 113394
		[Token(Token = "0x40184F0")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
