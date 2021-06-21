using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001390 RID: 5008
	[Token(Token = "0x2000D5B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F2E0", Offset = "0x14F3E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F2E0", Offset = "0x14F3E1")]
	public class MoveRotation : Action
	{
		// Token: 0x060074F6 RID: 29942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AA")]
		[Address(RVA = "0x2997600", Offset = "0x2997701", VA = "0x2997600", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x00028800 File Offset: 0x00026A00
		[Token(Token = "0x60061AB")]
		[Address(RVA = "0x2997700", Offset = "0x2997801", VA = "0x2997700", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AC")]
		[Address(RVA = "0x29977F0", Offset = "0x29978F1", VA = "0x29977F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AD")]
		[Address(RVA = "0x2997840", Offset = "0x2997941", VA = "0x2997840")]
		public MoveRotation()
		{
		}

		// Token: 0x0401B7B5 RID: 112565
		[Token(Token = "0x40181D6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188F20", Offset = "0x189021")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7B6 RID: 112566
		[Token(Token = "0x40181D7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188F60", Offset = "0x189061")]
		public SharedFloat rotation;

		// Token: 0x0401B7B7 RID: 112567
		[Token(Token = "0x40181D8")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7B8 RID: 112568
		[Token(Token = "0x40181D9")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
