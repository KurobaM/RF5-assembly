using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001399 RID: 5017
	[Token(Token = "0x2000D64")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F640", Offset = "0x14F741")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F640", Offset = "0x14F741")]
	public class WakeUp : Conditional
	{
		// Token: 0x0600751A RID: 29978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CE")]
		[Address(RVA = "0x2998AD0", Offset = "0x2998BD1", VA = "0x2998AD0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600751B RID: 29979 RVA: 0x000288D8 File Offset: 0x00026AD8
		[Token(Token = "0x60061CF")]
		[Address(RVA = "0x2998BD0", Offset = "0x2998CD1", VA = "0x2998BD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600751C RID: 29980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D0")]
		[Address(RVA = "0x2998CB0", Offset = "0x2998DB1", VA = "0x2998CB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600751D RID: 29981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D1")]
		[Address(RVA = "0x2998CC0", Offset = "0x2998DC1", VA = "0x2998CC0")]
		public WakeUp()
		{
		}

		// Token: 0x0401B7D8 RID: 112600
		[Token(Token = "0x40181F9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189360", Offset = "0x189461")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7D9 RID: 112601
		[Token(Token = "0x40181FA")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7DA RID: 112602
		[Token(Token = "0x40181FB")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
