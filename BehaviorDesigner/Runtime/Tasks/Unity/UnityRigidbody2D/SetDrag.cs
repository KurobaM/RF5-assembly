using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001393 RID: 5011
	[Token(Token = "0x2000D5E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F400", Offset = "0x14F501")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F400", Offset = "0x14F501")]
	public class SetDrag : Action
	{
		// Token: 0x06007502 RID: 29954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B6")]
		[Address(RVA = "0x2997CF0", Offset = "0x2997DF1", VA = "0x2997CF0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007503 RID: 29955 RVA: 0x00028848 File Offset: 0x00026A48
		[Token(Token = "0x60061B7")]
		[Address(RVA = "0x2997DF0", Offset = "0x2997EF1", VA = "0x2997DF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007504 RID: 29956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B8")]
		[Address(RVA = "0x2997EE0", Offset = "0x2997FE1", VA = "0x2997EE0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007505 RID: 29957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B9")]
		[Address(RVA = "0x2997F30", Offset = "0x2998031", VA = "0x2997F30")]
		public SetDrag()
		{
		}

		// Token: 0x0401B7C1 RID: 112577
		[Token(Token = "0x40181E2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1890A0", Offset = "0x1891A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7C2 RID: 112578
		[Token(Token = "0x40181E3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1890E0", Offset = "0x1891E1")]
		public SharedFloat drag;

		// Token: 0x0401B7C3 RID: 112579
		[Token(Token = "0x40181E4")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7C4 RID: 112580
		[Token(Token = "0x40181E5")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
